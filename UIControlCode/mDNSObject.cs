using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIControlCode
{
    class mDNSObject
    {
        // properties
        public string Type { get; set; } // http, https
        public string Name { get; set; } // service.Instance
        public string Address { get; set; } = ""; // IPv4 addr
        public int Port { get; set; } // service.Port

        public mDNSObject()
        {

        }

    }
}
