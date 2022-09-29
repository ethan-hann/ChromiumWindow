using System;
using System.Drawing;
using Microsoft.Web.WebView2.WinForms;

namespace ChromiumWindow.Interfaces
{
    public interface IBrowserTab
    {
        public string TabName { get; set; }
        
        #nullable enable
        public Image? TabImage { get; set; }
        public Uri? TabUri { get; set; }
        
        public WebView2? WebControl { get; set; }
        #nullable disable
    }
}