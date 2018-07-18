/*
Este es un ejemplo donde hemos querido mostrar el uso de una BBDD SQLite a la vez que un formulario con un DataGridView en modo ReadOnly
Con botones para crear un CRUD completo, donde se pueden insertar nuevos datos, actualizar los viejos, borrarlos o buscarlos mediante un
criterio alfabético de búsqueda. Asímismo hemos mostrado como validar un campo de texto que recoger números decimales en coma flotante.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace database
{
    public partial class MainForm : Form
    {
        private int rowselected = -1;
        private double precio = 0.0;
        // valor que advierte de registro en edición (update)
        private bool selected = false; // false = (modo insert), true = (modo update)
        SQLiteConnection conn;

        public MainForm()
        {
            InitializeComponent();

            conn = new SQLiteConnection("Data Source=productos.sqlite;Version=3;");
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
                // sitio donde hacer un INSERT o UPDATE (añadir/actualizar)

                // añadimos una columna antes de introducir los datos, recibimos el numero de la columna nuevo
                int n = rowselected;
                if (!selected) n = dtgvProductos.Rows.Add();
                // colocamos la información nueva en ese sitio
                dtgvProductos.Rows[n].Cells[0].Value = txtCodigo.Text;
                dtgvProductos.Rows[n].Cells[1].Value = txtNombre.Text;
                dtgvProductos.Rows[n].Cells[2].Value = precio; // ha sido validado
                // Limpiamos los textboxes
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtPrecio.Text = "";
                if (selected)
                {
                    lblInfo.Text = "Fila actualizada";
                    btnAdd.Text = "Añadir";
                    selected = false;
                }
                else
                {
                    lblInfo.Text = "Fila añadida";
                }
            }
            else
            {
                lblInfo.Text = "Todos los campos requieren un valor";
                if (selected) btnAdd.Text = "Añadir";
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
                btnAdd.Text = "Añadir";
                selected = false;
                // sitio donde hacer un DELETE y recargar la base de datos de nuevo en el DataGridView
            }
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            // sitio donde cargar la base de datos completa SELECT * from TABLE
            conn.Open();            
            lblInfo.Text = "Base de datos SQLite status = " + conn.State.ToString();
            string query = "SELECT * from Productos;";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            SQLiteDataReader datos = cmd.ExecuteReader();
            while (datos.Read())
            {
                // los leemos todos como strings completos
                string codigo = datos.GetString(0); 
                string nombre = datos.GetString(1);
                string price = datos.GetString(2);
                int n = dtgvProductos.Rows.Add();
                // convertimos los que hagan falta desde string a lo que sea
                dtgvProductos.Rows[n].Cells[0].Value = codigo;
                dtgvProductos.Rows[n].Cells[1].Value = nombre;
                dtgvProductos.Rows[n].Cells[2].Value = Convert.ToDouble(price);
            }
        }

        private void dtgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if ((n != -1) && (dtgvProductos.Rows.Count > 1))
            {
                lblInfo.Text = string.Format("Fila {0} seleccionada Rows = {1}", n, dtgvProductos.Rows.Count);
                // rellenamos valores 
                try
                {
                    txtCodigo.Text = dtgvProductos.Rows[n].Cells[0].Value.ToString();
                    txtNombre.Text = dtgvProductos.Rows[n].Cells[1].Value.ToString();
                    txtPrecio.Text = dtgvProductos.Rows[n].Cells[2].Value.ToString();
                }
                catch
                {
                    txtCodigo.Text = "";
                    txtNombre.Text = "";
                    txtPrecio.Text = "";
                }
                rowselected = n;
                selected = true;
                btnAdd.Text = "Actualizar";
                try
                {
                    precio = Convert.ToDouble(txtPrecio.Text);
                }
                catch
                {
                    precio = 0;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // sitio del SELECT
        }

        private void txtPrecio_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                precio = Convert.ToDouble(txtPrecio.Text.Replace('.', ','));
                txtPrecio.Text = precio.ToString();
            }
            catch
            {
                txtPrecio.Text = "";
                lblInfo.Text = "Valor de Precio no válido";
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
            conn.Dispose();
        }
    }
}
