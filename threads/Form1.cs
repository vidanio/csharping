/*
 Puesto que el uso de hilos hace que acceder a datos no creados por el hilo hijo complique mucho el código (esto no es Go)
 hemos hecho lo mismo pero usando 9 controles Timer de WinForms que permiten hacerlo de manera sencilla. Como los Timers disparan sus eventos
 desde un Scheduler que funciona sobre un solo Hilo de procesador, es Thread Safe y no requiere de uso de Mutex nunca para acceder a recursos
 compartidos, lo que facilita mucho la programación que nosotros necesitamos en Windows.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace threads
{
    public partial class MainForm : Form
    {
        private int counter = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = string.Format("Timer1: {0}", ++counter);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = string.Format("Timer2: {0}", ++counter);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label3.Text = string.Format("Timer3: {0}", ++counter);
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            label4.Text = string.Format("Timer4: {0}", ++counter);
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            label5.Text = string.Format("Timer5: {0}", ++counter);
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            label6.Text = string.Format("Timer6: {0}", ++counter);
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            label7.Text = string.Format("Timer7: {0}", ++counter);
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            label8.Text = string.Format("Timer8: {0}", ++counter);
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            label9.Text = string.Format("Timer9: {0}", ++counter);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            timer1.Enabled = true; //Thread.Sleep(100);
            timer2.Enabled = true; //Thread.Sleep(100);
            timer3.Enabled = true; //Thread.Sleep(100);
            timer4.Enabled = true; //Thread.Sleep(100);
            timer5.Enabled = true; //Thread.Sleep(100);
            timer6.Enabled = true; //Thread.Sleep(100);
            timer7.Enabled = true; //Thread.Sleep(100);
            timer8.Enabled = true; //Thread.Sleep(100);
            timer9.Enabled = true; //Thread.Sleep(100);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false; timer1.Dispose();
            timer2.Enabled = false; timer2.Dispose();
            timer3.Enabled = false; timer3.Dispose();
            timer4.Enabled = false; timer4.Dispose();
            timer5.Enabled = false; timer5.Dispose();
            timer6.Enabled = false; timer6.Dispose();
            timer7.Enabled = false; timer7.Dispose();
            timer8.Enabled = false; timer8.Dispose();
            timer9.Enabled = false; timer9.Dispose();
        }
    }
}
