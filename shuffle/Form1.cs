/*
Este ejemplo no pretendía ser nada más que un ejemplo de como hacer un Shuffle random de una List<string> o colección similar, sin embargo al ponerle el
WMP y un playback de la playlist generada, me he dado cuenta del inconveniente que es usar el delegado PlayStateChange del WMP para cargar nuevos ficheros
mediante su propiedad URL, cosa que no es posible ya que desestabiliza el comportamiento del player, por lo que he tenido que crear una variable de estado
global que es solamente cambiada por el delegado y un Timer que usamos para vigilar dicha variable de estado, y es desde el Timer desde donde manjeamos
la carga de nuevas canciones de la playlist.
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

        private void AxWMP_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 1) // stopped
            {
                stopped = true;
            }
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (stopped)
            {
                stopped = false;
                index++;
                if (index < playlist.Count)
                {
                    axWMP.URL = playlist[index];
                    txtboxInfo.AppendText(string.Format("Play [{0}] {1}\r\n", index, playlist[index]));
                }
                else
                {
                    index = 0;
                    axWMP.close();
                    btnPlay.Enabled = true;
                    timer1.Stop();
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop(); timer1.Dispose();
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            if (files != null)
            {
                var rnd = new Random();
                shuffle = files.OrderBy(item => rnd.Next());
                txtboxFiles.Clear();
                playlist.Clear();
                foreach (string currentFile in shuffle)
                {
                    playlist.Add(currentFile);
                }
                foreach (string currentFile in playlist)
                {
                    txtboxFiles.AppendText(string.Format("{0}\r\n", currentFile));
                }
            }
        }
    }
}
