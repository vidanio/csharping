using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace filing
{
    public partial class MainForm : Form
    {
        private string currentFile = "";
        private bool filesaved = true;

        public MainForm()
        {
            InitializeComponent();
        }

        private void LimpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!filesaved)
            {
                if (MessageBox.Show("Estás seguro de limpiar todo sin antes guardar?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    currentFile = "";
                    TxtBox.Clear();
                    StatusLabel.Text = "(no file)";
                }
            }
            else
            {
                currentFile = "";
                TxtBox.Clear();
                StatusLabel.Text = "(no file)";
            }
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtBox_TextChanged(object sender, EventArgs e)
        {
            filesaved = false;
        }

        private void AbrirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (OpenFileDlg.ShowDialog() == DialogResult.OK)
            {
                currentFile = OpenFileDlg.FileName;
                StatusLabel.Text = currentFile;
                TxtBox.Text = File.ReadAllText(currentFile);
            }
        }

        private void GuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filetosave = "";

            if (currentFile == "")
            {
                if (SaveFileDlg.ShowDialog() == DialogResult.OK)
                {
                    filetosave = SaveFileDlg.FileName;
                    currentFile = filetosave;
                    StatusLabel.Text = filetosave;
                }
            }
            else
            {
                filetosave = currentFile;
            }

            if (filetosave != "")
            {
                File.WriteAllText(filetosave, TxtBox.Text);
            }
        }
    }
}
