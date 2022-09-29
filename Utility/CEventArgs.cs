using System;
using System.Drawing;
using ChromiumWindow.Interfaces;

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
    }
}