using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(yturl("https://www.youtube.com/watch?v=axkZ2tL23M8"));

            Console.ReadKey();
        }

        public static string yturl(string url, string videoFormat = "video/mp4")
        {
            String id = url.Substring(url.IndexOf("v=") + 2);

            System.Net.WebClient wc = new System.Net.WebClient();
            wc.CachePolicy = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore);
            byte[] response = wc.DownloadData("http://www.youtube.com/get_video_info?video_id=" + id);
            String html = System.Text.Encoding.ASCII.GetString(response);

            String x = html.Substring(html.IndexOf("url_encoded_fmt_stream_map"));
            x = Uri.UnescapeDataString(x);
            x = x.Substring(x.IndexOf("url=") + 4);
            x = x.Substring(0, x.IndexOf(","));
            return Uri.UnescapeDataString(x);

        }
    }
}
