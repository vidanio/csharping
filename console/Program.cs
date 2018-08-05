using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using System.Threading;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Diagnostics.Process.Start("iexplore", "http://www.todostreaming.es/");
            System.Diagnostics.Process.Start("http://www.todostreaming.es/");
            Thread.Sleep(5000);
            // it will open a new tab
            System.Diagnostics.Process.Start("http://www.google.es/");

            Console.ReadKey();
        }
    }
}
