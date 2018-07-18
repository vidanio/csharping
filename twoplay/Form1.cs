/*
Es un ejemplo sencillo de mezcla de audios donde ambos players estan en continuo crossfade de manera que el volumen de uno es
100 menos el volumen del otro, sumando ambos siempre 100, y creando efecto de crossfade al mover las barras de volumenes de ambos
WMP players
 *  */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace twoplay
{
    public partial class MainForm : Form
    {
        private string song1, song2;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            axWMP1.settings.volume = 100;
            tbarVol1.Value = axWMP1.settings.volume;
            axWMP2.settings.volume = 0;
            tbarVol2.Value = axWMP2.settings.volume;
        }

        private void tbarVol1_Scroll(object sender, EventArgs e)
        {
            axWMP1.settings.volume = tbarVol1.Value;
            axWMP2.settings.volume = 100 - axWMP1.settings.volume;
            tbarVol2.Value = axWMP2.settings.volume;
        }

        private void tbarVol2_Scroll(object sender, EventArgs e)
        {
            axWMP2.settings.volume = tbarVol2.Value;
            axWMP1.settings.volume = 100 - axWMP2.settings.volume;
            tbarVol1.Value = axWMP1.settings.volume;
        }

        private void btnLoadSong1_Click(object sender, EventArgs e)
        {
            if (openSong.ShowDialog() == DialogResult.OK)
            {
                song1 = openSong.FileName;
                lblSong1.Text = song1;
                axWMP1.URL = song1;
            }
        }

        private void btnLoadSong2_Click(object sender, EventArgs e)
        {
            if (openSong.ShowDialog() == DialogResult.OK)
            {
                song2 = openSong.FileName;
                lblSong2.Text = song2;
                axWMP2.URL = song2;
            }
        }
    }
}
