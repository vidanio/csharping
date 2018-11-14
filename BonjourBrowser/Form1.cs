using System;
using System.Drawing;
using System.Windows.Forms;

namespace BonjourBrowser
{
    public partial class MainForm : Form
    {
        // general variables
        string mDNSURL, mDNSName, mDNSIP;

        public MainForm()
        {
            InitializeComponent();
            webBrowser.ScriptErrorsSuppressed = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void findDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMDNS formMDNS = new FormMDNS();

            if (formMDNS.ShowDialog() == DialogResult.OK)
            {
                mDNSURL = formMDNS.mDNSURL;
                mDNSName = formMDNS.mDNSName;
                mDNSIP = formMDNS.mDNSIP;
                statusLabel.ForeColor = Color.Green;
                statusLabel.Text = String.Format("Connected to Local Device: {0} at IP: {1}", mDNSName, mDNSIP);
                webBrowser.Url = new Uri(mDNSURL);
            }
        }
    }
}
