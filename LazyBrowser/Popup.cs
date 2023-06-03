using CefSharp;
using LazyBrowser.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LazyBrowser
{
    public partial class Popup : Form
    {
        public Popup(string url)
        {
            InitializeComponent();
            Cef.Initialize(settings);
        }
    }
}
