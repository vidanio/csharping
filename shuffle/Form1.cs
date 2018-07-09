using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace shuffle
{
    public partial class MainForm : Form
    {
        // para guardar la coleccion de ficheros encontrados en el directorio
        private IEnumerable<string> files, shuffle; // files esta en el orden real del directorio, shuffle es la desordenacion

        public MainForm()
        {
            InitializeComponent();
        }

        private void txtboxFolder_MouseClick(object sender, MouseEventArgs e)
        {
            lblExcept.Text = "";
            if (folderOpen.ShowDialog() == DialogResult.OK)
            {
                txtboxFolder.Text = folderOpen.SelectedPath;
                try
                {
                    files = Directory.EnumerateFiles(txtboxFolder.Text, "*.mp3", SearchOption.AllDirectories);
                    txtboxFiles.Clear();
                    foreach (string currentFile in files)
                    {
                        txtboxFiles.AppendText(string.Format("{0}\r\n", currentFile));
                    }
                }
                catch (Exception except)
                {
                    lblExcept.Text = except.Message;
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblExcept.Text = "";
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            shuffle = files.OrderBy(item => rnd.Next());
            txtboxFiles.Clear();
            foreach (string currentFile in shuffle)
            {
                txtboxFiles.AppendText(string.Format("{0}\r\n", currentFile));
            }
        }
    }
}
