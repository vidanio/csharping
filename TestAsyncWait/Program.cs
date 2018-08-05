using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestAsyncWait
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            var worker = new Worker();
            worker.DoWork(); // se ejecuta asíncronamente, no bloquea

            while (!worker.IsComplete) // esperamos a que acabe la tarea paralela, podríamos hacer mientras otras cosas
            {
                Console.Write(".");
                Thread.Sleep(100);
            }

            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }

    class Worker
    {
        public bool IsComplete { get; private set; }

        public async void DoWork() // metodo async, avisa de que hay un await dentro de él
        {
            this.IsComplete = false;
            Console.WriteLine("Doing Work");

            // ejecuta una tarea paralela y espera a que termine (await Task)
            await Task.Run(() => LongOperation()); 

            Console.WriteLine("\nWork completed");
            this.IsComplete = true;
        }

        private void LongOperation()
        {
            Console.WriteLine("Working!");
            Thread.Sleep(2000);
        }
    }
}
/*
Este ejemplo necesita .NET 4.5 o superior por lo que no funciona en XP. Es C# 5 donde se añadieron las palabras async/wait para poder crear métodos asíncronos, que corren en 
otra tarea paralela al hilo principal. Se requieren 2 cosas:
1.- Que el método se declare como async.
2.- Que dentro del méotodo async, se use await para ejecutar la tarea larga en una Task secundaria y espere a que acabe
El código es sencillo escrito de esta manera con async/wait/Task, pero si queremos q funcione en XP y sea fácil, es mejor usar BackgroundWorker.
 *  */