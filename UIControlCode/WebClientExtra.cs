﻿using System;
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

        public Task<string> GetHTTPStringPTaskAsync(Uri uri)
        {
            return Task<string>.Run(() => GetHTTPString(uri));
        }
    }
}
