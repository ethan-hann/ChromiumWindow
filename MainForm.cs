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
using Microsoft.Web.WebView2.Core;

namespace ChromiumWindow
{
    public partial class MainForm : Form
    {
        private readonly string[] _arguments;
        private ObservableCollection<IBrowserTab> _tabs = new();
        private Dictionary<string, Icon> TabIcons = new();
        private static ImageList _faviconList = new();
        
        public MainForm(string[] args)
        {
            InitializeComponent();
            _arguments = args;
            
            browserTabs.ImageList = _faviconList; //assign the image list to the tab control
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Parse arguments
            ParseArguments();
            CreateTabs();
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
                TabPage tp = new TabPage(tab.TabName);
                tp.Tag = tab; //add the IBrowserTab as an object tag for the TabPage control.
                tp.Controls.Add((DefaultTabCtl)tab); //add the DefaultTabCtl control as a child of this tab page.
                tp.ImageKey = tab.TabName;
                ((DefaultTabCtl)tab).IconUpdated += UpdateTabIcon; //add eventhandler for tab icon
                browserTabs.TabPages.Add(tp); //Finally, add the TabPage to the browser tabs.
                browserTabs.Update();
            }
        }
        
        private void UpdateTabIcon(object sender, EventArgs args)
        {
            if (args is CEventArgs.IconUpdatedEventArgs e)
            {
                browserTabs.SelectedTab.Text = e.TabName;
                browserTabs.SelectedTab.ImageKey = e.TabName;
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
        
        public static ImageList getFaviconList()
        {
            return _faviconList;
        }
    }
}