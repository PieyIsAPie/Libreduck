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

namespace LazyBrowser
{
    public partial class Form1 : Form
    {
        public ChromiumWebBrowser chromeBrowser;
        public bool isIncognito;
        public string[] arguments = Environment.GetCommandLineArgs();

        public void Initialize()
        {
            CefSettings settings = new CefSettings();
            // Initialize cef with the provided settings
            Cef.Initialize(settings);
            // Create a browser component
            chromeBrowser = new ChromiumWebBrowser("http://ourcodeworld.com");
            // Add it to the form and fill it to the form window.
            this.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;
        }
        public Form1()
        {
            InitializeComponent();
            // Start the browser after initialize global component
            Initialize();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }
    }
}
