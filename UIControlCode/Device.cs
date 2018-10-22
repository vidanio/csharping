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
            return String.Format("{0} {1} {2}ms {3}s {4}kbps {5} {6} {7}", Type, Name, Delay, Seconds, Kbps, Working, Active, Random);
        }
    }
}
/*
    tipo, nombre, delay, seconds, kbps, working, active, random
E;Encoder11;0;0;0;false;true;VRbybdDBvtEsdVol
D;Linux82;0;0;0;false;true;WRCQGpzkmhkuGSAb
*/
