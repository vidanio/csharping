using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetBrowser;
using DotNetBrowser.WinForms;

namespace WebrowserAdv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BrowserView browserView = new WinFormsBrowserView(BrowserFactory.Create());
            Control browserWindow = (Control)browserView;
            browserWindow.Dock = DockStyle.Fill;
            Controls.Add(browserWindow);
            browserView.Browser.LoadURL("http://www.google.com");
        }
    }
}
