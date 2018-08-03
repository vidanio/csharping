using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace TestDelegadoEvento
{
    public partial class MainForm : Form
    {
        private Proceso proceso;

        public MainForm()
        {
            InitializeComponent();

            proceso = new Proceso();
            // nos suscribimos al evento Finished para hacer cosas cuando ocurra
            proceso.Finished += Proceso_Finished;
        }

        private void Proceso_Finished(object sender, ProcesoFinishedEventArgs e)
        {
            lblResult.Text = e.Result.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblResult.Text = "(calculando ...)";
            proceso.Run(Convert.ToInt32(txtArg.Text));
        }
    }
}
