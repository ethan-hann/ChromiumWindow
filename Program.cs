using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTabs;
using Microsoft.Web.WebView2.Core;

namespace ChromiumWindow
{
    static class Program
    {
        public static CoreWebView2Environment WebView2Environment;
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm container = new MainForm(args);

            container.AddNewTab();
            container.SelectedTabIndex = 0;

            TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();
            applicationContext.Start(container);

            Application.Run(applicationContext);
        }
    }
}