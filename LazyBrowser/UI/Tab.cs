using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace LazyBrowser.Extensions
{
    internal class Tab
    {
        public ChromiumWebBrowser chromeBrowser;

        public Tab(TextBox addressBar, Panel CefPanel)
        {
            CefSettings settings = new CefSettings();
            // Initialize cef with the provided settings
            Cef.Initialize(settings);
            // Create a browser component
            chromeBrowser = new ChromiumWebBrowser("http://duckduckgo.com");
            CefPanel.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;
            addressBar.Text = chromeBrowser.Address;

        }
        public void CloseTab()
        {
            chromeBrowser.Stop();
            chromeBrowser.Dispose();
        }
    }
}
