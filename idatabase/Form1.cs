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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblInfo.Text = "";
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
                    addItem(id, user, pass);
                }
                connection.Close();
            }
        }
        //Boton de (Añadir/Actualizar)
        private void btnAnadir_Click(object sender, EventArgs e)
        {
            int res = 0;
            //Se añaden nuevos datos
            if (btnAnadir.Text == "Añadir")
            {
                if ((txtID.Text != "") && (txtUser.Text != "") && (txtPass.Text != ""))
                {
                    try
                    {
                        using (connection = new SQLiteConnection(string_connection))
                        {
                            connection.Open();
                            string query = string.Format("INSERT INTO usuarios VALUES ({0},'{1}','{2}');", txtID.Text, txtUser.Text, txtPass.Text);
                            SQLiteCommand cmd_exc = new SQLiteCommand(query, connection);
                            res = cmd_exc.ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                    catch
                    {
                        lblInfo.ForeColor = Color.Red;
                        lblInfo.Text = "Fallo al añadir usuario";
                    }
                    if (res > 0)
                    {
                        txtID.Text = "";
                        txtUser.Text = "";
                        txtPass.Text = "";
                        MiTabla.Items.Clear();
                        lblInfo.ForeColor = Color.Green;
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
                    try
                    {
                        using (connection = new SQLiteConnection(string_connection))
                        {
                            if (MiTabla.Items.Count > 0)
                            {
                                foreach (ListViewItem item in MiTabla.SelectedItems)
                                {
                                    connection.Open();
                                    string query = string.Format("SELECT * FROM usuarios WHERE id = {0};", item.Text);
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
                            }
                        }
                    }
                    catch
                    {
                        lblInfo.ForeColor = Color.Red;
                        lblInfo.Text = "Fallo al actualizar usuario";
                    }
                    if (res > 0)
                    {
                        txtID.Text = "";
                        txtUser.Text = "";
                        txtPass.Text = "";
                        MiTabla.Items.Clear();
                        lblInfo.ForeColor = Color.Green;
                        lblInfo.Text = "Usuario Modificado";
                        loadData();
                        btnAnadir.BackColor = Color.LightGreen;
                        btnAnadir.Text = "Añadir";
                    }
                }
            }
        }

        //Borrar un item de base de datos
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int res = 0;
            try
            {
                using (connection = new SQLiteConnection(string_connection))
                {
                    if (MiTabla.Items.Count > 0)
                    {
                        foreach (ListViewItem item in MiTabla.SelectedItems)
                        {
                            connection.Open();
                            string query = string.Format("DELETE FROM usuarios WHERE id = {0};", item.Text);
                            SQLiteCommand cmd = new SQLiteCommand(query, connection);
                            res = cmd.ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                }
            }
            catch
            {
                lblInfo.ForeColor = Color.Red;
                lblInfo.Text = "Fallo al borrar usuario";
            }
            if (res > 0)
            {
                txtID.Text = "";
                txtUser.Text = "";
                txtPass.Text = "";
                MiTabla.Items.Clear();
                lblInfo.ForeColor = Color.Green;
                lblInfo.Text = "Usuario Borrado";
                loadData();
                btnAnadir.Text = "Añadir";
                btnAnadir.BackColor = Color.LightGreen;
            }
        }
        //Cuando cambiamos de elemento en la Lista
        private void MiTabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            if (MiTabla.Items.Count > 0)
            {
                foreach (ListViewItem item in MiTabla.SelectedItems)
                {
                    txtID.Text = item.Text;
                    txtUser.Text = item.SubItems[1].Text;
                    txtPass.Text = item.SubItems[2].Text;
                }
                btnAnadir.BackColor = Color.LightSkyBlue;
                btnAnadir.Text = "Actualizar";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "")
            {
                try
                {
                    MiTabla.Items.Clear();
                    using (connection = new SQLiteConnection(string_connection))
                    {
                        connection.Open();
                        string query = string.Format("SELECT * FROM usuarios WHERE user = '{0}';", txtUser.Text.Trim(' '));
                        SQLiteCommand cmd = new SQLiteCommand(query, connection);
                        SQLiteDataReader datos2 = cmd.ExecuteReader();
                        while (datos2.Read())
                        {
                            int id = datos2.GetInt32(datos2.GetOrdinal("id"));
                            string user = datos2.GetString(datos2.GetOrdinal("user"));
                            string pass = datos2.GetString(datos2.GetOrdinal("pass"));
                            addItem(id, user, pass);
                        }
                    }
                }
                catch
                {
                    lblInfo.ForeColor = Color.Red;
                    lblInfo.Text = "Fallo en la busqueda";
                }
            }
            else
            {
                try
                {
                    MiTabla.Items.Clear();
                    using (connection = new SQLiteConnection(string_connection))
                    {
                        connection.Open();
                        string query = string.Format("SELECT * FROM usuarios;");
                        SQLiteCommand cmd = new SQLiteCommand(query, connection);
                        SQLiteDataReader datos2 = cmd.ExecuteReader();
                        while (datos2.Read())
                        {
                            int id = datos2.GetInt32(datos2.GetOrdinal("id"));
                            string user = datos2.GetString(datos2.GetOrdinal("user"));
                            string pass = datos2.GetString(datos2.GetOrdinal("pass"));
                            addItem(id, user, pass);
                        }
                    }
                }
                catch
                {
                    lblInfo.ForeColor = Color.Red;
                    lblInfo.Text = "Fallo en la busqueda";
                }
            }
            
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            txtID.Text = "";
            txtUser.Text = "";
            txtPass.Text = "";
            MiTabla.Items.Clear();
            btnAnadir.Text = "Añadir";
            btnAnadir.BackColor = Color.LightGreen;
        }
        //Añade los datos en el List View
        private void addItem(int id, string user, string pass)
        {
            ListViewItem items = new ListViewItem(Convert.ToString(id));
            items.SubItems.Add(user);
            items.SubItems.Add(pass);
            MiTabla.Items.Add(items);
        }
    }
}
