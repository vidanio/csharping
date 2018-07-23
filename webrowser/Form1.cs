using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace webrowser
{
    public partial class MainForm : Form
    {
        private string url = "";

        public MainForm()
        {
            InitializeComponent();
        }

        // Cambia los Enter dentro del Form en TABs (mirar nuevo orden de tabulación y TabStop property
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter) SendKeys.Send("{TAB}");
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            url = txtURL.Text;

            if (url.Contains("http://") || url.Contains("https://"))
                                webContent.Url = new Uri(txtURL.Text);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            txtURL.Text = "https://www.google.es/";
            webContent.Url = new Uri(txtURL.Text);
        }
    }
}
