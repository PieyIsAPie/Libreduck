using CefSharp;
using CefSharp.WinForms;

namespace Libreduck
{
    public partial class Popup : Form
    {
        public Global globals = new Global();
        public ChromiumWebBrowser chromeBrowser;
        public Popup(string url)
        {
            InitializeComponent();
            if (Cef.IsInitialized != true)
            {
                Cef.Initialize(globals.settings);
            }
            chromeBrowser = new ChromiumWebBrowser("http://duckduckgo.com");
            // Add it to the form and fill it to the form window.
            CefPanel.Controls.Add(chromeBrowser);
            baseWinPanel.Dock = DockStyle.Fill;
            CefPanel.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
