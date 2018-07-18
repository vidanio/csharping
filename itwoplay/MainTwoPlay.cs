using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace itwoplay
{
    public partial class MainTwoPlay : Form
    {
        private string cancion1, cancion2;

        public MainTwoPlay()
        {
            InitializeComponent();
        }

        private void MainTwoPlay_Load(object sender, EventArgs e)
        {
            //Inicializacion de volumenes
            axWMPro1.settings.volume = 100;
            trackBarSong1.Value = axWMPro1.settings.volume;
            axWMPro2.settings.volume = 0;
            trackBarSong2.Value = axWMPro2.settings.volume;
        }

        private void btnSong1_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                cancion1 = openFile.FileName;
                LblSong1.Text = cancion1;
                axWMPro1.URL = cancion1;
            }
        }

        private void btnSong2_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {   
                cancion2 = openFile.FileName;
                LblSong2.Text = cancion2;
                axWMPro2.URL = cancion2;
            }
        }

        private void trackBarSong1_Scroll(object sender, EventArgs e)
        {
            axWMPro1.settings.volume = trackBarSong1.Value;
            axWMPro2.settings.volume = 100 - axWMPro1.settings.volume;
            trackBarSong2.Value = axWMPro2.settings.volume;
        }

        private void trackBarSong2_Scroll(object sender, EventArgs e)
        {
            axWMPro2.settings.volume = trackBarSong2.Value;
            axWMPro1.settings.volume = 100 - axWMPro2.settings.volume;
            trackBarSong1.Value = axWMPro1.settings.volume;
        }
    }
}
