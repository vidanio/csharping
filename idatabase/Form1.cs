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
        public Form1()
        {
            string rutaSQL = Properties.Resources.rutaSQL;
            string connectionString = @"Data Source="+ rutaSQL + "; Version=3; FailIfMissing=True; Foreign Keys=True;";

            InitializeComponent();

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM usuarios";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                userContainer.Items.Add(reader["user"].ToString() + " - " + reader["pass"].ToString());
                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch (SQLiteException e)
            {
                MessageBox.Show("Fatal Error", "Reason: " + e.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
