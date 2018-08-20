using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace videotest2
{
    public partial class Form1 : Form
    {
        int counter = 0;
        string file = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file = openFileDialog1.FileName;

                axfsPlayer1.AudioOutput = fsPlayerLib.AudioRendererEnum.DeckLinkAudio;
                axfsPlayer1.VideoOutput = fsPlayerLib.RendererEnum.DeckLink1;
                axfsPlayer1.OpenFile(file, 0, 0, 1, "playfile");
                axfsPlayer1.Start();
                toolStripStatusLabel1.Text = "Playing file: "+file;
                counter = 0;
                timer1.Start();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rTMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = "rtmp://144.217.12.77/live/solidariatv-webhd";

            axfsPlayer1.AudioOutput = fsPlayerLib.AudioRendererEnum.DeckLinkAudio;
            axfsPlayer1.VideoOutput = fsPlayerLib.RendererEnum.DeckLink1;
            axfsPlayer1.OpenFile(file, 0, 0, 1, (new Random()).NextDouble().ToString());
            axfsPlayer1.Start();
            toolStripStatusLabel1.Text = "Playing Stream: " + file;
            counter = 0;
            timer1.Start();
        }

        private void axfsPlayer1_Complete(object sender, AxfsPlayerLib._DfsPlayerEvents_CompleteEvent e)
        {
            toolStripStatusLabel1.Text = "Playback finished !!!";
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = string.Format("Pos: {0} sec / Work: {1} sec", (int)axfsPlayer1.Position, ++counter);
        }
    }
}
