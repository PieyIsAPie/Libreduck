using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace LazyBrowser.Config
{
    public partial class ConfigWindow : Form
    {
        public ChromiumWebBrowser browser;
        public ICookieManager cookieManager;

        public ConfigWindow(ChromiumWebBrowser browser)
        {
            InitializeComponent();
            this.browser = browser;
            this.cookieManager = this.browser.GetCookieManager();
        }

        private void clearAllCookiesButton_Click(object sender, EventArgs e)
        {
        }

        private void clearCookiesForSiteButton_Click(object sender, EventArgs e)
        {
            cookieManager.DeleteCookies(siteToClearCookies.Text);
        }
    }
}
