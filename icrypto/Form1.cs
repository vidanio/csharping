using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace icrypto
{
    public partial class Form1 : Form
    {
        const string key = "12345678";

        public Form1()
        {
            InitializeComponent();
        }

        private void txtEntradaEnc_Click(object sender, EventArgs e)
        {
            if (DirectorioEntrada.ShowDialog() == DialogResult.OK)
            {
                listadoDirectorios.Items.Clear();
                status_enc.Text = "";
                txtEntradaEnc.Text = DirectorioEntrada.SelectedPath;
            }
        }

        private void btnEncript_Click(object sender, EventArgs e)
        {
            listadoDirectorios.Items.Clear();
            //Seleccion de directorio no puede estar vacío
            if ((txtEntradaEnc.Text != "") && (txtSalidaEnc.Text != "")){
                string[] files = Directory.GetFiles(DirectorioEntrada.SelectedPath);
                foreach (string file in files)
                {
                    //Solo ficheros MP3 o WMA
                    if ((file.Contains(".mp3") || (file.Contains(".wma"))))
                    {
                        //Mostramos solo el nombre de fichero (sin extension)
                        string f_name = Path.GetFileNameWithoutExtension(file);
                        //Añadimos la nueva extension (.xxx)
                        string f_name_encript = f_name + ".xxx";
                        //Se realiza la encriptación
                        string fileToEncript = txtSalidaEnc.Text + "\\" + f_name_encript;
                        EncryptFile(file, fileToEncript, Encoding.UTF8.GetBytes(key), Encoding.UTF8.GetBytes(key));
                        //Mostramos los directorios encriptados
                        status_enc.ForeColor = Color.Green;
                        status_enc.Text = "Los ficheros han sido encriptados";
                        listadoDirectorios.Items.Add(file);
                    }
                }
            }
            else
            {
                emptySelects.SetError(txtSalidaEnc, "Ruta vacía");
            }
        }
        static void EncryptFile(string inPath, string outPath, byte[] desKey, byte[] desIV)
        {
            FileStream fin = new FileStream(inPath, FileMode.Open, FileAccess.Read);
            FileStream fout = new FileStream(outPath, FileMode.OpenOrCreate, FileAccess.Write);
            fout.SetLength(0);

            //Create variables to help with read and write.
            byte[] bin = new byte[100];  //This is intermediate storage for the encryption.
            long rdlen = 0;              //This is the total number of bytes written.
            long totlen = fin.Length;    //This is the total length of the input file.
            int len;                     //This is the number of bytes to be written at a time.

            DES des = new DESCryptoServiceProvider();
            CryptoStream encStream = new CryptoStream(fout, des.CreateEncryptor(desKey, desIV), CryptoStreamMode.Write);

            //Read from the input file, then encrypt and write to the output file.
            while (rdlen < totlen)
            {
                len = fin.Read(bin, 0, 100);
                encStream.Write(bin, 0, len);
                rdlen = rdlen + len;
            }
            encStream.Close();
            fout.Close();
            fin.Close();
        }

        private void txtSalidaEnc_Click(object sender, EventArgs e)
        {
            if (DirectorioSalida.ShowDialog() == DialogResult.OK)
            {
                listadoDirectorios.Items.Clear();
                status_enc.Text = "";
                txtSalidaEnc.Text = DirectorioSalida.SelectedPath;
            }
        }
    }
}
