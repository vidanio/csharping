/*
Los ficheros que vamos a manejar son todos de un tamaño inferior incluso a 128 MBs (la mínima RAM de una XP antiguo), de hecho los archivos de música 
más largos no superan los 16 MBs, pudiendose albergar en su totalidad en una variable de memoria como un string, string[] o byte[], sin mayor problema.
Por tanto es absurdo en nuestro caso usar FileStreams, o cualquier otro Stream para manejar apertura y cierres de fichero, así como al acceso intermedio
de sus datos, y podemos hacerlo directamente todo desde la clase File con sus métodos totales: ReadAllText y WriteAllText en el caso de archivos de texto,
ReadAllLines y WriteAllLines en caso de acceso por lineas a archivos de texto, y finalmente ReadAllBytes y WriteAllBytes en el caso de ficheros binarios
de datos, tal como ficheros de audio (MP3/WMA). De hecho en el cifrado/descifrado de ficheros mediante un XOR por bytes[], el uso de estos últimos métodos
es el indicado para tal fin, ya que es mucho más rápido en ejecución que un Stream cualquiera usando buffers de lectura intermedios.
Recuerda solamente manejar las excepciones posibles durante la ejecución de lecturas o escrituras de archivos que puedan malograrse
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
                try
                {
                    currentFile = OpenFileDlg.FileName;
                    StatusLabel.Text = currentFile;
                    TxtBox.Text = File.ReadAllText(currentFile);
                }
                catch
                {
                   currentFile = "";
                   StatusLabel.Text = "(no file) no se pudo leer el archivo (error de lectura)";
                }
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
                try
                {
                    File.WriteAllText(filetosave, TxtBox.Text);
                }
                catch
                {
                    StatusLabel.Text = filetosave + " no se pudo grabar (error de grabación)";
                }
            }
        }
    }
}
