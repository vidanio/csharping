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
                    if (sum == "admin_mon")
                    {
                        // on line: TodoStreaming;2018-10-09;512;25316
                        // on grid: User ; GBytes ; Hours

                    }
                    else if (sum == "user_mon")
                    {
                        // on line: TodoStreaming;2018-10-09;512;25316
                        // on grid: Month ; GBytes ; Hours

                    }
                    else if (sum == "user_day")
                    {
                        // on line: TodoStreaming;2018-10-09;254256;954220
                        // on grid: Day ; MBytes ; Minutes

                    }
                    else // user_now
                    {
                        // on line: Linux89;8500;95;2;1 
                        // on grid: Decoder ; Kbps ; Minutes ; Mbytes
                    }

                }
                else break;
            }

        }
    }
}
/*
 * TodoStreaming;2018-10-09;512;25316
   Vidanio;2018-10-10;401;3704
 * 
            test = "TodoStreaming;2018-10-09;254256;954220\r\n";
            test += "TodoStreaming;2018-10-10;256001;564489\r\n";
            test += "TodoStreaming;2018-10-22;1384;219\r\n";
 *  */
