using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nPlease enter the URI to post data to : ");
            String uriString = Console.ReadLine();

            // Create a new WebClient instance.
            WebClient myWebClient = new WebClient();
            myWebClient.Headers.Add("Content-Type", "binary/octet-stream");

            Console.WriteLine("\nPlease enter the fully qualified path of the file to be uploaded to the URI");
            string fileName = Console.ReadLine();
            Console.WriteLine("Uploading {0} to {1} ...", fileName, uriString);

            // Upload the file to the URI.
            // The 'UploadFile(uriString,fileName)' method implicitly uses HTTP POST method.
            byte[] response = myWebClient.UploadFile(uriString, fileName);

            // Decode and display the response.
            Console.WriteLine("\nResponse Received.The contents of the file uploaded are:\n{0}",
                System.Text.Encoding.ASCII.GetString(response));

            Console.ReadKey();
        }
    }
}
