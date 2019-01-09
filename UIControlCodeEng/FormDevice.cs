using System;
using System.Windows.Forms;

namespace UIControlCode
{
    public partial class FormDevice : Form
    {
        public string DeviceName { get; set; } = "";
        public bool DeviceActive { get; set; } = false;
        private bool cancelled = false;

        public FormDevice()
        {
            InitializeComponent();
        }

        public void Reset()
        {
            DeviceName = "";
            DeviceActive = false;
        }

        public void LoadData(string name, bool active)
        {
            DeviceName = name;
            DeviceActive = active;
        }

        private void FormDevice_Load(object sender, EventArgs e)
        {
            txtName.Text = DeviceName;
            chkActive.Checked = DeviceActive;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DeviceName = txtName.Text;
            DeviceActive = chkActive.Checked;

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancelled = true;
            this.Close();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '@') && (e.KeyChar != '.');
        }

        private void FormDevice_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cancelled)
            {
                cancelled = false;
                e.Cancel = false;
                return;
            }

            if (string.IsNullOrWhiteSpace(DeviceName))
            {
                MessageBox.Show("All text fields are required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cancelled = false;
                e.Cancel = true;
            }
        }
    }
}
