﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace MyIP
{
    class Program
    {
        static void Main(string[] args)
        {
            string localIP="";
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
                {
                    try
                    {
                        socket.Connect("www.todostreaming.es", 65530);
                        IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                        localIP = endPoint.Address.ToString();
                    }
                    catch
                    {
                        Console.WriteLine("Socket Error");
                    }
                }
                Console.WriteLine("IP local(1): " + localIP);
            }
            else
            {
                Console.WriteLine("Not Available Network");
            }
            try
            {
                var address = Dns.GetHostAddresses("jrweb.todostreaming.es")[0]; // DNS to IPv4
                Console.WriteLine("DNS = " + address.ToString());
            }
            catch { }

            Console.ReadLine();
        }
    }
}
