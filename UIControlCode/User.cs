using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIControlCode
{
    class User
    {
        // properties
        public int Type { get; set; }
        public string Mail { get; set; }
        public string Pass { get; set; }
        public string Name { get; set; }
        public string Random { get; set; }
        public bool Active { get; set; }
        public bool Selected { get; set; } = false; // selected in UI

        public User(int type, string csv)
        {
            this.Type = type;
            var words = csv.Split(';');
            this.Random = words[0];
            this.Mail = words[1];
            this.Pass = words[2];
            this.Name = words[3];
            this.Active = (words[4] == "true")? true: false;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3} {4}", Type, Mail, Pass, Random, Active);
        }
    }
}
