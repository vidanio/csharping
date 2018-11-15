using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace NetDevice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Retrive all network interface using GetAllNetworkInterface() method off NetworkInterface class.
            NetworkInterface[] niArr = NetworkInterface.GetAllNetworkInterfaces();

            Console.WriteLine("Retriving basic information of network.\n\n");

            //Display all information of NetworkInterface using foreach loop.

            foreach (NetworkInterface tempNetworkInterface in niArr)
            {
                Console.WriteLine("Network Description        : " + tempNetworkInterface.Description);
                Console.WriteLine("Network ID                 : " + tempNetworkInterface.Id);
                Console.WriteLine("Network Name               : " + tempNetworkInterface.Name);
                Console.WriteLine("Network Interface Type     : " + tempNetworkInterface.NetworkInterfaceType.ToString());
                Console.WriteLine("Network Operational Status : " + tempNetworkInterface.OperationalStatus);
                Console.WriteLine("Network Spped              : " + tempNetworkInterface.Speed);
                Console.WriteLine("Support Multicast          : " + tempNetworkInterface.SupportsMulticast);
                Console.ReadLine();
            }
        }
    }
}
