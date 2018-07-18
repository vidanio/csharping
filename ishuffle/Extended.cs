using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ishuffle
{
    partial class MainShuffle
    {
        private void axWMPro_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 1) //Cuando está parado
            {
                stop = true;
            }
        }
        //Hay error, por tanto pasamos a la siguiente cancion
        private void axWMPro_ErrorEvent(object sender, EventArgs e)
        {
            stop = true; 
        }

        private void timerShuffle_Tick(object sender, EventArgs e)
        {
            if (axWMPro.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressShuffle.Value = Convert.ToInt32(axWMPro.Ctlcontrols.currentPosition * 100 / axWMPro.currentMedia.duration);
            }
            else
            {
                progressShuffle.Value = 0;
            }
            if (stop)
            {
                stop = false;
                index++;
                if (index < playlist.Count)
                {
                    axWMPro.URL = playlist[index];
                    playingInfo.Items.Add(string.Format("Reproduciendo: {0}\r\n", playlist[index]));
                }
                else
                {
                    index = 0;
                    axWMPro.close();
                    btnPlay.Enabled = true;
                    timerShuffle.Stop();
                }
            }
        }
    }
}
