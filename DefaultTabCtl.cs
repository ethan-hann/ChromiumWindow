#nullable enable
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChromiumWindow.Interfaces;
using ChromiumWindow.Utility;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

namespace ChromiumWindow
{
    public partial class DefaultTabCtl : UserControl, IBrowserTab
    {
        public EventHandler? UriChanged;
        public EventHandler? TitleChanged;
        public EventHandler? IconUpdated;
        public EventHandler? OnNavigationCompleted;
        
        public string TabName { get; set; }
        public Image? TabImage { get; set; }
        public Uri? TabUri { get; set; }
        public WebView2? WebControl { get; set; }

        public DefaultTabCtl(string tabName, string initialUri)
        {
            TabUri = new Uri(initialUri);
            TabName = tabName;
            InitializeComponent();
            
            WebControl = webView;
        }
        
        private async void DefaultTabCtl_Load(object sender, EventArgs e)
        {
            webView.Source = TabUri;
            
            //Ensure Web View is ready before we do to much with it.
            await InitializeWebView();
        }

        private async Task InitializeWebView()
        {
            Debugger.Log((int)LogLevel.Info, Debugger.DefaultCategory, "InitializeWebView");
            await webView.EnsureCoreWebView2Async(null);
            if (webView?.CoreWebView2 == null)
            {
                Debugger.Log((int)LogLevel.Warning, Debugger.DefaultCategory, "WebView2 Not Ready...");
            }
        }
        
        private void webView_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            if (!e.IsSuccess) return;
            
            Debugger.Log((int)LogLevel.Info, Debugger.DefaultCategory, 
                $"WebView2 Runtime Version: {webView.CoreWebView2.Environment.BrowserVersionString}");
            
            webView.CoreWebView2.FaviconChanged += CoreWebView2OnFaviconChanged;
            webView.CoreWebView2.SourceChanged += CoreWebView2OnSourceChanged;
            webView.CoreWebView2.DocumentTitleChanged += DocumentTitleChanged;
            webView.CoreWebView2.NavigationCompleted += NavigationCompleted;

            webView.CoreWebView2.Navigate(webView.Source.AbsoluteUri);
        }

        private void NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            OnNavigationCompleted?.Invoke(this, new CEventArgs.NavigationCompletedEventArgs(e, this));
        }

        private void DocumentTitleChanged(object sender, object e)
        {
            TabName = webView.CoreWebView2.DocumentTitle;
            TitleChanged?.Invoke(this, new CEventArgs.PageUpdatedEventArgs(this));
        }

        private void CoreWebView2OnSourceChanged(object sender, CoreWebView2SourceChangedEventArgs e)
        {
            if (webView == null) return;
            TabUri = new Uri(webView.Source.AbsoluteUri);
            UriChanged?.Invoke(this, new CEventArgs.PageUpdatedEventArgs(this));
        }
        
        private void CoreWebView2OnFaviconChanged(object sender, object e)
        {
            if (!(webView?.CoreWebView2?.FaviconUri.Length > 0))
            {
                Debugger.Log((int)LogLevel.Error, Debugger.DefaultCategory, 
                    $"Could not find favicon for: {webView?.Source}");
                return;
            }

            try
            {
                using var client = new WebClient();
                var content = client.DownloadData(webView.CoreWebView2.FaviconUri);
                
                using var stream = new MemoryStream(content);
                stream.Seek(0, SeekOrigin.Begin);
                TabImage = new Bitmap(stream);

                if (TabImage == null) return;

                if (!GlobalVars.MainApplication.GetFavicons().Images.ContainsKey(TabName))
                    GlobalVars.MainApplication.GetFavicons().Images.Add(TabName, TabImage);

                IconUpdated?.Invoke(this, new CEventArgs.PageUpdatedEventArgs(this));
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
            
        }
    }
}