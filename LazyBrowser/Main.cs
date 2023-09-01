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
            this.Layout += Main_Layout;
            InitializeTabControl();
        }
        private void InitializeTabControl()
        {
            browsers = new List<BrowserControl>();
            tabControl = new TabControl();
            tabControl.Dock = DockStyle.Fill;
            tabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            tabControl.DrawMode = TabDrawMode.OwnerDrawFixed; // Enable custom-drawn tabs
            tabControl.SizeMode = TabSizeMode.Fixed; // Set the TabSizeMode to Fixed
            tabControl.Alignment = TabAlignment.Top;

            // Attach the event handler for drawing the tabs
            tabControl.DrawItem += TabControl_DrawItem;

            // Create a Panel to hold the "New Tab" button
            //Panel buttonPanel = new Panel();
            //buttonPanel.Dock = DockStyle.Top;
            //buttonPanel.Height = 30;
            //buttonPanel.Controls.Add(newTabButton);

            // Create a SplitContainer to hold both the tab control and the button panel
            //SplitContainer splitContainer = new SplitContainer();
            //splitContainer.Dock = DockStyle.Fill;
            //splitContainer.Orientation = Orientation.Horizontal;
            //splitContainer.Panel1.Controls.Add(tabControl);
            //splitContainer.Panel2.Controls.Add(buttonPanel);

            // Add the SplitContainer to the main form
            //Controls.Add(splitContainer);

            Controls.Add(tabControl);
            tabControl.TabPages.Add(CreateNewTab());
        }


        private void TabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tabControl = (TabControl)sender;
            TabPage tabPage = tabControl.TabPages[e.Index];

            // Measure the size of the tab text
            SizeF textSize = e.Graphics.MeasureString(tabPage.Text, e.Font);

            // Calculate the horizontal position to center the text within the tab
            float x = e.Bounds.Left + (e.Bounds.Width - textSize.Width) / 2;
            float y = e.Bounds.Top + (e.Bounds.Height - textSize.Height) / 2;

            e.Graphics.DrawString(tabPage.Text, e.Font, Brushes.Black, x, y);
            e.DrawFocusRectangle();
        }

        private TabPage CreateNewTab()
        {
            TabPage tabPage = new TabPage($"Tab {nextTabIndex + 1}");
            BrowserControl browser = new BrowserControl();
            tabPage.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
            browsers.Add(browser);
            nextTabIndex++;

            // Update the position of the "New Tab" button whenever a new tab is created
            UpdateNewTabButtonPosition();

            return tabPage;
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = tabControl.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < browsers.Count)
            {
                browsers[selectedIndex].Focus();
            }
        }
        private void Main_Layout(object sender, LayoutEventArgs e)
        {
            UpdateNewTabButtonPosition();
        }
        private void NewTabButton_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Add(CreateNewTab());
        }

        public Main()
        {
            InitializeComponent();
            // Start the browser after initialize global component
            Initialize();
            TabPage lastTab = tabControl.TabPages[tabControl.TabPages.Count - 1];
            lastTab.Controls.Add(newTabButton);
            newTabButton.Location = new Point(lastTab.Width - newTabButton.Width, 0);
        }
        private void UpdateNewTabButtonPosition()
        {
            const int buttonMargin = 5;

            // Calculate the total width of existing tabs
            int totalTabsWidth = 0;
            foreach (TabPage tabPage in tabControl.TabPages)
            {
                totalTabsWidth += tabPage.Width;
            }

            // Calculate the horizontal position for the "New Tab" button
            int buttonX = totalTabsWidth + buttonMargin;
            int buttonY = 0;  // Y-coordinate for the top position

            newTabButton.Location = new Point(buttonX, buttonY);
        }





    }
}
