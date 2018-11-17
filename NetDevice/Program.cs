using System;
using System.Management;
using System.Net.NetworkInformation;

namespace NetDevice
{
    class Program
    {
        static void Main(string[] args)
        {
            UseNetworkInterface();
            SelectFromWMIClass();

            Console.ReadLine();
        }

        private static void SelectFromWMIClass()
        {
            Console.WriteLine("Using SelectFromWMIClass.\n\n");

            SelectQuery netObjQry = new SelectQuery("Win32_NetworkAdapter");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(netObjQry);

            foreach (ManagementObject netAdapters in searcher.Get())
            {
                Object adapterTypeObj = netAdapters.GetPropertyValue("AdapterType");
                string adapterType = "";
                if (adapterTypeObj != null)
                {
                    adapterType = adapterTypeObj.ToString();
                }

                Object adapterTypeIDObj = netAdapters.GetPropertyValue("AdapterTypeID");
                string adapterTypeID = "";
                if (adapterTypeIDObj != null)
                {
                    adapterTypeID = adapterTypeIDObj.ToString();
                }
                Object adapterSpeedObj = netAdapters.GetPropertyValue("Speed");
                string adapterSpeed = "";
                if (adapterSpeedObj != null)
                {
                    adapterSpeed = adapterSpeedObj.ToString();
                }

                Console.WriteLine("Network Adapter Name: " + netAdapters.GetPropertyValue("Name").ToString());
                Console.WriteLine("Adapter Type: " + adapterType);
                Console.WriteLine("Adapter Type ID:" + adapterTypeID);
                Console.WriteLine("Adapter Speed:" + adapterSpeed + "\n");
            }
        }

        private static void UseNetworkInterface()
        {
            Console.WriteLine("Using UseNetworkInterface.\n\n");

            foreach (NetworkInterface adapter in NetworkInterface.GetAllNetworkInterfaces())
            {
                Console.WriteLine("Network Description        : " + adapter.Description);
                Console.WriteLine("Network ID                 : " + adapter.Id);
                Console.WriteLine("Network Name               : " + adapter.Name);
                Console.WriteLine("Network Interface Type     : " + adapter.NetworkInterfaceType.ToString());
                Console.WriteLine("Network Operational Status : " + adapter.OperationalStatus);
                Console.WriteLine("Network Spped              : " + adapter.Speed);
                Console.WriteLine("Support Multicast          : " + adapter.SupportsMulticast);
                Console.WriteLine();
            }
        }
    }
}
/*
Network Description        : Broadcom NetXtreme Gigabit Ethernet
Network ID                 : {C8A27172-DF97-435A-B87A-45DF20F3AEF8}
Network Name               : Ethernet
Network Interface Type     : Ethernet
Network Operational Status : Up
Network Spped              : 1000000000
Support Multicast          : True
*/
