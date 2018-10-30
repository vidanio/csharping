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
            wr.Timeout = 5000; // timeout in milliseconds (ms) - 5 seconds
            return wr;
        }

        private string GetHTTPString(Uri uri)
        {
            try
            {
                return DownloadString(uri);
            }
            catch
            {
                // err
                return null;
            }
        }

        public Task<string> GetHTTStringPTaskAsync(Uri uri)
        {
            return Task<string>.Run(() => GetHTTPString(uri));
        }
    }
}
