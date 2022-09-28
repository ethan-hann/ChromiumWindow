using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChromiumWindow.Interfaces;
using ChromiumWindow.Properties;
using Microsoft.Web.WebView2.Core;

namespace ChromiumWindow
{
    public partial class MainForm : Form
    {
        private readonly string[] _arguments;
        private ObservableCollection<IBrowserTab> _tabs = new();
        
        public MainForm(string[] args)
        {
            InitializeComponent();
            _arguments = args;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Parse arguments
            ParseArguments();

            DefaultTabCtl initialTab = new DefaultTabCtl("DuckDuckGo", "https://duckduckgo.com")
            {
                Dock = DockStyle.Fill
            };
            
            _tabs.Add(initialTab);
            //Add all browser tabs in _tabs to the TabControl
            foreach (IBrowserTab tab in _tabs)
            {
                TabPage tp = new TabPage(tab.TabName);
                tp.Tag = tab; //add the IBrowserTab as an object tag for the TabPage control.
                tp.Controls.Add((DefaultTabCtl)tab); //add the DefaultTabCtl control as a child of this tab page.
                browserTabs.TabPages.Add(tp); //Finally, add the TabPage to the browser tabs.
            }
            //
            // tab1.Controls.Add(initialTab);
            // browserTabs.TabPages[0].Controls.Add(initialTab);
            // //browserTabs.Invalidate();
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
    }
}