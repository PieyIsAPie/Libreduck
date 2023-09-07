using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using LazyBrowser.Extensions;


namespace LazyBrowser
{
    public partial class Main : Form
    {
        public bool isIncognito;
        public string[] arguments = Environment.GetCommandLineArgs();
        public Global globals = new Global();
        private List<BrowserControl> browsers;
        private TabControl tabControl;
        private int nextTabIndex = 0;

        private void CrashHandler(object sender, EventArgs e)
        {
            Cef.Shutdown();
        }
        public void Initialize()
        {



            // Unhandled exceptions for our Application Domain
            //AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CrashHandler);
            // Unhandled exceptions for the executing UI thread
            //Application.ThreadException += new ThreadExceptionEventHandler(CrashHandler);
            BrowserControl browser = new BrowserControl();
            this.Controls.Add(browser);
        }
        public Main()
        {
            InitializeComponent();
            // Start the browser after initialize global component
            Initialize();
        }





    }
}
