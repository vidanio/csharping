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
            Task<int> task = new Task<int>(LongRunningTask);
            task.Start();
            Task<int> childTask = task.ContinueWith<int>(SquareOfNumber);
            Console.WriteLine("Sqaure of number is :" + childTask.Result);
            Console.WriteLine("The number is :" + task.Result);

            Console.ReadKey();
        }

        private static int LongRunningTask()
        {
            Thread.Sleep(3000);
            return 2;
        }

        private static int SquareOfNumber(Task<int> obj)
        {
            return obj.Result * obj.Result;
        }
    }
}
