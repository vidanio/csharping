/* 
Proceso es una clase completa para mostrar variables internas, propiedades públicas, métodos públicos y eventos públicos (del delegado EventHandler)
 *  */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

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

        // metodo que ejecuta el proceso completo hasta su final, puede durar mucho
        public void Run()
        {
            int resultado = 100;
            Thread.Sleep(5000);

            // final del proceso, recogemos argumentos y disparamos el evento Finished (noticamos que hemos acabado)
            ProcesoFinishedEventArgs args = new ProcesoFinishedEventArgs();
            args.Result = resultado;
            OnFinished(args);
        }
    }

    // sub-clase para recoger argumentos del evento Finished
    public class ProcesoFinishedEventArgs : EventArgs
    {
        public int Result { get; set; }
    }
}
