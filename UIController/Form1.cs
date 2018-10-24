using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace UIController
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Label mylabel = (Label)this.GetControlByName(panelListAdmins, "label4");
            mylabel.Text = "VidaRTV";
            mylabel = (Label)this.GetControlByName(panelListAdmins, "label12");
            mylabel.Text = "Ondaluz";
        }

        public Control GetControlByName(Control ParentCntl, string NameToSearch)
        {
            foreach (Control ChildCntl in ParentCntl.Controls)
            {
                if (ChildCntl.Name == NameToSearch) return ChildCntl;
            }
            return null;
        }

        private void cboxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
