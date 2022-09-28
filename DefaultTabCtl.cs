using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChromiumWindow.Interfaces;
using Microsoft.Web.WebView2.Core;

namespace ChromiumWindow
{
    public partial class DefaultTabCtl : UserControl, IBrowserTab
    {
        public string TabName { get; set; }
        public Icon TabIcon { get; set; }
        public Uri TabUri { get; set; }
        
        public DefaultTabCtl(string tabName, string initialUri)
        {
            TabUri = new Uri(initialUri);
            TabName = tabName;
            
            InitializeComponent();
        }
        
        private async void DefaultTabCtl_Load(object sender, EventArgs e)
        {
            tabWebView.Source = TabUri;
            //Ensure Web View is ready before we do to much with it.
            await InitializeWebView();
        }

        private async Task InitializeWebView()
        {
            Console.WriteLine("InitializeWebView");
            await tabWebView.EnsureCoreWebView2Async(null);
            Console.WriteLine("WebView2 Runtime Version: " + tabWebView.CoreWebView2.Environment.BrowserVersionString);
            
            if (tabWebView?.CoreWebView2 == null)
            {
                Console.WriteLine("Not Ready...");
            }
            else
            {
                tabWebView.CoreWebView2.FaviconChanged += CoreWebView2OnFaviconChanged;
                tabWebView.CoreWebView2.SourceChanged += CoreWebView2OnSourceChanged;
                UpdateUrlView();
            }
        }

        private void CoreWebView2OnSourceChanged(object sender, CoreWebView2SourceChangedEventArgs e)
        {
            UpdateUrlView();
        }
        
        private void CoreWebView2OnFaviconChanged(object sender, object e)
        {
            UpdateIcon();
        }

        private void UpdateUrlView()
        {
            tabWebView?.CoreWebView2?.Navigate(tabWebView.Source.AbsoluteUri);
            UpdateIcon();
        }

        private void UpdateIcon()
        {
            if (!(tabWebView?.CoreWebView2?.FaviconUri.Length > 0)) return;
            
            using (var client = new WebClient())
            {
                var content = client.DownloadData(tabWebView.CoreWebView2.FaviconUri);
                using (var stream = new MemoryStream(content))
                {
                    TabIcon = new Icon(stream);
                }
            }
        }
    }
}