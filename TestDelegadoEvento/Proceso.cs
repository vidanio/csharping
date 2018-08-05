/* 
Proceso es una clase completa para mostrar variables internas, propiedades públicas, métodos públicos y eventos públicos (del delegado EventHandler)
Usamos async/wait/Task del ejemplo TestAsyncWait para hacerlo asíncrono, pero solo funciona en .NET 4.5+
 *  */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestDelegadoEvento
{
    // clase principal completa
    class Proceso
    {
        //declaración del evento Finished (que se dispara cuando acaba el proceso completamente)
        public event EventHandler<ProcesoFinishedEventArgs> Finished;

        // este es el constructor principal
        public Proceso()
        {
            // no hago nada interesante
        }

        // este método solamente dispara el evento Finished con sus argumentos (sender, e)
        // se declara protected para que pueda heredarse como private y virtual para poder hacer override en la clase hija
        protected virtual void OnFinished(ProcesoFinishedEventArgs e)
        {
            EventHandler<ProcesoFinishedEventArgs> handler = Finished;

            if (handler != null)
            {
                handler(this, e);
            }
        }

        // metodo que ejecuta el proceso de 5 segundos asíncronamente
        public async void Run(int value)
        {
            // Tarea paralela que espera a q termine (await) y devuelve un Object
            var ret = await Task<Object>.Run(() => LongOperation(value));

            // final del proceso, recogemos argumentos y disparamos el evento Finished (noticamos que hemos acabado)
            ProcesoFinishedEventArgs args = new ProcesoFinishedEventArgs();
            args.Result = (int)ret;
            OnFinished(args);
        }

        // operacion q dura 5 segundos
        private Object LongOperation(int value)
        {
            Thread.Sleep(5000);
            return value;
        }
    }

    // sub-clase para recoger argumentos del evento Finished
    public class ProcesoFinishedEventArgs : EventArgs
    {
        public int Result { get; set; }
    }
}
