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
        private bool paint = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnDibuja_Click(object sender, EventArgs e)
        {
            paint = true;
            pictBox.Invalidate(); // redibuja el control pictBox
        }

        // se ejecuta cada vez q se redibuja la ventana
        private void pictBox_Paint(object sender, PaintEventArgs e)
        {
            // evitamos que se dibuje antes de pulsar el boton Dibuja
            if (paint)
            {
                Graphics g = e.Graphics;
                g.PageUnit = GraphicsUnit.Pixel; // medida por pixels
                // usa TranslateTransform, RotateTransform y ScaleTransform para cambiar origen y ejes de coordenadas
                // Creamos un Bitmap donde dibujar puntos
                using (Bitmap bm = new Bitmap(pictBox.Width, pictBox.Height))
                {
                    bm.SetPixel(5, 5, Color.Red);
                    bm.SetPixel(pictBox.Width - 6, pictBox.Height - 6, Color.Red);
                    // dibujamos el Bitmap creado
                    g.DrawImage(bm, 0, 0);
                    // dibujamos una elipse
                    g.DrawEllipse(Pens.Green, 0, 0, pictBox.Width - 1, pictBox.Height - 1);
                    g.DrawLine(Pens.Black, 0, pictBox.Height - 1, pictBox.Width - 1, 0);
                }
            }
        }
    }
}
