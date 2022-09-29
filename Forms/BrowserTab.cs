using System.Windows.Forms;
using EasyTabs;

namespace ChromiumWindow.Forms
{
    public partial class BrowserTab : Form
    {
        protected TitleBarTabs ParentTabs
        {
            get { return ParentForm as TitleBarTabs; }
        }
        
        public BrowserTab()
        {
            InitializeComponent();
            InitializeAsync();
        }
        
        async void InitializeAsync()
        {
            await webView.EnsureCoreWebView2Async();
        }
    }
}