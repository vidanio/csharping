using System;
using System.Windows.Forms;

namespace UIControlCode
{
    public partial class FormUser : Form
    {
        public string UserMail { get; set; } = "";
        public string UserPass { get; set; } = "";
        public string UserName { get; set; } = "";
        public bool UserActive { get; set; } = false;
        private bool cancelled = false;

        public FormUser()
        {
            InitializeComponent();
        }

        public void Reset()
        {
            UserMail = "";
            UserPass = "";
            UserName = "";
            UserActive = false;
        }

        public void LoadData(string mail, string pass, string name, bool active)
        {
            UserMail = mail;
            UserPass = pass;
            UserName = name;
            UserActive = active;
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
            cancelled = true;
            this.Close();
        }

        private void txtMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '@') && (e.KeyChar != '.');
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '@') && (e.KeyChar != '.');
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '@') && (e.KeyChar != '.');
        }

        private void FormUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cancelled)
            {
                cancelled = false;
                e.Cancel = false;
                return;
            }

            if (string.IsNullOrWhiteSpace(UserMail) || string.IsNullOrWhiteSpace(UserPass) || string.IsNullOrWhiteSpace(UserName))
            {
                MessageBox.Show("Todos los campos de texto son obligatorios", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cancelled = false;
                e.Cancel = true;
            }
        }
    }
}
