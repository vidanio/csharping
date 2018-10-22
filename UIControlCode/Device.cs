using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIControlCode
{
    class Device
    {
        // properties
        public string Type { get; set; }
        public string Name { get; set; }
        public int Delay { get; set; }
        public int Seconds { get; set; }
        public int Kbps { get; set; }
        public bool Working { get; set; }
        public bool Active { get; set; }
        public string Random { get; set; }

        public string Time
        {
            get
            {
                string time;
                TimeSpan ts = new TimeSpan(this.Seconds * 10000000L); // ticks
                if (Seconds < 86400)
                {
                    if (Seconds < 3600)
                    {
                        if (Seconds < 60)
                            time = String.Format("{0}s", ts.Seconds);
                        else
                            time = String.Format("{0}m:{1:00}s", ts.Minutes, ts.Seconds);
                    }
                    else
                        time = String.Format("{0}h:{1:00}m:{2:00}s", ts.Hours, ts.Minutes, ts.Seconds);
                }
                else
                    time = String.Format("{0}d:{1:00}h:{2:00}m:{3:00}s", ts.Days, ts.Hours, ts.Minutes, ts.Seconds);
                 
                return time;
            }
        }

        public Device(string csv)
        {
            var words = csv.Split(';');
            this.Type = words[0];
            this.Name = words[1];
            this.Delay = Convert.ToInt32(words[2]);
            this.Seconds = Convert.ToInt32(words[3]);
            this.Kbps = Convert.ToInt32(words[4]);
            this.Working = (words[5] == "true") ? true : false;
            this.Active = (words[6] == "true") ? true : false;
            this.Random = words[7];
        }

        public string Print()
        {
            return String.Format("{0} {1} {2}ms {3}s {4}kbps {5} {6} {7} {8}", Type, Name, Delay, Seconds, Kbps, Working, Active, Random, Time);
        }
    }
}
/*
    tipo, nombre, delay, seconds, kbps, working, active, random
E;Encoder11;0;0;0;false;true;VRbybdDBvtEsdVol
D;Linux82;0;0;0;false;true;WRCQGpzkmhkuGSAb
*/
