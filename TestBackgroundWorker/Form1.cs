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

namespace TestBackgroundWorker
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

            // llenamos la Lista
            lista = new List<string>();
            lista.Add("Manzana");
            lista.Add("Pera");
        }

        // hilo bgWorker_DoWork hijo de UI Thread
        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            counter = 0;
            m = new Mutex();//
            hilo1 = new Thread(proc_hilo1);
            hilo2 = new Thread(proc_hilo2);

            hilo1.Start();
            hilo2.Start();

            hilo1.Join();
            hilo2.Join();
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblCounter.Text = string.Format("{0} - {1}", counter, fruta);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // las siguiente lineas ejecutan asíncronamente bgWorker_DoWork() y sigue adelante sin bloquear UI Thread
            if (!bgWorker.IsBusy) // solo si no esta ya ocupado
            {
                lblCounter.Text = "...";
                bgWorker.RunWorkerAsync();
            }
        }

        // procesos Hilo hijos de bgWorker_DoWork
        private void proc_hilo1()
        {
            //lblCounter.Text = "Hilo 1 ..."; // Esta linea produce una excepción al ejecutarse
            for (int i = 0; i < 1000000; i++)
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
Este test es un remake de TestHilos, donde mostramos cómo no bloquear el hilo principal (UI Thread), que se encarga del interfaz gráfico de usuario.
Esta forma es la más sencilla y simple que hay, donde hacemos uso de un componente de WinForms llamado BackgroundWorker, que contiene una serie de propiedades, métodos
y eventos que nos ayudan a hacer que un proceso muy largo, no bloquee el hilo principal. 
De nuevo es btnStart_Click() quien inicia el proceso, pero esta vez ejecutando asíncronamente (es decir sin bloqueo) mediante el método RunWorkerAsync() un hilo hijo
de UI Thread que esta en el handler bgWorker_DoWork(). Es desde éste último, donde se crean y ejecutan los 2 hilos originales, esperando su terminación (proceso largo). 
Una vez que termina, y se sale de bgWorker_DoWork(), se dispara un evento del BackgroundWorker llamado bgWorker_RunWorkerCompleted(), y este sí que puede acceder y controlar
el componente lblCounter para escribir el valor de las variables de la clase principal tras los cálculos.
Podemos ver, como mientras el proceso se ejecuta, ya no esta bloqueada la ventana, y podemos hacer con ella lo que queramos, hasta que aparezca el resultado. No es por 
tanto necesario el desactivar el boton btnStart, ya que solamente ejecuta el proceso de nuevo, una vez que este no esta ocupado (isBusy = false; terminado).
*/
