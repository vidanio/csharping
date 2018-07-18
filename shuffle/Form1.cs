/*
Este ejemplo no pretendía ser nada más que un ejemplo de como hacer un Shuffle random de una List<string> o colección similar, sin embargo al ponerle el
WMP y un playback de la playlist generada, me he dado cuenta del inconveniente que es usar el delegado PlayStateChange del WMP para cargar nuevos ficheros
mediante su propiedad URL, cosa que no es posible ya que desestabiliza el comportamiento del player, por lo que he tenido que crear una variable de estado
global que es solamente cambiada por el delegado y un Timer que usamos para vigilar dicha variable de estado, y es desde el Timer desde donde manjeamos
la carga de nuevas canciones de la playlist.
Este ejemplo lleva una extensión de código en un fichero de Clase partial en Extend1.cs. Sirva como ejemplo de como extender una clase en más de un fichero
o añadir nuevas clases a un mismo proyecto con el mismo namespace
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace shuffle
{
    public partial class MainForm : Form
    {
        // para guardar la coleccion de ficheros encontrados en el directorio
        private IEnumerable<string> files, shuffle; // files esta en el orden real del directorio, shuffle es la desordenacion
        private List<string> playlist;
        private int index = 0; // indice actual de la canción de la playlist que toca
        private bool stopped = false; // estado del WMP como Stopped

        public MainForm()
        {
            InitializeComponent();
            playlist = new List<string>();
            axWMP.PlayStateChange += AxWMP_PlayStateChange;
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
                    files = null;
                    lblExcept.Text = except.Message;
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblExcept.Text = "";
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (playlist.Count > 0)
            {
                btnPlay.Enabled = false;
                axWMP.URL = playlist[0];
                txtboxInfo.AppendText(string.Format("Play [{0}] {1}\r\n", index, playlist[index]));
                timer1.Start();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop(); timer1.Dispose();
        }

        private void axWMP_ErrorEvent(object sender, EventArgs e)
        {
            stopped = true;
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            if (files != null)
            {
                var rnd = new Random();
                shuffle = files.OrderBy(item => rnd.Next());
                txtboxFiles.Clear();
                playlist.Clear();
                int i = 0;
                foreach (string currentFile in shuffle)
                {
                    playlist.Add(currentFile);
                    txtboxFiles.AppendText(string.Format("[{0}] {1}\r\n", i++, currentFile));
                }
            }
        }
    }
}
