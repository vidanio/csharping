using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace updown
{
    public partial class MainForm : Form
    {
        private string uploadFile = "", uploadURL = "";
        private string downloadFolder = "", downloadURL = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private void txtUpFile_Click(object sender, EventArgs e)
        {
            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                txtUpFile.Text = openFileDlg.FileName;
                uploadFile = txtUpFile.Text;
            }
        }

        private void txtDownFolder_Click(object sender, EventArgs e)
        {
            if (folderBrwDlg.ShowDialog() == DialogResult.OK)
            {
                txtDownFolder.Text = folderBrwDlg.SelectedPath;
                downloadFolder = txtDownFolder.Text;
            }
        }
    }
}
