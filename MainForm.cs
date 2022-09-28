using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChromiumWindow.Properties;
using Microsoft.Web.WebView2.Core;

namespace ChromiumWindow
{
    public partial class MainForm : Form
    {
        private readonly string[] _arguments;
        public MainForm(string[] args)
        {
            InitializeComponent();
            _arguments = args;
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            //Parse arguments
            ParseArguments();
            
            //Ensure Web View is ready before we do to much with it.
            webView.CoreWebView2InitializationCompleted += WebViewOnCoreWebView2InitializationCompleted;
            await InitializeWebView();
        }

        private void WebViewOnCoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            if (e.IsSuccess)
                Console.WriteLine("WebView_CoreWebView2 Initialization Complete");
        }

        private async Task InitializeWebView()
        {
            Console.WriteLine("InitializeWebView");
            await webView.EnsureCoreWebView2Async(null);
            Console.WriteLine("WebView2 Runtime Version: " + webView.CoreWebView2.Environment.BrowserVersionString);
            
            if (webView?.CoreWebView2 == null)
            {
                Console.WriteLine("Not Ready...");
            }
            else
            {
                webView.CoreWebView2.FaviconChanged += CoreWebView2OnFaviconChanged;
                webView.CoreWebView2.SourceChanged += CoreWebView2OnSourceChanged;
                UpdateUrlView();
            }
        }

        private void CoreWebView2OnSourceChanged(object sender, CoreWebView2SourceChangedEventArgs e)
        {
            UpdateUrlView();
        }

        private void ParseArguments()
        {
            var argumentsParsed = ParseArguments(_arguments);
            if (argumentsParsed == null)
            {
                Text = Resources.DefaultTitle;
                webView.Source = new Uri("https://duckduckgo.com");
            }

            if (argumentsParsed?.Item1 != null)
                Text = argumentsParsed.Value.Item1;
            if (argumentsParsed?.Item2 != null)
                webView.Source = new Uri(argumentsParsed.Value.Item2);
        }
        
        private void CoreWebView2OnFaviconChanged(object sender, object e)
        {
            UpdateIcon();
        }

        private void UpdateUrlView()
        {
            webView?.CoreWebView2?.Navigate(webView.Source.AbsoluteUri);
            UpdateIcon();
        }

        private void UpdateIcon()
        {
            if (!(webView?.CoreWebView2?.FaviconUri.Length > 0)) return;
            
            using (var client = new WebClient())
            {
                var content = client.DownloadData(webView.CoreWebView2.FaviconUri);
                using (var stream = new MemoryStream(content))
                {
                    Icon = new Icon(stream);
                }
            }
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