using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTaskAsync
{
    public partial class MainForm : Form
    {
        private int counter;
        private int taskcount;
        private Object obj = new Object(); // para bloqueo lock

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            taskcount = 0;
            counter = 0;

            ProcedimientoLargoAsync(); // ejecución asíncrona 1 vez
            ProcedimientoLargoAsync(); // ejecución asíncrona 2 vez

            lblCounter.Text = "...";
        }

        // 1.- Este es el procedimiento original con código sincrónico y protegido en seccion crítica
        // con lock el código es al menos 100 veces más rapido que con Mutex, por eso elevamos la cifra a contar
        private void ProcedimientoLargo()
        {
            for (int i = 0; i < 100000000; i++)
            {
                lock (obj) counter++;
            }
        }

        // 2.- Este es el procedimiento original convertido a TaskAsync (ya es asíncrono)
        private Task ProcedimientoLargoTaskAsync()
        {
            return Task.Run(() => ProcedimientoLargo());
        }

        // 3.- Este es el procedimiento convertido a Async con código síncrono del UI Thread que se ejecuta una vez acabado
        private async void ProcedimientoLargoAsync()
        {
            await ProcedimientoLargoTaskAsync(); // esta parte se ejecuta en un hilo paralelo
            // cuando termina el hilo, vuelve la ejecución a esta línea de código sincrono del UI Thread sin problemas
            taskcount++;
            if (taskcount == 2)
                lblCounter.Text = counter.ToString();
        }
    }
}
/*
Este ejemplo muestra lo extraordinariamente sencillo que es programar tareas asíncronas como si fueran síncronas con .NET 4.5 (no compatible con XP) sin necesidad
de usar callbacks, ni delegados para saber cuando acabaron las tareas. Lo hemos mostrado como un proceso en 3 estadios, desde el procedimiento largo original y síncrono, su
paso a TaskAsync que se podría usar con código más completo, y finalmente su paso a Async con el uso de async/wait y código síncrono posterior a la terminación del hilo.
A día de hoy, la programación de procesos asíncronos es mucho más simple de esta manera, y se lee tan fácil como el código síncrono
*/