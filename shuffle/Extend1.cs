using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shuffle
{
    partial class MainForm
    {
        private void AxWMP_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 1) // stopped
            {
                stopped = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (axWMP.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                pbarSong.Value = Convert.ToInt32(axWMP.Ctlcontrols.currentPosition * 100 / axWMP.currentMedia.duration);
            }
            else
            {
                pbarSong.Value = 0;
            }
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
    }
}
