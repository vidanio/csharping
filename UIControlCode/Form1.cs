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
        // globales internas
        private string ServerURL = "http://192.168.1.47/";
        private string LoginName;

        public MainForm()
        {
            InitializeComponent();
            webClient.Encoding = Encoding.UTF8;

            //PaintRootBoard();
            //TestAll();
            //PaintAdminBoard("TodoStreaming");
            //PaintUserBoard("Televisión Andaluza");
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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private async void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Get settings saved
            formLogin.LoginServer = (int)Properties.Settings.Default["LoginServer"];
            formLogin.LoginMail = (string)Properties.Settings.Default["LoginMail"];
            formLogin.LoginPass = (string)Properties.Settings.Default["LoginPass"];

            if (formLogin.ShowDialog() == DialogResult.OK)
            {
                bool success = false;
                string result = "";

                Uri url = new Uri(String.Format("{0}admin.cgi?cmd=0&mail={1}&pass={2}", ServerURL, formLogin.LoginMail, formLogin.LoginPass));

                txtDebug.AppendText(String.Format("Login[{0}]: User={1} Pass={2}\r\n", formLogin.LoginServer, formLogin.LoginMail, formLogin.LoginPass));
                statusLblMsg.ForeColor = Color.Blue;
                statusLblMsg.Text = String.Format("Intentando conectar con el Server {0} ...", formLogin.LoginServer);

                try
                {
                    result = await webClient.GetHTTStringPTaskAsync(url);
                    success = true;
                }
                catch (Exception ex)
                {
                    success = false;
                    txtDebug.AppendText(String.Format("Error: {0}\r\n", ex.Message));
                    statusLblMsg.ForeColor = Color.Red;
                    statusLblMsg.Text = String.Format("Error al conectar al Server {0} ({1})", formLogin.LoginServer, ex.Message);
                    formLogin.LoginServer = 1;
                    formLogin.LoginMail = "";
                    formLogin.LoginPass = "";
                }

                if (success)
                {
                    // Save settings
                    Properties.Settings.Default["LoginServer"] = formLogin.LoginServer;
                    Properties.Settings.Default["LoginMail"] = formLogin.LoginMail;
                    Properties.Settings.Default["LoginPass"] = formLogin.LoginPass;
                    Properties.Settings.Default.Save();

                    txtDebug.AppendText(result + "\r\n");
                    var words = result.Split('=');
                    LoginName = words[2];
                    rndlogin = words[1];
                    statusLblMsg.ForeColor = Color.Green;
                    statusLblMsg.Text = String.Format("Conectado al Server {0} como {1}", formLogin.LoginServer, LoginName);
                    if (formLogin.LoginMail == "admin")
                    {
                        board = 0; // Root board
                        PaintRootBoard();
                    }
                    else
                    {
                        if (words[0] == "0")
                        {
                            board = 1; // Admin board
                            PaintAdminBoard(LoginName);
                        }
                        else
                        {
                            board = 2; // User board
                            PaintUserBoard(LoginName);
                        }
                    }
                }
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Dispose();
            this.Close();
        }
    }
}
