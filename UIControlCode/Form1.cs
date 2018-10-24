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
        public MainForm()
        {
            InitializeComponent();

            testall();
        }

        // this is sample test that shows how to use all funcs
        private void testall()
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
            DrawDevicesPanel(devices, panelDevices);
            UpdateDevicesPanel(devices2, panelDevices);

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

            DrawUsersPanel(users, panelUsers);

            // stats INFO sum = user_day (Day ; MBytes ; Minutes)
            test = "TodoStreaming;2018-10-09;254256;954220\r\n";
            test += "TodoStreaming;2018-10-10;256001;564489\r\n";
            test += "TodoStreaming;2018-10-22;1384;219\r\n";
            // DGV draw
            string[] colheaders = new string[] { "Día", "MBytes", "Minutos" };
            DataGridView dgv1 = DrawDataGridView(colheaders, new Size(376, 243), new Point(596, 242), "dgv1");
            LoadStatsOnDGV(dgv1, test, "user_day");
            Controls.Add(dgv1);
        }

    }
}
