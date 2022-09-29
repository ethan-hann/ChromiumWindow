using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChromiumWindow.Forms;
using ChromiumWindow.Interfaces;
using ChromiumWindow.Properties;
using ChromiumWindow.Utility;
using EasyTabs;
using FarsiLibrary.Win;
using Manina.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace ChromiumWindow
{
    public partial class MainForm : TitleBarTabs
    {
        private readonly string[] _arguments;
        private readonly ObservableCollection<IBrowserTab> _tabs = new();
        public CoreWebView2Deferral Deferral;
        public CoreWebView2NewWindowRequestedEventArgs WindowArgs;

        public MainForm(string[] args)
        {
            InitializeComponent();
            _arguments = args;
            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // //Parse arguments
            // ParseArguments();
            //
            // //Create our tabs
            // CreateTabs();
        }
        
        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {
                Content = new BrowserTab()
                {
                    Text = "New Tab"
                }
            };
        }

        // private void CreateTabs()
        // {
        //     DefaultTabCtl initialTab = new DefaultTabCtl("DuckDuckGo", "https://duckduckgo.com")
        //     {
        //         Dock = DockStyle.Fill
        //     };
        //     DefaultTabCtl tab2 = new DefaultTabCtl("Bamboo", "https://teamlogicit.bamboohr.com/")
        //     {
        //         Dock = DockStyle.Fill
        //     };
        //     
        //     DefaultTabCtl tab3 = new DefaultTabCtl("Kaseya", "https://na1-tlvsa05.kaseya.net/vsapres/web20/core/login.aspx")
        //     {
        //         Dock = DockStyle.Fill
        //     };
        //     
        //     _tabs.Add(initialTab);
        //     _tabs.Add(tab2);
        //     _tabs.Add(tab3);
        //     
        //     //Add all browser tabs in _tabs to the TabControl
        //     foreach (IBrowserTab tab in _tabs)
        //     {
        //         ((DefaultTabCtl)tab).IconUpdated += UpdateTabIcon;
        //         ((DefaultTabCtl)tab).TitleChanged += UpdateTitle;
        //         ((DefaultTabCtl)tab).UriChanged += UpdateURI;
        //
        //         var tp = new FATabStripItem(tab.TabName, (DefaultTabCtl)tab);
        //         ((DefaultTabCtl)tab).TabControlItem = tp;
        //         browserTabStrip.AddTab(tp);
        //
        //
        //         //TabPage tp = new TabPage(tab.TabName);
        //         //tp.Tag = tab; //add the IBrowserTab as an object tag for the TabPage control.
        //         //tp.Controls.Add((DefaultTabCtl)tab); //add the DefaultTabCtl control as a child of this tab page.
        //         //tp.ImageKey = tab.TabName;
        //         //((DefaultTabCtl)tab).IconUpdated += UpdateTabIcon; //add eventhandler for tab icon
        //
        //         //browserTabs.TabPages.Add(tp); //Finally, add the TabPage to the browser tabs.
        //         // browserTabs.Update();
        //     }
        // }
        //
        // private void UpdateURI(object sender, EventArgs args)
        // {
        //     // if (args is not CEventArgs.PageUpdatedEventArgs e) return;
        //     //
        //     // var currentTab =
        //     //     browserTabStrip.Items[browserTabStrip.Items.IndexOf(((DefaultTabCtl)e.Tab).TabControlItem)];
        //     // currentTab.Title = ((DefaultTabCtl)e.Tab).TabName;
        // }
        //
        // private void UpdateTitle(object sender, EventArgs args)
        // {
        //     if (args is not CEventArgs.PageUpdatedEventArgs e) return;
        //     
        //     var currentTab =
        //         browserTabStrip.Items[browserTabStrip.Items.IndexOf(((DefaultTabCtl)e.Tab).TabControlItem)];
        //     currentTab.Title = ((DefaultTabCtl)e.Tab).TabName;
        // }
        //
        // private void UpdateTabIcon(object sender, EventArgs args)
        // {
        //     // if (args is CEventArgs.IconUpdatedEventArgs e)
        //     // {
        //     //     browserTabs.SelectedTab.Text = e.TabName;
        //     //     browserTabs.SelectedTab.ImageKey = e.TabName;
        //     // }
        // }
        //
        // private void ParseArguments()
        // {
        //     var argumentsParsed = ParseArguments(_arguments);
        //     if (argumentsParsed == null)
        //     {
        //         Text = Resources.DefaultTitle;
        //         //webView.Source = new Uri("https://duckduckgo.com");
        //     }
        //
        //     if (argumentsParsed?.Item1 != null)
        //         Text = argumentsParsed.Value.Item1;
        //     //if (argumentsParsed?.Item2 != null)
        //         //webView.Source = new Uri(argumentsParsed.Value.Item2);
        // }
        //
        // private (string, string)? ParseArguments(string[] args)
        // {
        //     switch (args.Length)
        //     {
        //         case 0:
        //             return (Resources.DefaultTitle, "https://duckduckgo.com");
        //         case 1:
        //         {
        //             var tokens = args[0].Split('=');
        //             if (tokens[0].Equals("title"))
        //                 return (tokens[1], null);
        //             break;
        //         }
        //         case 2:
        //         {
        //             var title = string.Empty;
        //             var url = string.Empty;
        //             
        //             foreach (var arg in args)
        //             {
        //                 var tokens = arg.Split('=');
        //                 switch (tokens[0])
        //                 {
        //                     case "-title":
        //                         title = tokens[1];
        //                         break;
        //                     case "-url":
        //                         url = tokens[1];
        //                         break;
        //                 }
        //             }
        //
        //             return (title, url);
        //         }
        //         default:
        //         {
        //             Console.WriteLine(Resources.InvalidArgumentNumberError);
        //             Application.Exit();
        //             break;
        //         }
        //     }
        //
        //     return null;
        // }
        //
        // private void newTabButton_Click(object sender, EventArgs e)
        // {
        //     DefaultTabCtl tab = new DefaultTabCtl("New Tab", "about:blank") { Dock = DockStyle.Fill };
        //     _tabs.Add(tab);
        //     FATabStripItem tp = new FATabStripItem(tab.TabName, tab);
        //     browserTabStrip.AddTab(tp);
        // }
    }
}