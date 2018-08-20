using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace videotest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                //axVideoCapX1.DebugMode = 1;

                axVideoCapX1.PlayerOpen(file);
                axVideoCapX1.VideoRenderer = VIDEOCAPXLib.vcxVideoRendererEnum.vcxDeckLinkVideoRenderer;
                //int vw = 0, vh = 0;
                //axVideoCapX1.PlayerGetVideoSize(ref vw, ref vh);
                //this.ClientSize = new System.Drawing.Size(vw, vh);
                axVideoCapX1.PlayerStart();
                toolStripStatusLabel1.Text = "Playing file " + file;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rTMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = "rtmp://46.105.112.88/radiovida/livestream";
            axVideoCapX1.PlayerOpen(file);
            axVideoCapX1.VideoRenderer = VIDEOCAPXLib.vcxVideoRendererEnum.vcxDeckLinkVideoRenderer;
            //int vw = 0, vh = 0;
            //axVideoCapX1.PlayerGetVideoSize(ref vw, ref vh);
            //this.ClientSize = new System.Drawing.Size(vw, vh);
            axVideoCapX1.PlayerStart();
        }

        private void axVideoCapX1_PlayerEnd(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Playback stopped";
        }
    }
}
