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
        public Form1()
        {
            string key = "12345678";
            InitializeComponent();
            EncryptFile(@"C:\Users\0oIsa\Desktop\Cuñas\Supersol_Andalucia.mp3", @"C:\Users\0oIsa\Desktop\Cuñas\Supersol_Andalucia.xxx", Encoding.UTF8.GetBytes(key), Encoding.UTF8.GetBytes(key));
        }

        private void textBoxDirectory_Click(object sender, EventArgs e)
        {
            if (selectDirectory.ShowDialog() == DialogResult.OK)
            {
                textBoxDirectory.Text = selectDirectory.SelectedPath;
            }
        }

        private void btnEncript_Click(object sender, EventArgs e)
        {
            string [] files = Directory.GetFiles(selectDirectory.SelectedPath);

            foreach (string file in files)
            {
                listadoDirectorios.Items.Add(file);
            }
        }

        static void EncryptFile(string inPath, string outPath, byte[] desKey, byte[] desIV)
        {
            FileStream fin = new FileStream(inPath, FileMode.Open, FileAccess.Read);
            FileStream fout = new FileStream(outPath, FileMode.OpenOrCreate, FileAccess.Write);
            fout.SetLength(0);

            //Create variables to help with read and write.
            byte[] bin = new byte[100]; //This is intermediate storage for the encryption.
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
    }
}
