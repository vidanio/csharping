/* Comentarios al final de este código fuente */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test2BackgroundWorkers
{
    public partial class MainForm : Form
    {
        private Counter counter; // contador, mirar en fichero -> Counter.cs
        private int hilos_terminados = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            counter = new Counter();

            if ((!bgHilo1.IsBusy) && (!bgHilo2.IsBusy)) // si ambos hilos estan desocupados
            {
                lblCounter.Text = "...";
                bgHilo1.RunWorkerAsync(counter); // lanzamos el hilo 1 asíncronamente
                bgHilo2.RunWorkerAsync(counter); // lanzamos el hilo 2 asíncronamente
            }
        }

        private void bgHilo1_DoWork(object sender, DoWorkEventArgs e)
        {
            int value;
            Counter cnt = (Counter) e.Argument; // recuperamos el objeto contador original

            for (int i = 0; i < 1000000; i++)
            {
                value = cnt.Increase(); // incrementamos el contador
            }

            e.Result = cnt; // devolvemos el contador
        }

        private void bgHilo1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            hilos_terminados++; // contabilizamos los hilos que han acabado
            Counter cnt = (Counter)e.Result; // recogemos el resultado devuelto por este hilo

            if (hilos_terminados == 2) // solo si este es el último hilo en acabar será el que escriba la valor final del contador
            {
                lblCounter.Text = string.Format("{0}", cnt.GetCounter());
                hilos_terminados = 0; // reseteamos el contador de hilos para poder volver a correr el test
            }
        }

        private void bgHilo2_DoWork(object sender, DoWorkEventArgs e)
        {
            int value;
            Counter cnt = (Counter)e.Argument; // recuperamos el objeto contador original

            for (int i = 0; i < 1000000; i++)
            {
                value = cnt.Increase(); // incrementamos el contador
            }

            e.Result = cnt; // devolvemos el contador
        }

        private void bgHilo2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            hilos_terminados++; // contabilizamos los hilos que han acabado
            Counter cnt = (Counter)e.Result; // recogemos el resultado devuelto por este hilo

            if (hilos_terminados == 2) // solo si este es el último hilo en acabar será el que escriba la valor final del contador
            {
                lblCounter.Text = string.Format("{0}", cnt.GetCounter());
                hilos_terminados = 0; // reseteamos el contador de hilos para poder volver a correr el test
            }
        }
    }
}
/*
En este ejemplo, ya no usamos la clase Thread, si no que cada hilo va representado por un BackgroundWorker. Hemos creado una clase Thread-safe para el contados que puede 
llamarse tranquilamente desde cualquier hilo, sin que hayan problemas. 
El objeto e.Argument es el que pasa el contador al hilo, el objeto e.Result es que recoge el valor final del contador acabado el hilo.
Haremos un ejemplo más avanzado, donde mostraremos el proceso en progreso, y donde se pueda cancerlar en cualquier momento, donde se pueda ver todas las posibilidades
de este fantástico componente para programación multihilo, el BackgroundWorker.
*/
