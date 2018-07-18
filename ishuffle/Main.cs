using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace ishuffle
{
    public partial class MainShuffle : Form
    {   
        private IEnumerable<string> ficheros, mezcla; //Ordenado y Desordenado de los ficheros
        private List<string> playlist; //Playlist de reproducción
        private bool stop = false; //Parada del WMP
        private int index = 0; // cancion actual

        public MainShuffle()
        {
            InitializeComponent();
            playlist = new List<string>();
            axWMPro.PlayStateChange += axWMPro_PlayStateChange;
        }

        private void txtSelectDir_Click(object sender, EventArgs e)
        {
            lblInfoError.Text = "";
            if (abrirDirectorios.ShowDialog() == DialogResult.OK)
            {
                listContentDir.Items.Clear();
                txtSelectDir.Text = abrirDirectorios.SelectedPath;
                //Ficheros MP3 o WMA
                string[] extensions = { ".mp3", ".wma" };
                //Obtenemos los ficheros; de ese directorio y sus sub-directorios
                ficheros = Directory.EnumerateFiles(abrirDirectorios.SelectedPath, "*.*", SearchOption.AllDirectories)
                    .Where(s => extensions.Any(ext => ext == Path.GetExtension(s)));
                //Guardamos los ficheros en nuestro contenedor
                foreach (string fichero in ficheros)
                {
                    listContentDir.Items.Add(fichero);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblInfoError.Text = "";
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            playingInfo.Items.Clear();
            if (playlist.Count > 0)
            {
                btnPlay.Enabled = false;
                axWMPro.URL = playlist[0];

                playingInfo.Items.Add(string.Format("Reproduciendo: {0}\r\n", playlist[index]));
                timerShuffle.Start();
            }
        }

        private void MainShuffle_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerShuffle.Stop();
            timerShuffle.Dispose();
        }

        private void btnMezcla_Click(object sender, EventArgs e)
        {
            if (ficheros != null)
            {
                listContentDir.Items.Clear();
                playlist.Clear();
                var randw = new Random();
                //Desordenamos los ficheros
                mezcla = ficheros.OrderBy(val => randw.Next());
                foreach (string m in mezcla)
                {
                    playlist.Add(m);
                    listContentDir.Items.Add(m);
                }
            }
        }
    }
}
