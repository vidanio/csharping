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
        private Mutex mu;

        public Form1()
        {
            InitializeComponent();

            mu = new Mutex();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblEstado.Text = "";
            lblInfo.Text = "";
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!bgHilo1.IsBusy)
            {
                lblInfo.Text = "";
                bgHilo1.RunWorkerAsync(0);
            }
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            if (bgHilo1.IsBusy)
            {
                bgHilo1.CancelAsync();
            }
        }

        private void bgHilo1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bg = sender as BackgroundWorker;
            SpinWait sw = new SpinWait();
            int value = 0;

            for (int i = 0; i < 1000000; i++)
            {
                if (bg.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                value++;
                bg.ReportProgress(0, value);
                sw.SpinOnce();
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
    }
}
