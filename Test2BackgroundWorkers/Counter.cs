using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Test2BackgroundWorkers
{
    class Counter
    {
        private int counter;
        private Mutex mutex; // mutex para asegurar counter en hilos

        public Counter()
        {
            this.counter = 0;
            mutex = new Mutex();
        }

        public int Increase()
        {
            int i;

            mutex.WaitOne();
            i = ++this.counter;
            mutex.ReleaseMutex();

            return i;
        }

        public int GetCounter()
        {
            int i;

            mutex.WaitOne();
            i = this.counter;
            mutex.ReleaseMutex();

            return i;
        }
    }
}
/*
La clase Counter es sencilla, solamente contiene la variable a asegurar con su mutex, y los métodos publicos que nos interesan para implementar el ejemplo TestHilos
*/
