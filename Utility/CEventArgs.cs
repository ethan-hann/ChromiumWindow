using System;
using System.Drawing;
using ChromiumWindow.Interfaces;
using Microsoft.Web.WebView2.Core;

namespace ChromiumWindow.Utility
{
    public class CEventArgs
    {
        public class PageUpdatedEventArgs : EventArgs
        {
            public IBrowserTab Tab { get; private set; }
            // public Icon NewIcon { get; private set; }
            // public string TabName { get; private set; }

            public PageUpdatedEventArgs(IBrowserTab tab)
            {
                Tab = tab;
            }
        }

        public class NavigationCompletedEventArgs : EventArgs
        {
            public CoreWebView2NavigationCompletedEventArgs CoreWebView2NavigationCompletedEventArgs { get; private set; }
            public IBrowserTab Tab { get; private set; }

            public NavigationCompletedEventArgs(CoreWebView2NavigationCompletedEventArgs coreWebView2NavigationCompletedEventArgs, 
                IBrowserTab tab)
            {
                CoreWebView2NavigationCompletedEventArgs = coreWebView2NavigationCompletedEventArgs;
                Tab = tab;
            }
        }
    }
}