using System;
using System.Collections.Generic;
using Tmds.MDns;

namespace ServiceFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> serviceTypes = new List<string>();
            serviceTypes.Add("_https._tcp");
            serviceTypes.Add("_ftp._tcp");

            ServiceBrowser serviceBrowser = new ServiceBrowser();
            serviceBrowser.ServiceAdded += onServiceAdded;
            serviceBrowser.ServiceRemoved += onServiceRemoved;
            serviceBrowser.ServiceChanged += onServiceChanged;

            Console.WriteLine("Browsing for types: ");
            serviceBrowser.StartBrowse(serviceTypes);
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
