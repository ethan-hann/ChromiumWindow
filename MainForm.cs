using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChromiumWindow.Interfaces;
using ChromiumWindow.Properties;
using ChromiumWindow.Utility;
using FarsiLibrary.Win;
using Krypton.Toolkit;
using Manina.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using static ChromiumWindow.Utility.CEventArgs;

namespace ChromiumWindow
{
    public partial class MainForm : KryptonForm
    {
        private readonly string[] _arguments;
        private readonly ObservableCollection<IBrowserTab> _tabs = new();
        private readonly List<ListViewItem> _listViewItems = new List<ListViewItem>();
        private readonly ImageList _favicons = new ImageList();

        public CoreWebView2Deferral Deferral;
        public CoreWebView2NewWindowRequestedEventArgs WindowArgs;

        public MainForm(string[] args)
        {
            InitializeComponent();
            _arguments = args;

            tabsListView.SmallImageList = _favicons; //set image list for favicons.
            _favicons.Images.Add("about://blank", Resources.default_icon); //the default icon is always at image index 0 with key "default_icon"

            GlobalVars.MainApplication = this; //set the main form for the application to this form.
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // //Parse arguments
            // ParseArguments();
            //
            // //Create our tabs
            CreateTabs();
            if (tabsListView.Items.Count > 0)
                tabsListView.FocusedItem = tabsListView.Items[0];
        }

        private void CreateTabs()
        {
            DefaultTabCtl initialTab = new DefaultTabCtl("DuckDuckGo", "https://duckduckgo.com")
            {
                Dock = DockStyle.Fill
            };
            DefaultTabCtl tab2 = new DefaultTabCtl("Bamboo", "https://teamlogicit.bamboohr.com/")
            {
                Dock = DockStyle.Fill
            };

            DefaultTabCtl tab3 = new DefaultTabCtl("Kaseya", "https://na1-tlvsa05.kaseya.net/vsapres/web20/core/login.aspx")
            {
                Dock = DockStyle.Fill
            };

            _tabs.Add(initialTab);
            _tabs.Add(tab2);
            _tabs.Add(tab3);
            //Add all browser tabs in _tabs to the TabControl
            foreach (IBrowserTab tab in _tabs)
            {
                ((DefaultTabCtl)tab).IconUpdated += UpdateTabIcon;
                ((DefaultTabCtl)tab).TitleChanged += UpdateTitle;
                ((DefaultTabCtl)tab).UriChanged += UpdateURI;
                ((DefaultTabCtl)tab).OnNavigationCompleted += NavigationCompleted;
                _listViewItems.Add(new ListViewItem()
                {
                    Text = tab.TabName,
                    Tag = tab,
                    ImageKey = tab.TabName
                });

                //TabPage tp = new TabPage(tab.TabName);
                //tp.Tag = tab; //add the IBrowserTab as an object tag for the TabPage control.
                //tp.Controls.Add((DefaultTabCtl)tab); //add the DefaultTabCtl control as a child of this tab page.
                //tp.ImageKey = tab.TabName;
                //((DefaultTabCtl)tab).IconUpdated += UpdateTabIcon; //add eventhandler for tab icon

                //browserTabs.TabPages.Add(tp); //Finally, add the TabPage to the browser tabs.
                // browserTabs.Update();
            }

            tabsListView.Items.AddRange(_listViewItems.ToArray());
        }

        private void NavigationCompleted(object sender, EventArgs args)
        {
            if (args is NavigationCompletedEventArgs e)
            {

            }
        }

        private void UpdateURI(object sender, EventArgs args)
        {
            if (args is PageUpdatedEventArgs e)
                Invoke(new Action(() => addressTxtBox.Text = e.Tab.TabUri.ToString()));
        }

        private void UpdateTitle(object sender, EventArgs args)
        {
            if (args is PageUpdatedEventArgs e)
                Invoke(new Action(() => _listViewItems.Find(l => l.Tag.Equals(e.Tab)).Text = e.Tab.TabName));
        }

        private void UpdateTabIcon(object sender, EventArgs args)
        {
            if (args is PageUpdatedEventArgs e)
                Invoke(new Action(() => _listViewItems.Find(l => l.Tag.Equals(e.Tab)).ImageKey = e.Tab.TabName));
        }

        private void ParseArguments()
        {
            var argumentsParsed = ParseArguments(_arguments);
            if (argumentsParsed == null)
            {
                Text = Resources.DefaultTitle;
                //webView.Source = new Uri("https://duckduckgo.com");
            }

            if (argumentsParsed?.Item1 != null)
                Text = argumentsParsed.Value.Item1;
            //if (argumentsParsed?.Item2 != null)
            //webView.Source = new Uri(argumentsParsed.Value.Item2);
        }

        private (string, string)? ParseArguments(string[] args)
        {
            switch (args.Length)
            {
                case 0:
                    return (Resources.DefaultTitle, "https://duckduckgo.com");
                case 1:
                    {
                        var tokens = args[0].Split('=');
                        if (tokens[0].Equals("title"))
                            return (tokens[1], null);
                        break;
                    }
                case 2:
                    {
                        var title = string.Empty;
                        var url = string.Empty;

                        foreach (var arg in args)
                        {
                            var tokens = arg.Split('=');
                            switch (tokens[0])
                            {
                                case "-title":
                                    title = tokens[1];
                                    break;
                                case "-url":
                                    url = tokens[1];
                                    break;
                            }
                        }

                        return (title, url);
                    }
                default:
                    {
                        Console.WriteLine(Resources.InvalidArgumentNumberError);
                        Application.Exit();
                        break;
                    }
            }

            return null;
        }

        public ImageList GetFavicons()
        {
            return _favicons;
        }

        
        private void tabsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            IBrowserTab tabSelected = GetSelectedTab();
            if (tabSelected == null) return;

            try
            {
                splitContainer.Panel2.Controls.Clear();
                splitContainer.Panel2.Controls.Add(_tabs[_tabs.IndexOf(tabSelected)] as DefaultTabCtl);

                splitContainer.Panel2.Update();
            } catch (Exception ex)
            {

            }           
        }

        private int tabSelectedIndex = 0; //keep track of the selected zero-based index of the tab we select.
        private IBrowserTab GetSelectedTab()
        {
            IBrowserTab tabSelected = null;
            if (tabsListView.SelectedItems.Count == 0) return tabSelected; //return null if we have no tabs

            if (tabsListView.SelectedItems[0].Index == tabSelectedIndex)
                return _tabs[tabSelectedIndex];

            if (tabsListView.SelectedItems.Count > 0)
            {
                tabSelected = tabsListView.SelectedItems[0].Tag as IBrowserTab;
                if (!_tabs.Contains(tabSelected))
                    _tabs.Add(tabSelected);
            }

            tabSelectedIndex = tabsListView.SelectedItems[0].Index; //update our selected index

            return tabSelected;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            if (_tabs.Count > 0)
            {
                DialogResult result = KryptonMessageBox.Show($"You have {_tabs.Count} tabs open.", "Close all tabs?", MessageBoxButtons.YesNo, KryptonMessageBoxIcon.WARNING);
                if (result == DialogResult.Yes)
                    Application.Exit();
            }
            else
            {
                Application.Exit();
            }

        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            addressBar.Width = Size.Width - navigationPanel.Size.Width - 32;
        }

        private void addressTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string fullUrl = addressTxtBox.Text;
                if (!Regex.IsMatch(fullUrl, "^[a-zA-Z0-9]+\\://"))
                    fullUrl = "http://" + fullUrl;

                IBrowserTab tab = GetSelectedTab();
                if (tab != null)
                {
                    try
                    {
                        tab.WebControl.CoreWebView2.Navigate(fullUrl);
                    } catch (Exception ex)
                    {
                        tab.WebControl.CoreWebView2.NavigateToString(Resources._404_html);
                    }
                }
                    
                //_tabs.First(e => e.WebControl.Equals(tab.WebControl)).WebControl.CoreWebView2.Navigate(fullUrl);
                e.Handled = true;
            }
        }
    }
}