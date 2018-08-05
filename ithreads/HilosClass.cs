using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ithreads
{
    class HilosClass
    {
        private int cont;
        private Mutex mtx; // mutex para asegurar counter en hilos

        public HilosClass()
        {
            this.cont = 0;
            mtx = new Mutex();
        }

        public int Incremento()
        {
            int i = 0;

            mtx.WaitOne();//
            i = ++this.cont;
            mtx.ReleaseMutex();//
            return i;
        }

        public string ParImpar()
        {
            string res = "";
            if(this.cont % 2 == 0)
            {
                res = "ES PAR"; //PAR
            }
            else
            {
                res = "ES IMPAR"; //IMPAR
            }
            return res;
        }
    }
}
