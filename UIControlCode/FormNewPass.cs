using System;
using System.Windows.Forms;

namespace UIControlCode
{
    public partial class FormNewPass : Form
    {
        public string LoginPass { get; set; } = "";
        private bool cancelled = false;

        public FormNewPass()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            LoginPass = txtPass.Text;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancelled = true;
            this.Close();
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '@') && (e.KeyChar != '.');
        }

        private void FormNewPass_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cancelled)
            {
                e.Cancel = false;
                return;
            }

            if (string.IsNullOrWhiteSpace(LoginPass))
            {
                MessageBox.Show("Todos los campos de texto son obligatorios", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cancelled = false;
                e.Cancel = true;
            }
        }
    }
}
