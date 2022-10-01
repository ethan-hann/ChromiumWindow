using ChromiumWindow.Interfaces;
using ChromiumWindow.Properties;
using Krypton.Navigator;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChromiumWindow.pages
{
    public class BrowserPage : KryptonPage
    {
        public IBrowserTab BrowserTab { get; private set; }

        public BrowserPage(DefaultTabCtl ctl = null)
        {
            if (ctl == null)
            {
                ctl = new DefaultTabCtl("New Tab", "about:blank");
                ctl.TabImage = Resources.default_icon_16x_16x;
            }
            
            Text = ctl.TabName;
            ImageSmall = (Bitmap)ctl.TabImage;
            ctl.Dock = System.Windows.Forms.DockStyle.Fill;
            ctl.UniqueName = UniqueName;

            Controls.Add(ctl);
            BrowserTab = ctl;
        }
    }
}
