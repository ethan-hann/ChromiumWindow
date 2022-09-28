using System;
using System.Drawing;

namespace ChromiumWindow.Utility
{
    public class CEventArgs
    {
        public class IconUpdatedEventArgs : EventArgs
        {
            public Icon NewIcon { get; private set; }
            public string TabName { get; private set; }

            public IconUpdatedEventArgs(Icon icon, string tabName)
            {
                NewIcon = icon;
                TabName = tabName;
            }
        }
    }
}