/*
    EJEMPLO DE USO DE TODAS LAS FUNCIONALIDADES DEL CONTROL WINDOWS MEDIA PLAYER

Cosas del axWMP control: (https://docs.microsoft.com/es-es/windows/desktop/WMP/object-model-reference-for-scripting) 
    axWMPMain.URL                            -> string con la URL del fichero a reproducir de la ruta OpenFileDialog.FileName
    axWMPMain.Ctlcontrols.play()             -> play
    axWMPMain.Ctlcontrols.stop()             -> stop
    axWMPMain.settings.volume                -> int de 0 a 100
    axWMPMain.settings.mute                  -> bool
    axWMPMain.currentMedia.duration          -> devuelve double con la duración en segundos del media actual
    axWMPMain.Ctlcontrols.currentPosition    -> devuelve double con la posición actual de reproducción del media actual
    axWMPMain.currentMedia.name              -> devuelve string con el nombre del media actual
    axWMPMain.Ctlcontrols.currentItem.name   -> devuelve string con el nombre del media actual
    axWMPMain.playState                      -> enum  WMPLib.WMPPlayState.wmppsPlaying/wmppsReady/wmppsStopped/wmppsUndefined/wmppsTransitioning/wmppsMediaEnded/wmppsPaused
    (int) axWMPMain.playState                -> int 3/10/8 (https://docs.microsoft.com/es-es/windows/desktop/WMP/player-playstate)
    axWMPMain.PlayStateChange                -> evento axWMPMain_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace wmplayer
{
    public partial class FormMain : Form
    {
        // variables generales y de estado importantes
        private string ruta = "";
        private bool mainplay = true, mainpause = true; // show play or pause on buttons
        private int total, ellapsed; // duracion total y reproducida del medio actual
        private bool gotMetadata = false;
        private MetaData metaData;

        public FormMain()
        {
            InitializeComponent();

            // instanciamos la clase contenedora de MetaData
            metaData = new MetaData();
            // ajustamos default settings del WMP player para un comportamiento ideal
            axWMPMain.settings.enableErrorDialogs = false;
            axWMPMain.settings.autoStart = true;
        }

        private void btnOpenMainSong_Click(object sender, EventArgs e)
        {
            if (openFileMain.ShowDialog() == DialogResult.OK)
            {
                ruta = openFileMain.FileName;
                lblMainSong.Text = ruta;
                // para el player antes de cargar una ruta nueva para evitar quedarse en un estado indefinido
                // esto solo es necesario si el autoStart es false      
                if (!axWMPMain.settings.autoStart) axWMPMain.Ctlcontrols.stop();
                axWMPMain.URL = ruta; // abre el fichero y comienza a reproducirlo si settings.autoStart = true (sin play())
            }
        }

        private void btnPlayMainSong_Click(object sender, EventArgs e)
        {
            // usamos el mismo botón para 2 funciones PLAY y STOP
            if (mainplay)
            {
                axWMPMain.Ctlcontrols.play();
            }
            else
            {
                axWMPMain.Ctlcontrols.stop();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            tbarMainVol.Value = axWMPMain.settings.volume;
            axWMPMain.PlayStateChange += axWMPMain_PlayStateChange; // damos de alta el evento PlayStateChange con su handler
            txtboxStatusMain.AppendText(String.Format("[0] {0}\r\n", axWMPMain.playState.ToString()));
            openFileMain.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        }

        private void tbarMainVol_Scroll(object sender, EventArgs e)
        {
            axWMPMain.settings.volume = tbarMainVol.Value;
        }

        // intenta recoger los MetaData de la canción que esta tocando ahora mismo, si lo consigue devuelve (true)
        private bool GetCurrentMetadata(WMPLib.IWMPMedia3 cm, ref MetaData metaData)
        {
            // Recogemos los Metadata de la pista recien abierta
            int attCount = cm.attributeCount;
            if (attCount > 90)
            {
                var parts = cm.getItemInfo("AlbumIDAlbumArtist").Replace("*;*", "=").Split('=');
                int bps = Convert.ToInt32(cm.getItemInfo("Bitrate"));
                int avg = Convert.ToInt32(cm.getItemInfo("AverageLevel"));
                metaData.SetMetaData(parts[0], cm.getItemInfo("Author"), cm.getItemInfo("WM/TrackNumber"), cm.getItemInfo("Title"), cm.getItemInfo("WM/Genre"), bps/1000, avg);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void axWMPMain_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            txtboxStatusMain.AppendText(String.Format("[{0}] {1}\r\n", e.newState, axWMPMain.playState.ToString()));
            switch (e.newState)
            {
                case 3: // playing
                    btnPlayMainSong.Text = "Stop";
                    // cada canción nueva que seuna reiniciamos la busqueda de metadatos
                    gotMetadata = false;
                    mainplay = false;
                    total = Convert.ToInt32(axWMPMain.currentMedia.duration);
                    lblMediaName.Text = "Playing: \"" + axWMPMain.currentMedia.name + "\" Duration: " + total.ToString() + " sec";
                    timer1.Start();
                    mainpause = true;
                    btnPause.Text = "Pause";
                    btnPause.Visible = true;
                    break;
                case 1: // stopped
                    btnPlayMainSong.Text = "Play";
                    mainplay = true;
                    timer1.Stop();
                    lblMediaName.Text = "(nothing)";
                    lblEllapsed.Text = "0 sec";
                    progbarMainSong.Value = 0;
                    percent.Text = progbarMainSong.Value.ToString() + "%";
                    btnPause.Visible = false;
                    break;
                case 2: // paused
                    mainpause = false;
                    btnPause.Text = "Play";
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxStatusMain.Clear();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            timer1.Dispose();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            // usamos el mismo botón para PAUSE y PLAY
            if (mainpause)
                axWMPMain.Ctlcontrols.pause();
            else
                axWMPMain.Ctlcontrols.play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ellapsed = Convert.ToInt32(axWMPMain.Ctlcontrols.currentPosition);
            lblEllapsed.Text = ellapsed.ToString() + " sec";
            progbarMainSong.Value = Convert.ToInt32(ellapsed * 100 / total);
            percent.Text = progbarMainSong.Value.ToString() + "%";
            // código que intenta recoger los MetaData de la canción que suena ahora
            if (!gotMetadata)
            {
                WMPLib.IWMPMedia3 cm = (WMPLib.IWMPMedia3)axWMPMain.currentMedia;
                gotMetadata = GetCurrentMetadata(cm, ref metaData);
                // si consigue recoger los MetaData los muestra en el txtbox (primeros segundos de la canción)
                if (gotMetadata)
                {
                    txtboxStatusMain.AppendText("=============================\r\n");
                    txtboxStatusMain.AppendText(String.Format("Album: {0}\r\n", metaData.Album));
                    txtboxStatusMain.AppendText(String.Format("Author: {0}\r\n", metaData.Author));
                    txtboxStatusMain.AppendText(String.Format("Track: {0}\r\n", metaData.Track));
                    txtboxStatusMain.AppendText(String.Format("Title: {0}\r\n", metaData.Title));
                    txtboxStatusMain.AppendText(String.Format("Genre: {0}\r\n", metaData.Genre));
                    txtboxStatusMain.AppendText(String.Format("BitRate: {0} kbps\r\n", metaData.BitRate));
                    txtboxStatusMain.AppendText(String.Format("AvgLevel: {0}\r\n", metaData.AvgLevel));
                    txtboxStatusMain.AppendText("=============================\r\n");
                }
            }
        }
    }
}
