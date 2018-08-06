using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace TestTaskC4
{
    public partial class MainForm : Form
    {
        private int counter;
        private Mutex m;//
        private List<string> lista;
        private string fruta = "";
        private int taskcount;

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
            taskcount = 0;

            counter = 0;
            // se crean y arrancan los 2 hilos y se preparan sus callbacks de terminación
            Task.Factory.StartNew(proc_hilo1).ContinueWith(hilo1_finished);
            Task.Factory.StartNew(proc_hilo2).ContinueWith(hilo2_finished);
            timer1.Start();
        }

        // usamos el timer para interactuar con el el UI
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (taskcount == 2)
            {
                lblCounter.Text = string.Format("{0} - {1}", counter, fruta);
                btnStart.Enabled = true;
                timer1.Stop();
            }
        }

        // procesos callback cuando las tareas acaban
        // estas siguen siendo tareas, no acceder al UI
        private void hilo1_finished(Task obj)
        {
            taskcount++;
        }

        private void hilo2_finished(Task obj)
        {
            taskcount++;
        }

        // tareas hijas de UI Thread
        // no acceder al UI desde aquí
        private void proc_hilo1()
        {
            for (int i = 0; i < 1000000; i++)
            {
                m.WaitOne();//
                counter++;
                m.ReleaseMutex();//
            }
            fruta = lista.Last<string>();
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
