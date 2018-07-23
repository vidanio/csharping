/*
Sorprendentemente el código q hace la gente por ahí en foros para este tema, es muy complicado cuando .NET ya provee de herramientas como Uri y Path que permiten
libremente usar URL encoded como decoded de una manera muy simple y sencilla. Hay que tener en cuenta que el URLUpload que recibe la petición HTTP POST desde 
el método WebClient.UploadFile (y similares), debe procesar por defecto el input_type file con nombre "file", no he mirado si se puede cambiar el nombre de este
recurso por defecto, indagaremos sobre este tema en posteriores versiones. 
Es importante recoger información fidedigna del server sobre el tamaño recibido y bajado, para asegurar que el proceso fue completado exitosamente, ya que los
errores interceptados por excepciones solamente tienen que ver con problemas en la comunicación y nada más.
Atento al uso de funciones asíncronas UploadFileAsync y DownloadFileAsync con la captura de excepciones en UploadFileCompleted y DownloadFileCompleted
 *  */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace updown
{
    public partial class MainForm : Form
    {
        private string uploadFile = "";
        private string downloadFolder = "";

        public MainForm()
        {
            InitializeComponent();
            // preparado para servers Linux UTF-8
            webCli.Encoding = Encoding.UTF8;
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            // añadimos el header q dice el tipo de contenido que vamos a subir
            webCli.Headers.Add("Content-Type", "binary/octet-stream");
            if ((txtUpFile.Text != "") && (txtUploadURL.Text != ""))
            {
                try
                {
                    btnUploadFile.Enabled = false;
                    // Async al no blquear, si hay un error posterior no pasaría por esta excepción, si no que generaría antes
                    // el evento UploadFileCompleted y es allí donde debe interceptarse con e.Cancel y e.Error
                    webCli.UploadFileAsync(new Uri(txtUploadURL.Text), uploadFile);
                    txtUpLogging.AppendText(string.Format("Uploading File: {0}\r\n", uploadFile));
                }
                catch (Exception exc)
                {
                    btnUploadFile.Enabled = true;
                    lblUpInfo.Text = "Error uploading: " + exc.Message;
                    txtUpLogging.AppendText(lblUpInfo.Text + "\r\n");
                }
            }
        }

        private void webCli_UploadFileCompleted(object sender, System.Net.UploadFileCompletedEventArgs e)
        {
            if (e.Cancelled) // subida cancelada
            {
                lblDownInfo.Text = "File upload cancelled";
                txtDownLogging.AppendText(lblDownInfo.Text + "\r\n");
            }
            else if (e.Error != null) // excepcion diferida atrapada aquí
            {
                lblDownInfo.Text = "Error during upload";
                txtDownLogging.AppendText(lblDownInfo.Text + "\r\n");
            }
            else // todo fue perfecto
            {
                lblDownInfo.Text = "File sucessfully uploaded";
                txtUpLogging.AppendText(string.Format("Server response: {0}\r\n", Encoding.UTF8.GetString(e.Result, 0, e.Result.Length)));
            }

            btnUploadFile.Enabled = true;
        }

        private void webCli_UploadProgressChanged(object sender, System.Net.UploadProgressChangedEventArgs e)
        {
            long percent = e.BytesSent * 100 / e.TotalBytesToSend;
            lblUpInfo.Text = string.Format("{0}   uploaded {1} of {2} bytes. {3} % complete...", 
                (string)e.UserState, e.BytesSent, e.TotalBytesToSend, percent);
            progbarUpload.Value = (int) percent;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            // eliminamos el header que produce el upload, no es necesario para download
            webCli.Headers.Remove("Content-Type");
            if ((txtDownURLFile.Text != "") && (txtDownFolder.Text != ""))
            {
                try
                {
                    string filename;
                    btnDownload.Enabled = false;
                    Uri url = new Uri(txtDownURLFile.Text);
                    try
                    {
                        filename = Path.GetFileName(url.LocalPath);
                    }
                    catch
                    {
                        filename = "default-download.bin";
                    }
                    // Async al no blquear, si hay un error posterior no pasaría por esta excepción, si no que generaría antes
                    // el evento DownloadFileCompleted y es allí donde debe interceptarse con e.Cancel y e.Error
                    webCli.DownloadFileAsync(url, downloadFolder + @"\" + filename);
                    txtDownLogging.AppendText(string.Format("Downloading File: {0}\r\n", filename));
                }catch (Exception exc)
                {
                    btnDownload.Enabled = true;
                    lblDownInfo.Text = "Error downloading: " + exc.Message;
                    txtDownLogging.AppendText(lblDownInfo.Text + "\r\n");
                }
            }
        }

        private void webCli_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled) // download cancelado
            {
                lblDownInfo.Text = "File download cancelled";
                txtDownLogging.AppendText(lblDownInfo.Text + "\r\n");
            }
            else if (e.Error != null) // excepcion diferida atrapada aquí
            {
                lblDownInfo.Text = "Error during download";
                txtDownLogging.AppendText(lblDownInfo.Text + "\r\n");
            }
            else // todo fue perfecto
            {
                lblDownInfo.Text = "File sucessfully downloaded";
                txtDownLogging.AppendText(string.Format("{0} bytes downloaded\r\n", webCli.ResponseHeaders.Get("Content-Length")));
            }

            btnDownload.Enabled = true;
        }

        private void webCli_DownloadProgressChanged(object sender, System.Net.DownloadProgressChangedEventArgs e)
        {
            long percent = e.BytesReceived * 100 / e.TotalBytesToReceive;
            lblDownInfo.Text = string.Format("{0}   downloaded {1} of {2} bytes. {3} % complete...", 
                (string)e.UserState, e.BytesReceived, e.TotalBytesToReceive, percent);
            progbarDownload.Value = (int) percent;
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
