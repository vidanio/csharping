using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace EQF2EDJ
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // convert EQF hex code from offset 288+0 to 288+9, to EDJ Gain Level in dB
        public string eqf2edjLevel(byte hex)
        {
            string res = "";
            int num = (int)hex;

            if (num == 31)
            {
                res = "0.000000";
            }
            else
            {
                res = string.Format("{0}", ((32 - num) * 0.375).ToString("F6", CultureInfo.InvariantCulture));
            }

            return res;
        }
    }
}
