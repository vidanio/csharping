using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace UIControlCode
{
    class WebClientExtra : WebClient
    {
        protected override WebRequest GetWebRequest(Uri address)
        {
            WebRequest wr = base.GetWebRequest(address);
            wr.Timeout = 3000; // timeout in milliseconds (ms) - 3 seconds
            return wr;
        }
    }
}
