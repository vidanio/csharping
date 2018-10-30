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
    public partial class FormDevice : Form
    {
        public string DeviceName { get; set; } = "";
        public bool DeviceActive { get; set; } = false;

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
            this.Close();
        }
    }
}
