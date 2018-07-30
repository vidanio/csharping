/* Comentarios al final de este código */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FullBackgroundWorker
{
    public partial class FibonacciForm : Form
    {
        private int numberToCompute = 0;
        private int highestPercentageReached = 0;

        public FibonacciForm()
        {
            InitializeComponent();
        }

        // este proceso es el hilo paralelo, y desde dentro de él no se puede acceder a los componentes del UI Thread
        // backgroundWorker1.IsBusy es true nada más entrar en esta función, y es false nada más salir de ella
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // se recupera el objecto que llama a este hilo para uso posterior de forma thread-safe
            BackgroundWorker worker = sender as BackgroundWorker;
            // e.Argument es un object que lleva el parámetro de llamada desde RunWorkerAsync()
            // e.Result es un object que devuelve el resultado del proceso asíncrono
            e.Result = ComputeFibonacci((int)e.Argument, worker, e);
        }

        // esta funcion es llamada desde el hilo paralelo, por lo que no puede acceder a componentes del UI Thread
        long ComputeFibonacci(int n, BackgroundWorker worker, DoWorkEventArgs e)
        {
            // el número debe estar entre 0 y 90, evitando el overflow
            if ((n < 0) || (n > 91))
            {
                // lanzamos una excepción de tipo argumento
                throw new ArgumentException("Value must be >= 0 and <= 91", "n");
            }

            long result = 0;

            // e.Cancel por defecto es false
            if (worker.CancellationPending)
            {
                // si se ha pulsado Cancel, hay q poner e.Cancel = true y salir de DoWork()
                // llamando así a RunWorkerCompleted con e.Cancelled = true
                e.Cancel = true;
            }
            else
            { 
                // hacemos el cálculo recursivo normal
                if (n < 2)
                {
                    result = 1;
                }
                else
                {
                    result = ComputeFibonacci(n - 1, worker, e) + ComputeFibonacci(n - 2, worker, e);
                }

                // Reportamos el porcentaje del cálculo alcanzado
                int percentComplete = (int)((float)n / (float)numberToCompute * 100);
                if (percentComplete > highestPercentageReached)
                {
                    highestPercentageReached = percentComplete;
                    // lo enviamos a ProgressChanged por e.ProgressPercentage
                    // e.UserState es un objeto al que se puede enviar el resultado parcial
                    worker.ReportProgress(percentComplete, result);
                }
            }

            return result;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // ponemos el valor recogido de % progreso en la progressbar
            progressBar1.Value = e.ProgressPercentage;
            // ponemos el valor parcial del cáclulo recursivo a estas alturas en e.UserState
            resultLabel.Text = string.Format("{0} ...", e.UserState.ToString());
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Antes de nada vamos a controlar errores de Excepcion
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message, "Handled Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (e.Cancelled) // luego si se ha cancelado el cálculo
            {
                resultLabel.Text = "Canceled";
                progressBar1.Value = 0;
            }
            else
            {
                // finalmente ponemos el resultado final, si toda va bien
                resultLabel.Text = e.Result.ToString();
            }
        }

        private void startAsyncButton_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy) // solo si no esta calculando ya
            {
                // Vaciamos el resultado antes de proceder al cálculo nuevo
                resultLabel.Text = "";
                // iniciamos las 2 variables globales
                numberToCompute = (int)numericUpDown1.Value;
                highestPercentageReached = 0;
                // lanzamos el cálculo asíncrono con parámetro (DoWork)
                backgroundWorker1.RunWorkerAsync(numberToCompute);
            }
        }

        private void cancelAsyncButton_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy) // solo si esta haciendo algún cálculo se puede cancelar
            {
                // pone CancellarionPending = true y lanza el evento RunWorkerCompleted cuando e.Cancel en DoWork sea puesto y haya salido de él
                backgroundWorker1.CancelAsync();
            }
        }
    }
}
/*
Este es un ejemplo sencillo, pero completo sobre todos los aspectos del uso de BackgroundWorker como clase manejadora de hilos paralellos.
Para poder hacer uso del botón Cancel y observar el progreso y cálculos intermedios, te recomendamos usar números entre 35 y 40. Números por encima de ese valor
irán muy lentos al final, y por encima de 90, darán una excepción, que tb puedes probar. Si vas a probar la excepción, asegúrate de compilar en modo Release y ejecutar
desde fuera de VS2017, ya que de los contrario el Debugger se te parará en throw Exception, y ya no seguirá más.
Hay funciones asíncronas en el .NET que ya estan pre-creadas como UploadFileAsync() o DownloadFileAsync() con un comportamiento idéntico a este ejemplo.
 */
