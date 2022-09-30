using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Net;
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
            _favicons.Images.Add("default_icon", Resources.default_icon); //the default icon is always at image index 0 with key "default_icon"

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
        
        private void UpdateURI(object sender, EventArgs args)
        {
            
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
            if (tabsListView.SelectedItems.Count == 0) return;

            IBrowserTab tabSelected = tabsListView.SelectedItems[0].Tag as IBrowserTab;
            if (!_tabs.Contains(tabSelected))
                _tabs.Add(tabSelected);

            splitContainer.Panel2.Controls.Clear();
            splitContainer.Panel2.Controls.Add(_tabs[_tabs.IndexOf(tabSelected)] as DefaultTabCtl);

            splitContainer.Panel2.Update();
        }
    }
}