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
            using (BlockingCollection<int> bc = new BlockingCollection<int>())
            {

                // lanzamos la tarea del productor
                Task.Factory.StartNew(() =>
                {
                    for (int i = 0; i < 10; i++)
                    {
                        bc.Add(i);
                        Thread.Sleep(100); // sleep 100 ms between adds
                    }

                    // Need to do this to keep foreach below from hanging
                    //bc.CompleteAdding();//
                    Console.WriteLine("Exiting Producer - {0} - {1}", bc.IsCompleted, bc.IsAddingCompleted);
                });

                // parte de código del consumidor de datos
                foreach (var item in bc.GetConsumingEnumerable())
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Exiting Consumer");
            }
            Console.WriteLine("Exited from Both");

            Console.ReadKey();
        }
    }
}
/*
Este es un ejemplo de consola sencillo, donde se pueden probar las capacidades del un multiproducer-multiconsumer, con una clase moderna del NET 4.0 (compatible XP), llamada
BlockingCollection, que nos permite manejar fácilmente 1 o varios colecciones del (cola, pila o bolsa) con una capacidad determinada, de ser alimentada por varios hilos producer
y consumida por varios hilos consumer. Si comentas y descomentas la linea 28 puedes ver como afecta la propiedad isCompleted. 
Es importante que uno de los hilos consumidores, sea el padre del resto de hilos consumidores y productores para que dicha propiedad bloquee a los consumers, mientras 
isCompleted = false.
*/