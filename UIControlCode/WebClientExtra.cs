using System;
using System.Threading.Tasks;
using System.Threading;
using System.Net;

namespace UIControlCode
{
    class WebClientExtra : WebClient
    {
        protected override WebRequest GetWebRequest(Uri address)
        {
            HttpWebRequest req = (HttpWebRequest)base.GetWebRequest(address);
            req.ServicePoint.ConnectionLimit = 24;
            req.Timeout = 5000; // timeout in milliseconds (ms) - 5 seconds
            return req;
        }

        public Task<string> GetHTTPStringPTaskAsync(Uri uri)
        {
            return Task<string>.Run(() => GetHTTPStringRetry(uri, 3));
        }

        public string GetHTTPString(Uri uri)
        {
            try
            {
                return DownloadString(uri);
            }
            catch
            {
                return null;
            }
        }

        public string GetHTTPStringRetry(Uri uri, int times)
        {
            int counter = 0;
            string resp;

            do
            {
                counter++;
                resp = GetHTTPString(uri);
                if (resp != null) break;
                Thread.Sleep(100);
            } while (counter < times);

            return resp;
        }
    }
}
