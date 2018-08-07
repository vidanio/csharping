using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Net;

namespace iupdown
{
    public partial class Form1 : Form
    {
        private string ficheroSubida = "";
        private string directorioBajada = "";
        private string ficheroBajado = "";

        public Form1()
        {
            InitializeComponent();
            wClient.Encoding = Encoding.UTF8; //UTF8
        }

        private void txtFileUpload_Click(object sender, EventArgs e)
        {
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFileUpload.Text = fileDialog.FileName;
                ficheroSubida = txtFileUpload.Text;
            }
        }

        private void txtDirBajada_Click(object sender, EventArgs e)
        {
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                txtDirBajada.Text = folderDialog.SelectedPath;
                directorioBajada = txtDirBajada.Text;
            }
        }

        private void btnSubida_Click(object sender, EventArgs e)
        {
            if ((txtFileUpload.Text != "") && (txtUploadURL.Text != ""))
            {
                listSubidos.Items.Clear();
                try
                {
                    btnSubida.Enabled = false;
                    wClient.UploadFileAsync(new Uri(txtUploadURL.Text), txtFileUpload.Text);
                }
                catch (Exception exc)
                {
                    btnSubida.Enabled = true;
                    listSubidos.Items.Add(exc.Message);
                }
            }
        }

        private void wClient_UploadFileCompleted(object sender, UploadFileCompletedEventArgs e)
        {
            listSubidos.Items.Clear();

            if (e.Cancelled)
            {
                listSubidos.Items.Add("Subida Cancelada");
            }
            else if (e.Error != null)
            {
                listSubidos.Items.Add("Error de Subida");
            }
            else
            {
                string filename = Path.GetFileName(ficheroSubida);
                listSubidos.Items.Add(string.Format("{0}: {1}", filename, Encoding.UTF8.GetString(e.Result, 0, e.Result.Length)));
            }

            btnSubida.Enabled = true;
        }
        //Progreso de la Subida del Fichero
        private void wClient_UploadProgressChanged(object sender, UploadProgressChangedEventArgs e)
        {
            long percent = e.BytesSent * 100 / e.TotalBytesToSend;
            barSubida.Value = (int)percent;
        }

        private void btnBajada_Click(object sender, EventArgs e)
        {
            if ((txtBajada.Text != "") && (txtDirBajada.Text != ""))
            {
                listBajados.Items.Clear();
                try
                {
                    btnBajada.Enabled = false;
                    Uri url = new Uri(txtBajada.Text);
                    ficheroBajado = Path.GetFileName(url.LocalPath);
                    wClient.DownloadFileAsync(url, directorioBajada + @"\" + ficheroBajado);
                }
                catch (Exception exc)
                {
                    btnBajada.Enabled = true;
                    listBajados.Items.Add(exc.Message);
                }
            }
        }

        private void wClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            listBajados.Items.Clear();

            if (e.Cancelled)
            {
                listBajados.Items.Add("Descarga Cancelada");
            }
            else if (e.Error != null)
            {
                listBajados.Items.Add("Error de Descarga");
            }
            else
            {
                listBajados.Items.Add(string.Format("{0} ({1} bytes)", ficheroBajado, wClient.ResponseHeaders.Get("Content-Length")));
            }
            btnBajada.Enabled = true;
        }
        //Progreso de Bajada de Fichero
        private void wClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            long percent = e.BytesReceived * 100 / e.TotalBytesToReceive;
            barBajada.Value = (int)percent;
        }
    }
}
