/* Comentarios al final de este código fuente */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace TestHilos
{
    public partial class MainForm : Form
    {
        private int counter;
        private Mutex m;//
        private Thread hilo1, hilo2;
        private List<string> lista;
        private string fruta = "";

        public MainForm()
        {
            InitializeComponent();

            m = new Mutex();//
            // llenamos la Lista
            lista = new List<string>();
            lista.Add("Manzana");
            lista.Add("Pera");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblCounter.Text = "...";
            btnStart.Enabled = false;

            counter = 0;
            hilo1 = new Thread(proc_hilo1);
            hilo2 = new Thread(proc_hilo2);

            hilo1.Start();
            hilo2.Start();

            hilo1.Join();
            hilo2.Join();

            lblCounter.Text = string.Format("{0} - {1}", counter, fruta);
            btnStart.Enabled = true;
        }

        // procesos Hilo hijos de UI Thread
        private void proc_hilo1()
        {
            //lblCounter.Text = "Hilo 1 ..."; // Esta linea produce una excepción al ejecutarse
            for (int i=0; i < 1000000; i++)
            {
                m.WaitOne();//
                counter++;
                m.ReleaseMutex();//
            }
            fruta = lista.First<string>();
        }

        private void proc_hilo2()
        {
            for (int i = 0; i < 1000000; i++)
            {
                m.WaitOne();//
                counter++;
                m.ReleaseMutex();//
            }
            fruta = lista.Last<string>();
        }
    }
}

/*
En este test, se puede ver como trabajan los hilos y los mutex lanzados desde dentro del hilo principal (UI Thread). UI = entorno grafico (user interface)
Queríamos comprobar unas cuantas reglas con el multihilo:
1.- Los hilos hijos pueden acceder a todas las variables declaradas en la Clase aunque sean privadas
2.- Los hilos hijos no pueden controlar componentes UI que no se han creado dentro del propio hilo. Descomentando la linea 55 se puede ver.
3.- El uso de Mutex garantiza el acceso único en cada momento de un solo hilo a una variable compartida, pero enlentece el proceso (puedes probar a comentar las lineas
    que llevan un // detrás, para desactivar el uso de Mutex, de forma que el proceso irá muy rápido pero el conteo, no será fiable y cada vez dará un valor diferente
4.- Las lineas 45 y 46, hacen que el UI Thread, tenga que esperar a que se acaben los procesos de los hilos, bloqueando la ejecución hasta que esto ocurre. Eso hace
    que la ventana gráfica se quede bloqueada durante ese tiempo, quedando sin respuesta a acciones por parte del usuario durante todo ese tiempo. Esto es algo no deseable
    y que tb ocurriría si usamos una serie de componentes Timers, donde al menos uno ejecute un proceso que sea largo, haría que la ventana quedara bloqueada sin respuesta
    durante ese tiempo. Algo así se puede evitar no llamando a Join() que es quien hace que se espere a que los hilos acaben su tarea, bloqueando el UI Thread, pero el problema
    es ¿cuando sabemos que el resultado final del counter esta disponible?. Esto se puede hacer de una manera elegante tan solo metiendo los hilos en 1 componente 
    BackgroundWorker para ejecutar los 2 hilos y usar el evento RunWorkerCompleted para mostrar el resultado una vez acabado. (ver TestBackgroundWorker)
*/
