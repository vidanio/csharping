using System;
using System.Windows.Forms;

namespace UIControlCode
{
    public partial class FormLogin : Form
    {
        public int LoginServer { get; set; } = 1;
        public string LoginMail { get; set; } = "";
        public string LoginPass { get; set; } = "";
        private bool cancelled = false;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancelled = true;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            LoginServer = (int)numServer.Value;
            LoginMail = txtMail.Text;
            LoginPass = txtPass.Text;
            this.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            numServer.Value = LoginServer;
            txtMail.Text = LoginMail;
            txtPass.Text = LoginPass;
        }

        private void txtMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '@') && (e.KeyChar != '.');
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '@') && (e.KeyChar != '.');
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cancelled)
            {
                e.Cancel = false;
                return;
            }

            if (string.IsNullOrWhiteSpace(LoginMail) || string.IsNullOrWhiteSpace(LoginPass))
            {
                MessageBox.Show("Todos los campos de texto son obligatorios", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cancelled = false;
                e.Cancel = true;
            }
        }
    }
}
