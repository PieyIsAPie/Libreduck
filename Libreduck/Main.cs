using System.Runtime.InteropServices;
using CefSharp;


namespace Libreduck
{
    public partial class Main : Form
    {
        public bool isIncognito;
        public string[] arguments = Environment.GetCommandLineArgs();
        public Global globals = new Global();
        private List<BrowserControl> browsers;
        private TabControl tabControl;

        private void CrashHandler(object sender, EventArgs e)
        {
            if (Cef.IsInitialized)
            {
                foreach (var browser in browsers)
                {
                    browser.chromeBrowser.CloseDevTools();
                    browser.Dispose();
                }
                Cef.Shutdown();
            }
        }
        public void Initialize()
        {



            // Unhandled exceptions for our Application Domain
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CrashHandler);
            // Unhandled exceptions for the executing UI thread
            Application.ThreadException += new ThreadExceptionEventHandler(CrashHandler);
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
            TabPage tabPage = new TabPage($"+");

            // Attach the event handler for drawing the tabs
            tabControl.DrawItem += TabControl_DrawItem;
            tabControl.MouseDown += TabControl_MouseDown;
            tabControl.Selecting += TabControl_Selecting;
            //tabControl.HandleCreated += tabControl1_HandleCreated;

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
            tabControl.TabPages.Add(tabPage);
        }

        private void TabControl_MouseDown(object sender, MouseEventArgs e)
        {
            //Looping through the controls.
            for (int i = 0; i < this.tabControl.TabPages.Count - 1; i++)
            {
                Rectangle r = tabControl.GetTabRect(i);
                //Getting the position of the "x" mark.
                Rectangle closeButton = new Rectangle(r.Right - 15, r.Top + 4, 9, 7);
                if (closeButton.Contains(e.Location))
                {
                        this.tabControl.TabPages.RemoveAt(i);
                        break;
                }
            }
            var lastIndex = this.tabControl.TabCount - 1;
            if (this.tabControl.GetTabRect(lastIndex).Contains(e.Location))
            {
                this.tabControl.TabPages.Insert(lastIndex, CreateNewTab());
                this.tabControl.SelectedIndex = lastIndex;
            }
        }

        private void TabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == this.tabControl.TabCount - 1)
                e.Cancel = true;
        }

        private bool isLastTab(TabControl control, int index)
        {
            return (control.TabPages.Count - 1) == index;
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
            
            if (!isLastTab(tabControl, e.Index))
            {
                Rectangle r = tabControl.GetTabRect(e.Index);
                //Getting the position of the "x" mark.
                Rectangle closeButton = new Rectangle(r.Right - 15, r.Top + 4, 9, 7);
                e.Graphics.DrawString("x", e.Font, Brushes.Black, closeButton);
            }
            //e.Graphics.DrawString(this.tabControl.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 12, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
        }

        private TabPage CreateNewTab()
        {
            TabPage tabPage = new TabPage("New Tab");
            BrowserControl browser = new BrowserControl();
            tabPage.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
            browsers.Add(browser);
            

            return tabPage;
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = tabControl.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < browsers.Count)
            {
                browsers[selectedIndex].Focus();
            }
            //if (tabControl.SelectedTab.Controls.ContainsKey("browser"))
            //{
            //    BrowserControl selectedBrowser = (BrowserControl)tabControl.SelectedTab.Controls["browser"];
            //    selectedBrowser.Focus();
            //    this.Text = selectedBrowser.chromeBrowser.Text + " - LazyBrowser";
            //}
        }

        public Main()
        {
            InitializeComponent();
            // Start the browser after initialize global component
            Initialize();
        }

        //[DllImport("user32.dll")]
        //private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
        //private const int TCM_SETMINTABWIDTH = 0x1300 + 49;
        //private void tabControl1_HandleCreated(object sender, EventArgs e)
        //{
        //    SendMessage(this.tabControl.Handle, TCM_SETMINTABWIDTH, IntPtr.Zero, (IntPtr)16);
        //}

    }
}
