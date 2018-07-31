/* Comentarios al final del codigo */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace winforms
{
    public partial class MainForm : Form
    {
        private int counter = 0;
        private bool function = false; // false = start / true = stop

        public MainForm()
        {
            InitializeComponent();
        }

        private void bgHilo_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bg = sender as BackgroundWorker;
            int count = (int)e.Argument;

            SpinWait sw = new SpinWait(); // espera multiprocesador (como un yield monoprocesador)
            while (true) // bucle infinito
            {
                if (bg.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                count++;
                bg.ReportProgress(0, count);
                sw.SpinOnce(); // evita que el bucle infinito cuelgue el programa como en Go, si lo comentas se colgará mucho
            }
            e.Result = count;
        }

        private void bgHilo_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            counter = (int)e.UserState;
            lblCount.Text = counter.ToString();
        }

        private void bgHilo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null) // no se esperan excepciones pero por si acaso
            {
                MessageBox.Show(e.Error.Message, "Exception !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (e.Cancelled)
            {
                // no hacemos nada, solo parar
            }
            else
            {
                // solo se puede salir del bucle infinito mediate cancelación por lo que no se espera que se ejecute esto nunca
                counter = (int)e.Result;
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (function) // STOP
            {
                function = false;
                btnAction.Text = "Start";
                if (bgHilo.IsBusy)
                    bgHilo.CancelAsync();
            }
            else // START
            {
                function = true;
                btnAction.Text = "Stop";
                if (!bgHilo.IsBusy)
                    bgHilo.RunWorkerAsync(counter);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (!function)
            {
                counter = 0;
                lblCount.Text = counter.ToString();
            }
        }
    }
}
/*
Este es un ejemplo interesante en el que usamos un hilo backgroundworker para gestionar un contador mostrado en un Lable del UI sin bloquear la ventana, corriendo asíncronamente
al UI. Al usar en el hilo un bucle infinito, nos encontramos antes el típico problema del cuelgue debido a que este proceso se queda con todo el tiempo del scheduler, para ello
podríamos usar un Thread.Sleep(1), que es la espera más pequeña de 1 segundo, pero es muy grande para un procesador que puede ir más rápido. Un procesador con 1 hyperthread, podría
usar Thread.Yield(), pero en procesadores con varios hyperthreads, como backgroundworker trabaja en un threadpool, cambia de thread del OS, esto daría tb un cuelgue, por lo que
desde .NET 4.0 existe la clase SpinWait para este fin. 
*/
