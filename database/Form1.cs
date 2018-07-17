using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace database
{
    public partial class MainForm : Form
    {
        private int rowselected = -1;

        public MainForm()
        {
            InitializeComponent();
        }

        // Cambia los Enter dentro del Form en TABs (mirar nuevo orden de tabulación y TabStop property
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter) SendKeys.Send("{TAB}");
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((txtCodigo.Text != "") && (txtNombre.Text != "") && (txtPrecio.Text != ""))
            {
                // añadimos una columna antes de introducir los datos, recibimos el numero de la columna nuevo
                int n = dtgvProductos.Rows.Add();
                // colocamos la información nueva en ese sitio
                dtgvProductos.Rows[n].Cells[0].Value = txtCodigo.Text;
                dtgvProductos.Rows[n].Cells[1].Value = txtNombre.Text;
                dtgvProductos.Rows[n].Cells[2].Value = txtPrecio.Text;
                // Limpiamos los textboxes
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtPrecio.Text = "";
                lblInfo.Text = "Fila añadida";
            }
            else
            {
                lblInfo.Text = "Todos los campos requieren un valor";
            }


        }

        private void dtgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                lblInfo.Text = string.Format("Fila {0} seleccionada", n);
                // rellenamos valores 
                txtCodigo.Text = (string)dtgvProductos.Rows[n].Cells[0].Value;
                txtNombre.Text = (string)dtgvProductos.Rows[n].Cells[1].Value;
                txtPrecio.Text = (string)dtgvProductos.Rows[n].Cells[2].Value;
                rowselected = n;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (rowselected != -1)
            {
                try
                {
                    dtgvProductos.Rows.RemoveAt(rowselected);
                }
                catch
                {
                    lblInfo.Text = "Esta fila no se puede borrar";
                }
            }
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblInfo.Text = "";
        }

        private void dtgvProductos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            lblInfo.Text = string.Format("Cambio Fila = {0}, Columna = {1} [{2},{3}]", e.RowIndex, e.ColumnIndex, dtgvProductos.Columns.Count, dtgvProductos.Rows.Count);
        }
    }
}
