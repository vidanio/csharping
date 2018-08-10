using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dibujar
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnDibuja_Click(object sender, EventArgs e)
        {
            Invalidate(); // redibuja toda la ventana
        }

        // se ejecuta cada vez q se redibuja la ventana
        private void pictBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.PageUnit = GraphicsUnit.Pixel; // medida por pixels
                                             // Creamos un Bitmap donde dibujar puntos
            using (Bitmap bm = new Bitmap(pictBox.Width, pictBox.Height))
            {
                bm.SetPixel(5, 5, Color.Red);
                bm.SetPixel(pictBox.Width - 6, pictBox.Height - 6, Color.Red);
                // dibujamos el Bitmap creado
                g.DrawImage(bm, 0, 0);
                // dibujamos una elipse
                g.DrawEllipse(Pens.Green, 0, 0, pictBox.Width - 1, pictBox.Height - 1);
            }
        }
    }
}
