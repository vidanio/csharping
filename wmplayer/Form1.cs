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

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnOpenMainSong_Click(object sender, EventArgs e)
        {
            if (openFileMain.ShowDialog() == DialogResult.OK)
            {
                ruta = openFileMain.FileName;
                lblMainSong.Text = ruta;
                axWMPMain.URL = ruta; // abre el fichero y comienza a reproducirlo solo
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
        }

        private void tbarMainVol_Scroll(object sender, EventArgs e)
        {
            axWMPMain.settings.volume = tbarMainVol.Value;
        }

        private void axWMPMain_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            txtboxStatusMain.AppendText(String.Format("[{0}] {1}\r\n", e.newState, axWMPMain.playState.ToString()));
            switch (e.newState)
            {
                case 3: // playing
                    btnPlayMainSong.Text = "Stop";
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
        }
    }
}
