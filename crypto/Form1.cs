using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace crypto
{
    public partial class MainForm : Form
    {
        private string folderIn = "", folderOut = "";
        private bool encoding = true; // .mp3/.wma => .mp3.xxx/ .wma.xxx
        private IEnumerable<string> files; // input files *.*
        private List<string> inputfiles; // real audio files
        private const byte KEYCODE = 0x45;
        private int num_crypted = 0;

        public MainForm()
        {
            InitializeComponent();
            inputfiles = new List<string>();
        }

        private void txtboxFolderOut_Click(object sender, EventArgs e)
        {
            if (fldbrwDlg.ShowDialog() == DialogResult.OK)
            {
                folderOut = fldbrwDlg.SelectedPath;
                txtboxFolderOut.Text = folderOut;
                txtListOut.Clear();
            }
        }

        private void btnCrypt_Click(object sender, EventArgs e)
        {
            if ((files != null) && (folderOut != ""))
            {
                DateTime inicial, final;
                btnCrypt.Enabled = false;
                inicial = DateTime.Now;
                num_crypted = 0;
                if (encoding)
                { // encoding
                    foreach (string file in inputfiles)
                    {
                        try
                        {
                            var bytes = File.ReadAllBytes(file);
                            for (int i=0; i < bytes.Length; i++)
                            {
                                bytes[i] ^= KEYCODE;
                            }
                            File.WriteAllBytes(folderOut + @"\" + Path.GetFileName(file) + ".xxx", bytes);
                            txtListOut.AppendText(string.Format("[OK] {0}\r\n", Path.GetFileName(file)));
                            num_crypted++;
                        }
                        catch
                        {
                            txtListOut.AppendText(string.Format("[ERR] {0}\r\n", Path.GetFileName(file)));
                        }
                    }
                }
                else
                { // decoding
                    foreach (string file in inputfiles)
                    {
                        try
                        {
                            var bytes = File.ReadAllBytes(file);
                            for (int i = 0; i < bytes.Length; i++)
                            {
                                bytes[i] ^= KEYCODE;
                            }
                            File.WriteAllBytes(folderOut + @"\" + Path.GetFileNameWithoutExtension(file), bytes);
                            txtListOut.AppendText(string.Format("[OK] {0}\r\n", Path.GetFileName(file)));
                            num_crypted++;
                        }
                        catch
                        {
                            txtListOut.AppendText(string.Format("[ERR] {0}\r\n", Path.GetFileName(file)));
                        }
                    }
                }
                final = DateTime.Now;
                float secs = (float) (final.Ticks - inicial.Ticks) / 10000000.0f;
                lblMsg.Text = string.Format("{0} files proccessed in {1:F} seconds", num_crypted, secs);
            }
        }

        private void txtboxFolderIn_Click(object sender, EventArgs e)
        {
            if (fldbrwDlg.ShowDialog() == DialogResult.OK)
            {
                txtListIn.Clear();
                txtListOut.Clear();
                txtboxFolderOut.Text = "(chose output folder)";
                folderOut = "";
                btnCrypt.Enabled = true;
                folderIn = fldbrwDlg.SelectedPath;
                txtboxFolderIn.Text = folderIn;
                // limpia la lista de ficheros a procesar
                inputfiles.Clear();
                try
                {
                    files = Directory.EnumerateFiles(txtboxFolderIn.Text, "*.*", SearchOption.AllDirectories);
                    int i = 0;
                    foreach (string file in files)
                    {
                        if (Path.GetExtension(file) == ".mp3" || Path.GetExtension(file) == ".wma" || Path.GetExtension(file) == ".xxx")
                        {
                            inputfiles.Add(file);
                            txtListIn.AppendText(string.Format("[{0}] {1}\r\n", ++i, file));
                            encoding = (Path.GetExtension(file) == ".xxx") ? false: true;
                        }
                    }
                    if (encoding) lblMsg.Text = "encription ON";
                    else lblMsg.Text = "decription ON";
                }
                catch (Exception except)
                {
                    files = null;
                    lblMsg.Text = string.Format("cannot open all directory tree ({0})", except.Message);
                }
            }
        }
    }
}
