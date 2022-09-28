using System;
using System.Drawing;

namespace ChromiumWindow.Interfaces
{
    public interface IBrowserTab
    {
        public string TabName { get; set; }
        public Icon TabIcon { get; set; }
        public Uri TabUri { get; set; }
    }
}