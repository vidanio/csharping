using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

namespace EQF2EDJ
{
    public partial class MainForm : Form
    {
        // offset en EQF desde donde estan los 10 levels del equalizador
        const int EQFoffset = 288;
        // las 10 bandas del ecualizador usadas
        int[] Band = new int[10] { 80, 170, 310, 600, 1000, 3000, 6000, 12000, 14000, 16000 };
        const string WinampEQF = "Winamp EQ library file v1.1";
        string EDJcontent;
        // recogemos los argumentos de linea de comandos
        string[] args = Environment.GetCommandLineArgs();

        public MainForm()
        {
            InitializeComponent();

            lblLog.Text = "";    
            if (args.Length > 1)
            {
                processFile(args[1]); // primer argumento es el fichero a procesar
            }
        }

        // converts EQF hex codes from offset 288+0 to 288+9, to EDJ Gain Level in dB
        public string eqf2edjLevel(byte hex)
        {
            string res = "";
            int num = (int)hex;

            if (num == 31)
            {
                res = "0.000000";
            }
            else
            {
                res = string.Format("{0}", ((32 - num) * 0.375).ToString("F6", CultureInfo.InvariantCulture));
            }

            return res;
        }

        private void txtEQFfile_Click(object sender, EventArgs e)
        {
            EDJcontent = "";

            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDlg.FileName;
                processFile(file);
            }
        }

        private void btnSaveToEDJ_Click(object sender, EventArgs e)
        {
            if (saveEDJDlg.ShowDialog() == DialogResult.OK)
            {
                string file = saveEDJDlg.FileName;
                try
                {
                    // lo grabamos todo de una tacada en un EDJ
                    File.WriteAllText(file, EDJcontent);
                }
                catch
                {
                    MessageBox.Show("Error en la escritur del fichero EDJ", "Error importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void processFile(string file)
        {
            try
            {
                txtEQFfile.Text = file;
                txtEDJcode.Clear();
                // elije el nombre del fichero a guardar como edj con la misma base q en eqf
                saveEDJDlg.FileName = Path.GetFileName(file).Replace(".eqf", ".edj");
                // lee todo el fichero de una tacada
                byte[] EQFcontent = File.ReadAllBytes(file);
                // revisamos que contenga el string identificador de Winamp Equalizer
                if (!Encoding.ASCII.GetString(EQFcontent).Contains(WinampEQF))
                {
                    MessageBox.Show("Fichero no comparible", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // convierte los datos HEX EQF a formato EDJ
                for (int i = 0; i < 10; i++)
                {
                    EDJcontent += string.Format("        <Band FreqInHz=\"{0}\" BandWidth=\"12\" GainIndB=\"{1}\">{2}</Band>\r\n",
                                                            Band[i], eqf2edjLevel(EQFcontent[EQFoffset + i]), i);
                }
                EDJcontent = "<?xml version=\"1.0\" ?>\r\n<Equalizer>\r\n    <Bands>\r\n" + EDJcontent + "    </Bands>\r\n</Equalizer>\r\n";
                // lo escribimos en el TextBox para su inspección
                txtEDJcode.AppendText(EDJcontent);
            }
            catch
            {
                MessageBox.Show("Error en el manejo del fichero EQF", "Error importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEDJcode_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void txtEDJcode_DragDrop(object sender, DragEventArgs e)
        {
            string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (archivos.Length > 0)
            {
                processFile(archivos[0]);
            }
        }
    }
}
