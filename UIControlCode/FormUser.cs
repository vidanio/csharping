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
    public partial class FormUser : Form
    {
        public string UserMail { get; set; } = "";
        public string UserPass { get; set; } = "";
        public string UserName { get; set; } = "";
        public bool UserActive { get; set; } = false;

        public FormUser()
        {
            InitializeComponent();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            txtMail.Text = UserMail;
            txtPass.Text = UserPass;
            txtName.Text = UserName;
            chkActive.Checked = UserActive;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            UserMail = txtMail.Text;
            UserPass = txtPass.Text;
            UserName = txtName.Text;
            UserActive = chkActive.Checked;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
