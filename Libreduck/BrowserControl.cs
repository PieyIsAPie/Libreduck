using CefSharp.WinForms;
using CefSharp;
using Libreduck.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libreduck
{
    public partial class BrowserControl : UserControl
    {
        public ChromiumWebBrowser chromeBrowser;
        public bool isIncognito;
        public string[] arguments = Environment.GetCommandLineArgs();
        private ContextMenu exMenu = new ContextMenu();
        public Global globals = new Global();

        private void UpdateStates()
        {
            backButton.Enabled = chromeBrowser.CanGoBack;
            forwardButton.Enabled = chromeBrowser.CanGoForward;
            if (chromeBrowser.IsLoading)
            {
                reloadButton.Image = global::LazyBrowser.Properties.Resources.CloseTab;
            }
            else if (!chromeBrowser.IsLoading)
            {
                reloadButton.Image = global::LazyBrowser.Properties.Resources.Reload;
            }
        }
        private void OnLoadingStateChanged(object sender, LoadingStateChangedEventArgs args)
        {
            this.InvokeOnUiThreadIfRequired(() => UpdateStates());
        }
        public void Initialize()
        {
            // Initialize cef with the provided settings
            if (Cef.IsInitialized != true)
            {
                Cef.Initialize(globals.settings);
            }
            // Create a browser component
            chromeBrowser = new ChromiumWebBrowser("http://duckduckgo.com");
            // Add it to the form and fill it to the form window.
            CefPanel.Controls.Add(chromeBrowser);
            UpdateStates();
            baseWinPanel.Dock = DockStyle.Fill;
            //addressBar.Dock = DockStyle.Fill;
            CefPanel.Dock = DockStyle.Fill;
            UpdateStates();
            chromeBrowser.AddressChanged += OnBrowserAddressChanged;
            chromeBrowser.LoadingStateChanged += OnLoadingStateChanged;
            //chromeBrowser.PopupCreated += (sender, e) =>
            //{
                //var newBrowser = e.WebBrowser;
                //e.Handled = true; // Prevent the popup from opening in a new window
                //chromiumBrowser.GetBrowser().MainFrame.ExecuteJavaScriptAsync("window.open('" + newBrowser.Address + "', '_self')");
            //};
        }
        private void OnBrowserAddressChanged(object sender, AddressChangedEventArgs e)
        {
            this.InvokeOnUiThreadIfRequired(() => addressBar.Text = e.Address);
        }

        public BrowserControl()
        {
            InitializeComponent();
            // Start the browser after initialize global component
            Initialize();
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            UpdateStates();
            if (chromeBrowser.IsLoading)
            {
                chromeBrowser.Stop();
            }
            else if (!chromeBrowser.IsLoading)
            {
                chromeBrowser.Reload();
            }
            UpdateStates();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            UpdateStates();
            chromeBrowser.Forward();
            UpdateStates();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            UpdateStates();
            chromeBrowser.Back();
            UpdateStates();
        }

        private void exButton_Click(object sender, EventArgs e)
        {
            ContextMenuStrip exMenu = new ContextMenuStrip();
            ToolStripMenuItem settings = new ToolStripMenuItem();
            ToolStripMenuItem devtools = new ToolStripMenuItem();
            ToolStripMenuItem about = new ToolStripMenuItem();
            exMenu.SuspendLayout();
            settings.Name = "settings";
            settings.Size = new System.Drawing.Size(152, 22);
            settings.Text = "Settings";
            settings.Click += new System.EventHandler(this.settings_Click);
            devtools.Name = "devtools";
            devtools.Size = new System.Drawing.Size(152, 22);
            devtools.Text = "Show DevTools";
            devtools.Click += new System.EventHandler(this.devtools_Click);
            about.Name = "about";
            about.Size = new System.Drawing.Size(152, 22);
            about.Text = "About";
            about.Click += new System.EventHandler(this.about_Click);
            exMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            settings,
            devtools,
            about});
            exMenu.Name = "exMenu";
            exMenu.Size = new System.Drawing.Size(153, 70);
            exMenu.ResumeLayout(false);
            exButton.ContextMenuStrip = exMenu;
            exMenu.Show(exButton, new System.Drawing.Point(0, exButton.Height));
        }

        private void addressBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                chromeBrowser.LoadUrlAsync(addressBar.Text);
            }
        }
        private void addressBar_Click(object sender, EventArgs e)
        {
            addressBar.SelectAll();
        }
        private void settings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("coming soon");
        }

        private void devtools_Click(object sender, EventArgs e)
        {
            chromeBrowser.ShowDevTools();
        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("coming soon");
        }
    }
}

