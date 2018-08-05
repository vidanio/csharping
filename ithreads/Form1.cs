using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ithreads
{
    public partial class Form1 : Form
    {
        private HilosClass cont;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblEstado.Text = "";
            lblInfo.Text = "";
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            cont = new HilosClass();

            if ((!bgHilo1.IsBusy) && (!bgHilo2.IsBusy))
            {
                lblInfo.Text = "";
                lblParImp.Text = "";
                bgHilo1.RunWorkerAsync(cont);
                bgHilo2.RunWorkerAsync(cont);
            }
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            if ((bgHilo1.IsBusy) && (bgHilo2.IsBusy))
            {
                bgHilo1.CancelAsync();
                bgHilo2.CancelAsync();
            }
        }

        private void bgHilo1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bg = sender as BackgroundWorker;
            HilosClass arg = (HilosClass) e.Argument; // recuperamos el objeto contador original
            for (int i = 1; i < 1000000; i++)
            {
                if (bg.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                bg.ReportProgress(0, arg.Incremento());
                Thread.Sleep(1000);
            }
        }

        private void bgHilo1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int value = (int)e.UserState;
            lblEstado.Text = Convert.ToString(value);
        }

        private void bgHilo1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                lblInfo.Text = "Cancelado";
            }
            else
            {
                lblInfo.Text = "Terminado";
            }
        }

        private void bgHilo2_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                BackgroundWorker bg = sender as BackgroundWorker;
                HilosClass fol = (HilosClass)e.Argument;
                SpinWait sw = new SpinWait();

                while (true) // bucle infinito
                {
                    if (bg.CancellationPending)
                    {
                        e.Cancel = true;
                        break;
                    }
                    bg.ReportProgress(0, fol.ParImpar());
                    sw.SpinOnce();
                }
            }
            catch
            {
                e.Cancel = true;
            }
        }

        private void bgHilo2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string value = (string)e.UserState;
            lblParImp.Text = value;
        }

        private void bgHilo2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                lblInfo.Text = "Cancelado";
            }
            else
            {
                lblInfo.Text = "Terminado";
            }
        }
    }
}
