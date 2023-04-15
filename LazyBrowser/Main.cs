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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LazyBrowser
{
    public partial class Main : Form
    {
        public ChromiumWebBrowser chromeBrowser;
        public bool isIncognito;
        public string[] arguments = Environment.GetCommandLineArgs();
        private ContextMenu exMenu = new ContextMenu();

        private void CrashHandler(object sender, EventArgs e)
        {
            Cef.Shutdown();
        }
        private void UpdateStates()
        {
            backButton.Enabled = chromeBrowser.CanGoBack;
            forwardButton.Enabled = chromeBrowser.CanGoForward;
            if (chromeBrowser.IsLoading)
            {
                reloadButton.Text = "x";
            } else if (!chromeBrowser.IsLoading)
            {
                reloadButton.Text = "r";
            }
        }
        public void Initialize()
        {
            CefSettings settings = new CefSettings();
            // Initialize cef with the provided settings
            Cef.Initialize(settings);
            // Create a browser component
            chromeBrowser = new ChromiumWebBrowser("http://ourcodeworld.com");
            // Add it to the form and fill it to the form window.
            this.CefPanel.Controls.Add(chromeBrowser);
            UpdateStates();
            baseWinPanel.Dock = DockStyle.Fill;
            //addressBar.Dock = DockStyle.Fill;            CefPanel.Dock = DockStyle.Fill;
            // Unhandled exceptions for our Application Domain
            AppDomain.CurrentDomain.UnhandledException += new System.UnhandledExceptionEventHandler(CrashHandler);
            // Unhandled exceptions for the executing UI thread
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(CrashHandler);
            UpdateStates();
        }
        public Main()
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
            // Define the MenuItem objects to display for the TextBox.
            MenuItem menuItem1 = new MenuItem("&Copy");
            MenuItem menuItem2 = new MenuItem("&Find and Replace");
            // Define the MenuItem object to display for the PictureBox.
            MenuItem menuItem3 = new MenuItem("C&hange Picture");

            // Clear all previously added MenuItems.
            exMenu.MenuItems.Clear();
        }
    }
}
