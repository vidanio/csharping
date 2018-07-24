/*
Este es un ejemplo donde hemos querido mostrar el uso de una BBDD SQLite a la vez que un formulario con un DataGridView en modo ReadOnly
Con botones para crear un CRUD completo, donde se pueden insertar nuevos datos, actualizar los viejos, borrarlos o buscarlos mediante un
criterio alfabético de búsqueda. 
Debido a que la conversion de REAL SQLite a Double C#, solo funciona cuando el valor esta guardado en formato en-US con el '.' como separador decimal,
en el Load del Form, antes de nada hemos definido las reglas de Globalización Cultural del hilo principal del programa con esta salvedad, de manera 
que ya no hay problemas al usar la linea#181 ni que el contenido en el DataGrid use el separado del sistema operativo local
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
using System.Globalization;
using System.Threading;

namespace database
{
    public partial class MainForm : Form
    {
        private int rowselected = -1;
        private double precio = 0.0;
        // valor que advierte de registro en edición (update)
        private bool selected = false; // false = (modo insert), true = (modo update)
        private SQLiteConnection conn;
        private string connString = "Data Source=productos.sqlite;Version=3;";

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
                string query = "";
                // sitio donde hacer un INSERT o UPDATE (añadir/actualizar)
                if (selected)
                {
                    query = string.Format("update Productos set Codigo = '{0}', Nombre = '{1}', Precio = '{2}' where Codigo = '{3}';",
                        txtCodigo.Text, txtNombre.Text, txtPrecio.Text, dtgvProductos.Rows[rowselected].Cells[0].Value.ToString());
                }
                else
                {
                    query = string.Format("INSERT into Productos values ('{0}','{1}','{2}');", txtCodigo.Text, txtNombre.Text, txtPrecio.Text);
                }
                try
                {
                    using (conn = new SQLiteConnection(connString))
                    {
                        conn.Open();
                        SQLiteCommand cmd = new SQLiteCommand(query, conn);
                        int res = cmd.ExecuteNonQuery();
                        if (res > 0) // ha entrado en la BBDD, vamos a ponerlo en el DataGrid
                        {
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
                        //conn.Close();
                    }
                }
                catch
                {
                    lblInfo.Text = "Fallo en el intento de escritura de la BBDD";
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
                    // se ha ejecutado en el Datagrid ahora vamos a hacerlo en la base de datos
                    string query = string.Format("DELETE from Productos where Codigo = '{0}';", txtCodigo.Text);
                    using (conn = new SQLiteConnection(connString))
                    {
                        conn.Open();
                        SQLiteCommand cmd = new SQLiteCommand(query, conn);
                        int res = cmd.ExecuteNonQuery();
                        if (res < 1)
                        {
                            lblInfo.Text = "Esta fila no se ha borrado de la BBDD";
                            loadAllSQLiteOnDataGrid();
                        }
                        //conn.Close();
                    }
                }
                catch
                {
                    lblInfo.Text = "No se puedo borrar esta fila";
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
            //Definimos como carácter de separación entero-decimal con el punto (para evitar problemas con SQLite REAL)
            CultureInfo cultureCA = CultureInfo.CreateSpecificCulture("en-US");
            NumberFormatInfo numberFormat = cultureCA.NumberFormat;
            numberFormat.CurrencyGroupSeparator = ","; // separador de miles
            numberFormat.CurrencyDecimalSeparator = "."; // separador de decimales
            Thread.CurrentThread.CurrentCulture = cultureCA; // activamos la cultura en-US en este hilo

            lblInfo.Text = "";
            // sitio donde cargar la base de datos completa SELECT * from TABLE
            try
            {
                using (conn = new SQLiteConnection(connString))
                {
                    conn.Open();
                    lblInfo.Text = "Base de datos SQLite status = " + conn.State.ToString();
                    loadAllSQLiteOnDataGrid();
                    //conn.Close();
                }
            }
            catch
            {
                lblInfo.Text = "Hubo un error grave en la BBDD";
            }
        }

        private void loadAllSQLiteOnDataGrid()
        {
            dtgvProductos.Rows.Clear();
            dtgvProductos.Update();
            dtgvProductos.Refresh();

            string query = "SELECT * from Productos;";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            SQLiteDataReader datos = cmd.ExecuteReader();
            while (datos.Read())
            {
                // los leemos todos como strings completos
                string codigo = datos.GetString(datos.GetOrdinal("Codigo"));
                string nombre = datos.GetString(datos.GetOrdinal("Nombre"));
                double price = datos.GetDouble(datos.GetOrdinal("Precio"));
                int n = dtgvProductos.Rows.Add();
                // convertimos los que hagan falta desde string a lo que sea
                dtgvProductos.Rows[n].Cells[0].Value = codigo;
                dtgvProductos.Rows[n].Cells[1].Value = nombre;
                dtgvProductos.Rows[n].Cells[2].Value = price;
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
            // vaciamos el DataGrid y redibujamos sus controles
            dtgvProductos.Rows.Clear();
            dtgvProductos.Update();
            dtgvProductos.Refresh();
            btnAdd.Text = "Añadir";
            selected = false;

            string query = "SELECT * from Productos;";
            // sitio del SELECT
            if (txtNombre.Text != "")
            {
                query = string.Format("SELECT * from Productos where Nombre LIKE '{0}%';", txtNombre.Text.Trim(' '));
            }

            try
            {
                using (conn = new SQLiteConnection(connString))
                {
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    SQLiteDataReader datos = cmd.ExecuteReader();
                    while (datos.Read())
                    {
                        // los leemos todos como strings completos
                        string codigo = datos.GetString(datos.GetOrdinal("Codigo"));
                        string nombre = datos.GetString(datos.GetOrdinal("Nombre"));
                        double price = datos.GetDouble(datos.GetOrdinal("Precio"));
                        int n = dtgvProductos.Rows.Add();
                        // convertimos los que hagan falta desde string a lo que sea
                        dtgvProductos.Rows[n].Cells[0].Value = codigo;
                        dtgvProductos.Rows[n].Cells[1].Value = nombre;
                        dtgvProductos.Rows[n].Cells[2].Value = price;
                    }
                    //conn.Close();
                }
            }
            catch
            {
                lblInfo.Text = "Error en el acceso a la BBDD";
            }
        }

        private void txtPrecio_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                precio = Convert.ToDouble(txtPrecio.Text.Replace(',', '.'));
                txtPrecio.Text = precio.ToString();
            }
            catch
            {
                txtPrecio.Text = "";
                lblInfo.Text = "Valor de Precio no válido";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dtgvProductos.Rows.Clear();
            dtgvProductos.Update();
            dtgvProductos.Refresh();
        }
    }
}
