/* Comentarios al final del código */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FullTaskAsync
{
    public partial class MainForm : Form
    {
        private int value = 5;
        private CancellationTokenSource cts; // fase 3 cancelacion
        private bool running = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void numUpDown_ValueChanged(object sender, EventArgs e)
        {
            value = (int) numUpDown.Value;
            if (value < 5)
            {
                value = 5;
            }else if (value > 10)
            {
                value = 10;
            }
            numUpDown.Value = value;
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            if (running) return; // solo corremos una vez el proceso paralelo

            // iniciamos los valores
            lblPercent.Text = "0 %";
            progbarPercent.Value = 0;
            bool cancelled = false; // fase 3 cancelacion
            running = true;

            var progressIndicator = new Progress<int>(ReportProgress); // fase 2 progress
            cts = new CancellationTokenSource(); // fase 3 cancelacion
            // fase 3 debemos capturar la excepción por cancelación try-catch
            try
            {
                int ret = await ProcesoLentoAsync(value, progressIndicator, cts.Token); // fase 1 solo el proceso asíncrono
            }
            catch (OperationCanceledException) // excepcion OCE
            {
                lblPercent.Text = "proceso cancelado"; // fase 3 cancelación
            }
            catch (Exception err)
            {
                lblPercent.Text = "Error: " + err.Message; // error no capturado en el proceso, se relanza en sus funciones Async
            }

            running = false;
            if (!cancelled) lblPercent.Text = "proceso terminado"; // añadimos if en fase 3
        }

        // añadida en la fase 2 progress (valor 0-100)
        private void ReportProgress(int valor)
        {
            //actualizamos el UI
            lblPercent.Text = string.Format("{0} %", valor);
            progbarPercent.Value = valor;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (running) cts.Cancel(); // fase 3 cancelacion (ponemos IsCancellationRequested = true)
        }

        // 1.- este es el proceso lento original escrito sincronicamente (esto es hilo paralelo, NO acceder al UI aquí dentro)
        // luego añadimos el IProgress<int> progress fase 2
        // finalmente añadimos CancellationToken ct fase 3
        private int ProcesoLento(int enter, IProgress<int> progress, CancellationToken ct)
        {
            for (int i = 0; i < enter; i++)
            {
                Thread.Sleep(1000); // 1 segundo cada vuelta (simulación de proceso lento)
                ct.ThrowIfCancellationRequested(); // fase 3, lanza Excepcion OCE si IsCancellationRequested = true
                if (progress != null) progress.Report((i+1) * 100 /enter); // fase 2 progress (reportamos el progreso en el proceso)
            }
            return enter;
        }

        // 2.- este es el proceso lento escrito en Task Async, ya es asíncrono
        // luego añadimos el IProgress<int> progress fase 2
        // finalmente añadimos CancellationToken ct fase 3
        private Task<int> ProcesoLentoTaskAsync(int enter, IProgress<int> progress, CancellationToken ct)
        {
            return Task.Run<int>(() => ProcesoLento(enter, progress, ct));
        }

        // 3.- este es el proceso lento escrito como async final
        // luego añadimos el IProgress<int> progress fase 2
        // finalmente añadimos CancellationToken ct fase 3
        private async Task<int> ProcesoLentoAsync(int enter, IProgress<int> progress, CancellationToken ct)
        {
            int valor = await ProcesoLentoTaskAsync(enter, progress, ct);

            return valor;
        }
    }
}
/*
Este es un ejemplo sencillo de como añadir a un ejemplo del estilo de TestTaskAsync las opciones de cancelación y notificación de progreso así como la captura de excepciones
no controladas durante el ProcesoLento. El código viene marcado en el orden en que fue escrito. Primero las lineas no comentadas o comentadas de la fase 1, en esta fase
simplemente teníamos el proceso lento escrito en 3 partes (original sincrónoco, TaskAsync y Async). Luego las lineas comentadas de la fase 2, en la que añadimos la notificación
del progreso durante el proceso, para ello añadimos el segundo parámetro de las funciones ProcesoLento...(). Finalmente las lineas comentadas de la fase 3, en la que añadimos
la posibilidad de cancelación mediante un CancelToken; de manera similar añadimos el tercer parámetro de las funciones ProcesoLento...() y el código que la controla.
Como ves, en .NET 4.5 o superior se puede escribir un ejemplo con async/await/Task que tenga las mismas capacidades que el uso de BackgroundWorker en el ejemplo FullBackgroundWorker.
De hecho el código queda más sencillo de entender ya que esta escrito como si fuera sincrónico.
MUY IMPORTANTE: Si vas a probar la cancelación, compila antes una versión Release y ejecútala fuera de VisualStudio o el debugger te parará en la linea 90.
*/
