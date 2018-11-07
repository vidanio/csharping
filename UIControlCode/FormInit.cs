using System;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace UIControlCode
{
    public partial class FormInit : Form
    {
        public FormInit()
        {
            InitializeComponent();
        }

        private async void FormInit_Load(object sender, EventArgs e)
        {
            // start Init processes asyncronously
            await InitAllTaskAsync();
            // Once finished show button
            btnOK.Visible = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Task InitAllTaskAsync()
        {
            return Task.Run(() => InitAllSlow());
        }

        private void InitAllSlow()
        {
            // here just put all the processes to install VBox, import OVA and start OVA silently
            Thread.Sleep(3000);
        }
    }
}
