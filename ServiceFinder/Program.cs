using System;
using System.Collections.Generic;
using Tmds.MDns;
using System.Threading;

namespace ServiceFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> serviceTypes = new List<string>();
            serviceTypes.Add("_https._tcp");
            serviceTypes.Add("_http._tcp");

            ServiceBrowser serviceBrowser = new ServiceBrowser();
            serviceBrowser.ServiceAdded += onServiceAdded;
            serviceBrowser.ServiceRemoved += onServiceRemoved;
            serviceBrowser.ServiceChanged += onServiceChanged;

            Console.WriteLine("Browsing for types: ");
            serviceBrowser.StartBrowse(serviceTypes);
            //Thread.Sleep(10000);
            //serviceBrowser.StopBrowse();
            Console.WriteLine("Stop Browse");
            Console.ReadLine();
        }

        static void onServiceChanged(object sender, ServiceAnnouncementEventArgs e)
        {
            printService('~', e.Announcement);
        }

        static void onServiceRemoved(object sender, ServiceAnnouncementEventArgs e)
        {
            printService('-', e.Announcement);
        }

        static void onServiceAdded(object sender, ServiceAnnouncementEventArgs e)
        {
            printService('+', e.Announcement);
        }

        static void printService(char startChar, ServiceAnnouncement service)
        {
            Console.WriteLine("Browsing for type {0}", service.Type);
            Console.WriteLine("{0} '{1}' on {2}", startChar, service.Instance, service.NetworkInterface.Name);
            Console.WriteLine("\tHost: {0} ({1})", service.Hostname, string.Join(", ", service.Addresses));
            Console.WriteLine("\tPort: {0}", service.Port);
            Console.WriteLine("\tTxt : [{0}]", string.Join(", ", service.Txt));
        }
    }
}
/*
Browsing for type _https._tcp
+ 'OneStream Share on debian9' on Ethernet
        Host: debian9 (192.168.1.47, fe80::a00:27ff:fe6f:278b%15)
        Port: 1968
        Txt : [path=/usr/local/bin]
Browsing for type _http._tcp
+ 'OneStream Share on debian32' on Ethernet
        Host: debian32 (192.168.1.48, fe80::a00:27ff:fe61:b01d%15)
        Port: 80
        Txt : [path=/usr/local/bin]
 */
