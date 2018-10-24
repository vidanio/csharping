using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System;

namespace UIControlCode
{
    public partial class MainForm : Form
    {
        // draws a datagridview empty table with headers titles
        private DataGridView DrawDataGridView(string[] colheaders, Size size, Point location, string name)
        {
            DataGridView dgv = new DataGridView();

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            foreach (string col in colheaders)
            {
                dgv.Columns.Add(col, col);
            }
            dgv.Location = location;
            dgv.Size = size;
            dgv.Name = name;
            dgv.ReadOnly = true;

            return dgv;
        }

        // sum (admin_mon, user_mon, user_day, user_now)
        private void LoadStatsOnDGV(DataGridView dgv, string csv, string sum)
        {
            StringReader strReader = new StringReader(csv);

            while (true)
            {
                string line = strReader.ReadLine();
                if (line != null)
                {
                    var words = line.Split(';');
                    int n = dgv.Rows.Add(); // add a row for this line

                    if (sum == "admin_mon")
                    {
                        // on line: TodoStreaming;2018-10-09;512;25316
                        // on grid: User ; GBytes ; Hours
                        dgv.Rows[n].Cells[0].Value = words[0];
                        dgv.Rows[n].Cells[1].Value = words[2];
                        dgv.Rows[n].Cells[2].Value = words[3];
                    }
                    else if (sum == "user_mon")
                    {
                        // on line: TodoStreaming;2018-10-09;512;25316
                        // on grid: Month ; GBytes ; Hours
                        var items = words[1].Split('-');
                        dgv.Rows[n].Cells[0].Value = items[1]; // month number
                        dgv.Rows[n].Cells[1].Value = words[2];
                        dgv.Rows[n].Cells[2].Value = words[3];
                    }
                    else if (sum == "user_day")
                    {
                        // on line: TodoStreaming;2018-10-09;254256;954220
                        // on grid: Day ; MBytes ; Minutes
                        var items = words[1].Split('-');
                        dgv.Rows[n].Cells[0].Value = items[2]; // day number (01-31)
                        dgv.Rows[n].Cells[1].Value = words[2];
                        dgv.Rows[n].Cells[2].Value = words[3];
                    }
                    else // user_now
                    {
                        // on line: Linux89;8500;95;2;1 
                        // on grid: Decoder ; Kbps ; Minutes ; Mbytes
                        dgv.Rows[n].Cells[0].Value = words[0];
                        dgv.Rows[n].Cells[1].Value = words[1];
                        dgv.Rows[n].Cells[2].Value = words[2];
                        dgv.Rows[n].Cells[3].Value = words[3];
                    }

                }
                else break;
            }

        }
    }
}
