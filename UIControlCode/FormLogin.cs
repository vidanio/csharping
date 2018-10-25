using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIControlCode
{
    public partial class FormLogin : Form
    {
        public string LoginMail { get; set; } = "";
        public string LoginPass { get; set; } = "";


        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            LoginMail = txtMail.Text;
            LoginPass = txtPass.Text;
            this.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtMail.Text = LoginMail;
            txtPass.Text = LoginPass;
        }
    }
}
