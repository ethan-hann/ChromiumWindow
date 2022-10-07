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
using ChromiumWindow.pages;
using ChromiumWindow.Properties;
using ChromiumWindow.Utility;
using Krypton.Docking;
using Krypton.Navigator;
using Krypton.Toolkit;
using Krypton.Workspace;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static ChromiumWindow.Utility.CEventArgs;

namespace ChromiumWindow
{
    public partial class MainForm : KryptonForm
    {
        public KryptonDockingWorkspace DockingWorkspace;
        public BrowserPage SelectedTab;

        private readonly string[] _arguments;
        private readonly ObservableCollection<BrowserPage> _tabs = new();
        private readonly List<ListViewItem> _listViewItems = new List<ListViewItem>();
        private readonly ImageList _favicons = new ImageList();

        public CoreWebView2Deferral Deferral;
        public CoreWebView2NewWindowRequestedEventArgs WindowArgs;

        public MainForm(string[] args)
        {
            InitializeComponent();
            _arguments = args;

            //tabsListView.SmallImageList = _favicons; //set image list for favicons.
            _favicons.Images.Add("about://blank", Resources.default_icon); //the default icon is always at image index 0 with key "default_icon"

            GlobalVars.MainApplication = this; //set the main form for the application to this form.
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DockingWorkspace = dockingManager.ManageWorkspace("MainWorkspace", dockableWorkspace);
            dockingManager.ManageControl("Control", backPanel, DockingWorkspace);
            dockingManager.ManageFloating("Floating", this);
            dockingManager.DockableWorkspaceCellAdding += DockingManager_DockableWorkspaceCellAdding;
            dockableWorkspace.ActivePageChanged += UpdateSelectedTab;
            dockableWorkspace.CellVisibleCountChanged += DockableWorkspace_CellVisibleCountChanged;
            dockableWorkspace.PageCloseClicked += DockableWorkspace_PageCloseClicked;

            // //Parse arguments
            // ParseArguments();
            //
            // //Create our tabs
            CreateTabs();
            //if (tabsListView.Items.Count > 0)
             //   tabsListView.FocusedItem = tabsListView.Items[0];
        }

        //Ensure that at least one tab remains
        private void DockableWorkspace_PageCloseClicked(object sender, UniqueNameEventArgs e)
        {
            if (dockableWorkspace.AllPages().Length - 1 <= 0)
                SelectedTab = NewTab(null);
        }

        private void DockableWorkspace_CellVisibleCountChanged(object sender, EventArgs e)
        {
            if (dockingManager.Pages.Count() <= 0)
                SelectedTab = null;
        }

        #region Handle selected tab changes
        KryptonWorkspaceCell currentCell;
        private void DockingManager_DockableWorkspaceCellAdding(object sender, DockableWorkspaceCellEventArgs e)
        {
            currentCell = e.CellControl;
            currentCell.SelectedPageChanged += UpdateSelectedTab;
        }

        private void UpdateSelectedTab(object sender, EventArgs e)
        {
            if (currentCell != null && currentCell.SelectedPage != null)
            {
                if (e is ActivePageChangedEventArgs args)
                    SelectedTab = (BrowserPage)args.NewPage;
                else
                    SelectedTab = (BrowserPage)currentCell.SelectedPage;

                addressTxtBox.Text = SelectedTab.BrowserTab.TabUri.ToString();
            }
        }

        #endregion

        #region Handle creating new tabs

        /// <summary>
        /// Creates a new browser tab, adds it to the workspace, and sets it as the selected page.
        /// </summary>
        /// <param name="ctl">The <see cref="DefaultTabCtl"/> to add. If this value is null or non-existent, a new blank tab is created instead.</param>
        /// <returns>The browser tab that was added.</returns>
        public BrowserPage NewTab(DefaultTabCtl ctl = null)
        {
            BrowserPage page = new BrowserPage(ctl);

            //Handle events
            (page.BrowserTab as DefaultTabCtl).UriChanged += UpdateURI;
            (page.BrowserTab as DefaultTabCtl).TitleChanged += UpdateTitle;
            (page.BrowserTab as DefaultTabCtl).IconUpdated += UpdateTabIcon;
            (page.BrowserTab as DefaultTabCtl).OnNavigationCompleted += NavigationCompleted;

            _tabs.Add(page);
            dockingManager.AddToWorkspace("MainWorkspace", new KryptonPage[] { page });
            dockingManager.FindDockingWorkspace("MainWorkspace").SelectPage(page.UniqueName);
            SelectedTab = page;

            return page;
        }

        /// <summary>
        /// Creates a new browser tab, adds it to the workspace, and sets it as the selected page.
        /// </summary>
        /// <param name="ctl">The <see cref="IBrowserTab"/> to add. If this value is null or non-existent, a new blank tab is created instead.</param>
        /// <returns>The browser tab that was added.</returns>
        public BrowserPage NewTab(IBrowserTab tab = null)
        {
            BrowserPage page = new BrowserPage((DefaultTabCtl)tab);
            _tabs.Add(page);
            dockingManager.AddToWorkspace("MainWorkspace", new KryptonPage[] { page });
            dockingManager.FindDockingWorkspace("MainWorkspace").SelectPage(page.UniqueName);
            SelectedTab = page;

            return page;
        }
        #endregion

        private void CreateTabs(bool initialBlankTabOnly = true)
        {
            if (initialBlankTabOnly)
            {
                NewTab(null);
            }
            else
            {
                //DefaultTabCtl initialTab = new DefaultTabCtl("DuckDuckGo", "https://duckduckgo.com")
                //{
                //    Dock = DockStyle.Fill
                //};
                //DefaultTabCtl tab2 = new DefaultTabCtl("Bamboo", "https://teamlogicit.bamboohr.com/")
                //{
                //    Dock = DockStyle.Fill
                //};

                //DefaultTabCtl tab3 = new DefaultTabCtl("Kaseya", "https://na1-tlvsa05.kaseya.net/vsapres/web20/core/login.aspx")
                //{
                //    Dock = DockStyle.Fill
                //};

                //_tabs.Add(initialTab);
                //_tabs.Add(tab2);
                //_tabs.Add(tab3);
                ////Add all browser tabs in _tabs to the TabControl
                //foreach (IBrowserTab tab in _tabs)
                //{
                //    ((DefaultTabCtl)tab).IconUpdated += UpdateTabIcon;
                //    ((DefaultTabCtl)tab).TitleChanged += UpdateTitle;
                //    ((DefaultTabCtl)tab).UriChanged += UpdateURI;
                //    ((DefaultTabCtl)tab).OnNavigationCompleted += NavigationCompleted;
                //    _listViewItems.Add(new ListViewItem()
                //    {
                //        Text = tab.TabName,
                //        Tag = tab,
                //        ImageKey = tab.TabName
                //    });

                    //TabPage tp = new TabPage(tab.TabName);
                    //tp.Tag = tab; //add the IBrowserTab as an object tag for the TabPage control.
                    //tp.Controls.Add((DefaultTabCtl)tab); //add the DefaultTabCtl control as a child of this tab page.
                    //tp.ImageKey = tab.TabName;
                    //((DefaultTabCtl)tab).IconUpdated += UpdateTabIcon; //add eventhandler for tab icon

                    //browserTabs.TabPages.Add(tp); //Finally, add the TabPage to the browser tabs.
                    // browserTabs.Update();

                //tabsListView.Items.AddRange(_listViewItems.ToArray());
            }
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
            {
                BrowserPage page = (BrowserPage)dockingManager.Pages.Where(p => p.UniqueName.Equals(e.Tab.UniqueName)).First();
                Invoke(new Action(() => addressTxtBox.Text = page.BrowserTab.TabUri.ToString()));
            }
        }

        private void UpdateTitle(object sender, EventArgs args)
        {
            if (args is PageUpdatedEventArgs e)
            {
                BrowserPage page = (BrowserPage)dockingManager.Pages.Where(p => p.UniqueName.Equals(e.Tab.UniqueName)).First();
                Invoke(new Action(() => page.Text = page.BrowserTab.TabName));
            }
        }

        private void UpdateTabIcon(object sender, EventArgs args)
        {
            if (args is PageUpdatedEventArgs e)
            {
                BrowserPage page = (BrowserPage)dockingManager.Pages.Where(p => p.UniqueName.Equals(e.Tab.UniqueName)).First();
                Invoke(new Action(() => page.ImageSmall = (Bitmap)page.BrowserTab.TabImage));
            }
                
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

        private void backButton_Click(object sender, EventArgs e)
        {
            if (SelectedTab != null)
            {
                if (SelectedTab.BrowserTab.WebControl.CoreWebView2.CanGoBack)
                    SelectedTab.BrowserTab.WebControl.CoreWebView2.GoBack();
            }
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            if (SelectedTab != null)
            {
                if (SelectedTab.BrowserTab.WebControl.CoreWebView2.CanGoForward)
                    SelectedTab.BrowserTab.WebControl.CoreWebView2.GoForward();
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            if (SelectedTab != null)
            {
                try
                {
                    SelectedTab.BrowserTab.WebControl.CoreWebView2.Reload();
                } catch (Exception _) { }
            }
        }

        private void addressTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (SelectedTab == null)
                {
                    NewTab(null);
                }

                string fullUrl = addressTxtBox.Text;
                if (!Regex.IsMatch(fullUrl, "^[a-zA-Z0-9]+\\://"))
                    fullUrl = "http://" + fullUrl;

                try
                {
                    SelectedTab.BrowserTab.WebControl.CoreWebView2.Navigate(fullUrl);
                }
                catch (Exception _)
                {
                    SelectedTab.BrowserTab.WebControl.CoreWebView2.Navigate("http://local.folder/404/404.html");
                    //SelectedTab.BrowserTab.WebControl.CoreWebView2.NavigateToString(File.ReadAllText(".\\web\\404\\404.html"));
                }
                e.Handled = true;
            }
        }

        #region Main Menu Event Handlers
        private void newTabBtn_Click(object sender, EventArgs e)
        {
            NewTab(null);
        }

        private void saveTabsBtn_Click(object sender, EventArgs e)
        {

        }

        private void loadTabsBtn_Click(object sender, EventArgs e)
        {

        }

        private void lockViewBtn_Click(object sender, EventArgs e)
        {

        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void maximizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void chkShowTabs_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chkShowAddressBar_CheckedChanged(object sender, EventArgs e)
        {
            addressTxtBox.Visible = chkShowAddressBar.Checked;
        }

        private void chkShowMenuBar_CheckedChanged(object sender, EventArgs e)
        {
            if (topPanel.Visible)
            {
                DialogResult result = KryptonMessageBox.Show("You are hiding the navigation panel. Use the shortcut keys (CTRL + M) to show it again.", 
                    "Confirm", MessageBoxButtons.OKCancel, KryptonMessageBoxIcon.INFORMATION);
                if (result == DialogResult.OK)
                    topPanel.Visible = chkShowMenuBar.Checked;
            }
            else
            {
                topPanel.Visible = true;
            }
        }

        private void findBtn_Click(object sender, EventArgs e)
        {

        }

        private void printBtn_Click(object sender, EventArgs e)
        {

        }

        private void copyBtn_Click(object sender, EventArgs e)
        {

        }

        private void cutBtn_Click(object sender, EventArgs e)
        {

        }

        private void pasteBtn_Click(object sender, EventArgs e)
        {

        }

        private void userGuideBtn_Click(object sender, EventArgs e)
        {

        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {

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
        #endregion

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            addressTxtBox.Width = Size.Width - 120;
        }
    }
}