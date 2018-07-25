using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace idatabase
{
    public partial class Form1 : Form
    {
        SQLiteConnection connection;
        private string string_connection = @"Data Source=shop.db; Version=3;";
        private string[] seleccionado;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }
        //Contiene los datos actuales en BD
        private void loadData()
        {
            using (connection = new SQLiteConnection(string_connection))
            {
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM usuarios", connection);
                SQLiteDataReader datos = cmd.ExecuteReader();
                while (datos.Read())
                {
                    // los leemos todos como strings completos
                    int id = datos.GetInt32(datos.GetOrdinal("id"));
                    string user = datos.GetString(datos.GetOrdinal("user"));
                    string pass = datos.GetString(datos.GetOrdinal("pass"));
                    userContainer.Items.Add(string.Format("{0}-{1}-{2}", id, user, pass));
                }
                connection.Close();
            }
        }
        //Boton de (Añadir/Actualizar)
        private void btnAnadir_Click(object sender, EventArgs e)
        {
            //Se añaden nuevos datos
            if (btnAnadir.Text == "Añadir")
            {
                if ((txtID.Text != "") && (txtUser.Text != "") && (txtPass.Text != ""))
                {
                    string query = "";
                    int res = 0;
                    using (connection = new SQLiteConnection(string_connection))
                    {
                        connection.Open();
                        SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM usuarios", connection);
                        SQLiteDataReader datos2 = cmd.ExecuteReader();
                        while (datos2.Read())
                        {
                            int id = datos2.GetInt32(datos2.GetOrdinal("id"));
                            string user = datos2.GetString(datos2.GetOrdinal("user"));
                            string pass = datos2.GetString(datos2.GetOrdinal("pass"));
                            query = string.Format("INSERT INTO usuarios VALUES ('{0}','{1}','{2}');", txtID.Text, txtUser.Text, txtPass.Text);
                            try
                            {
                                SQLiteCommand cmd_exc = new SQLiteCommand(query, connection);
                                res = cmd_exc.ExecuteNonQuery();
                            }
                            catch
                            {
                                lblInfo.Text = "El ID o el Usuario ya existen";
                            }
                        }
                        connection.Close();
                    }
                    if (res > 0)
                    {
                        txtID.Text = "";
                        txtUser.Text = "";
                        txtPass.Text = "";
                        userContainer.Items.Clear();
                        lblInfo.Text = "Usuario Añadido";
                        loadData();
                    }
                }
            }
            //Actualizamos los datos existentes
            if (btnAnadir.Text == "Actualizar")
            {
                if ((txtID.Text != "") && (txtUser.Text != "") && (txtPass.Text != ""))
                {
                    int res = 0;
                    using (connection = new SQLiteConnection(string_connection))
                    {
                        connection.Open();
                        string query = string.Format("SELECT * FROM usuarios WHERE id = {0};", seleccionado[0]);
                        SQLiteCommand cmd = new SQLiteCommand(query, connection);
                        SQLiteDataReader datos2 = cmd.ExecuteReader();
                        while (datos2.Read())
                        {
                            int id = datos2.GetInt32(datos2.GetOrdinal("id"));
                            string user = datos2.GetString(datos2.GetOrdinal("user"));
                            string pass = datos2.GetString(datos2.GetOrdinal("pass"));
                            if (id != Convert.ToInt32(txtID.Text) || (user != txtUser.Text) || (pass != txtPass.Text))
                            {
                                query = string.Format("UPDATE usuarios SET id = '{0}', user = '{1}', pass = '{2}' WHERE id = {3};",
                                txtID.Text, txtUser.Text, txtPass.Text, id);
                                SQLiteCommand cmd2 = new SQLiteCommand(query, connection);
                                res = cmd2.ExecuteNonQuery();
                            }
                        }
                        connection.Close();
                    }
                    if (res > 0)
                    {
                        txtID.Text = "";
                        txtUser.Text = "";
                        txtPass.Text = "";
                        userContainer.Items.Clear();
                        lblInfo.Text = "Usuario Modificado";
                        loadData();
                        btnAnadir.Text = "Añadir";
                        btnAnadir.BackColor = Color.LightGreen;
                    }
                }
            }
        }
        //Cuando seleccionamos entre los distintos items del listado
        private void userContainer_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            string resultado = userContainer.SelectedItem.ToString();
            seleccionado = resultado.Split('-');
            txtID.Text = seleccionado[0];
            txtUser.Text = seleccionado[1];
            txtPass.Text = seleccionado[2];
            btnAnadir.Text = "Actualizar";
            btnAnadir.BackColor = Color.LightSkyBlue;
        }
        //Borrar un item de base de datos
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int res = 0;
            try
            {
                using (connection = new SQLiteConnection(string_connection))
                {
                    connection.Open();
                    string query = string.Format("DELETE FROM usuarios WHERE id = {0};", seleccionado[0]);
                    SQLiteCommand cmd = new SQLiteCommand(query, connection);
                    res = cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch
            {
                lblInfo.Text = "Fallo al borrar usuario";
            }
            if (res > 0)
            {
                txtID.Text = "";
                txtUser.Text = "";
                txtPass.Text = "";
                userContainer.Items.Clear();
                lblInfo.Text = "Usuario Borrado";
                loadData();
                btnAnadir.Text = "Añadir";
                btnAnadir.BackColor = Color.LightGreen;
            }
        }
    }
}
