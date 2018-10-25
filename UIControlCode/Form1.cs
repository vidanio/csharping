using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UIControlCode
{
    public partial class MainForm : Form
    {
        // instances of forms before using them
        FormLogin formLogin = new FormLogin();
        FormUser formUser = new FormUser();
        FormDevice formDevice = new FormDevice();
        // global declaration of all DGVs
        DataGridView dgv_admin_mon, dgv_user_mon, dgv_user_day, dgv_user_now;

        public MainForm()
        {
            InitializeComponent();

            PaintRootBoard();
            TestAll();
            //PaintAdminBoard();
            //PaintUserBoard();
        }

        private void PaintRootBoard()
        {
            DrawLoggingBlock(3, 3, "Logged as root");
            DrawAdminsPanelBlock(15, 37, 243, 243);
            DrawUsersPanelBlock(296, 37, 243, 243);
            DrawDevicesPanelBlock(15, 344, 527, 208);
            dgv_admin_mon = DrawStatsTableBlock(577, 60, 376, 243, "", "admin_mon");
            dgv_user_day = DrawStatsTableBlock(577, 367, 376, 208, "", "user_day");
        }

        private void PaintAdminBoard()
        {
            DrawLoggingBlock(3, 3, "Logged as TodoStreaming Services");
            DrawUsersPanelBlock(75, 37, 243, 243);
            DrawDevicesPanelBlock(398, 37, 527, 243);
            dgv_admin_mon = DrawStatsTableBlock(25, 364, 310, 208, "", "admin_mon");
            dgv_user_day = DrawStatsTableBlock(345, 364, 310, 208, "", "user_day");
            dgv_user_now = DrawStatsTableBlock(665, 364, 310, 208, "", "user_now");
        }

        private void PaintUserBoard()
        {
            DrawLoggingBlock(3, 3, "Logged as Televisión Andaluza");
            DrawDevicesPanelBlock(25, 37, 527, 243);
            dgv_user_now = DrawStatsTableBlock(599, 60, 376, 243, "", "user_now");
            dgv_user_mon = DrawStatsTableBlock(25, 364, 450, 208, "", "user_mon");
            dgv_user_day = DrawStatsTableBlock(525, 364, 450, 208, "", "user_day");
        }

        // this is sample test that shows how to use all funcs
        private void TestAll()
        {
            string test = "";
            test += "E;TodoStreaming Debian;5000;739600125;13500;false;true;VRbybdDBvtEsdVol\r\n";
            test += "D;Linux82;0;9000;1256;true;true;WRCQGpzkmhkuGSAb\r\n";
            test += "D;Linux83;0;0;64;false;false;pTrRazSyhCEPRoPJ\r\n";
            test += "D;Linux88;0;0;596;true;false;dFqHwyPSPGPHSlZl\r\n";
            var devices = LoadDevices(test);

            foreach (Device dev in devices)
            {
                txtDebug.AppendText(dev.ToString() + "\r\n");
            }

            string test2 = "";
            test2 += "E;Encoder11;0;99652;0;false;true;VRbybdDBvtEsdVol\r\n";
            test2 += "D;Linux88;0;0;0;false;true;dFqHwyPSPGPHSlZl\r\n";
            test2 += "D;Linux83;0;0;0;false;true;pTrRazSyhCEPRoPJ\r\n";
            test2 += "D;Linux82;0;9000;0;false;true;WRCQGpzkmhkuGSAb\r\n";
            var devices2 = LoadDevices(test2);

            if (CompareListOfDevices(devices, devices2))
            {
                txtDebug.AppendText("\r\nEQUAL !!!\r\n\r\n");
            }
            else
            {
                txtDebug.AppendText("\r\nDIFFER !!!\r\n\r\n");
            }

            // empezamos a dibujar sobre el panel varios controles a ver que pasa
            DrawDevicesPanel(devices, panelListDevices); //===>
            UpdateDevicesPanel(devices2, panelListDevices); //===>

            // copy Lists devices2 to devices
            devices.Clear();
            devices.AddRange(devices2);

            foreach (Device dev in devices)
            {
                txtDebug.AppendText(dev.ToString() + "\r\n");
            }

            // users data
            test = "rIxGbNezlDJCLNoS;info@todostreaming.es;vertigo2003;TodoStreaming Debian;true\r\n";
            test += "sIxGaMezlEJcLNoP;info@vidanio.com;alabama;Vidanio;true\r\n";
            var users = LoadUsers(test);

            DrawUsersPanel(users, panelListUsers); //===>

            // stats INFO sum = user_day (Day ; MBytes ; Minutes)
            test = "TodoStreaming;2018-10-09;254256;954220\r\n";
            test += "TodoStreaming;2018-10-10;256001;564489\r\n";
            test += "TodoStreaming;2018-10-22;1384;219\r\n";
            // DGV draw
            //DataGridView dgv1 = DrawDataGridView(UserDayHeaders, new Size(376, 243), new Point(596, 242), "dgv1");
            //LoadStatsOnDGV(dgv1, test, "user_day");
            //Controls.Add(dgv1);
        }
    }
}
