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
            // Get settings saved
            formLogin.LoginServer = (int)Properties.Settings.Default["LoginServer"];
            formLogin.LoginMail = (string)Properties.Settings.Default["LoginMail"];
            formLogin.LoginPass = (string)Properties.Settings.Default["LoginPass"];
        }

        private async void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formLogin.ShowDialog() == DialogResult.OK)
            {
                bool success = false;
                string result = "";

                timer.Stop();
                panel.Controls.Clear();
                // ServerURL = String.Format("https://srt{0}.todostreaming.es/", formLogin.LoginServer); //===>
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
                    DateTime today = DateTime.Today;
                    string date = String.Format("{0}-{1}", today.Year, today.Month);
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
                        try
                        {
                            string csv = await webClient.GetHTTStringPTaskAsync(new Uri(String.Format("{0}admin.cgi?cmd=8&rnd={1}&date={2}", ServerURL, rndlogin, date)));
                            LoadStatsOnDGV(dgv_admin_mon, csv, "admin_mon");
                        }
                        catch
                        {
                            // error msg
                        }
                    }
                    else
                    {
                        if (words[0] == "0")
                        {
                            board = 1; // Admin board
                            PaintAdminBoard(LoginName);
                            try
                            {
                                string csv = await webClient.GetHTTStringPTaskAsync(new Uri(String.Format("{0}admin.cgi?cmd=8&rnd={1}&date={2}", ServerURL, rndlogin, date)));
                                LoadStatsOnDGV(dgv_admin_mon, csv, "admin_mon");
                            }
                            catch
                            {
                                // error msg
                            }
                        }
                        else
                        {
                            board = 2; // User board
                            PaintUserBoard(LoginName);
                            try
                            {
                                string csv = await webClient.GetHTTStringPTaskAsync(new Uri(String.Format("{0}user.cgi?cmd=8&rnd={1}&date={2}&sum=mon", ServerURL, rndlogin, date)));
                                LoadStatsOnDGV(dgv_user_mon, csv, "user_mon");
                                csv = await webClient.GetHTTStringPTaskAsync(new Uri(String.Format("{0}user.cgi?cmd=8&rnd={1}&date={2}&sum=day", ServerURL, rndlogin, date)));
                                LoadStatsOnDGV(dgv_user_day, csv, "user_day");
                                csv = await webClient.GetHTTStringPTaskAsync(new Uri(String.Format("{0}user.cgi?cmd=8&rnd={1}&date={2}&sum=now", ServerURL, rndlogin, date)));
                                LoadStatsOnDGV(dgv_user_now, csv, "user_now");
                            }
                            catch
                            {
                                // error msg
                            }
                        }
                    }
                    // start timer to update Lists every 1 sec
                    timer.Start();
                }
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Dispose();
            this.Close();
        }

        private async void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            string csv = "";
            // very quick usage, or async thru await
            if (board == 0) // root
            {
                List<User> admins = new List<User>();
                List<User> users = new List<User>();
                List<Device> devices = new List<Device>();
                try
                {
                    csv = await webClient.GetHTTStringPTaskAsync(new Uri(String.Format("{0}admin.cgi?cmd=11&rnd={1}&user={2}", ServerURL, rndlogin, rndquery)));
                }
                catch
                {
                    // error msg
                    timer.Start();
                    return;
                }
                string[] words = csv.Split('*');
                // actualizamos el Admins panel
                admins = LoadAdmins(words[0]);
                if (CompareListOfUsers(adminsList, admins)) // NO novedades
                {
                    UpdateAdminsPanel(admins, panelListAdmins);
                }
                else // SI novedades
                {
                    adminsList.Clear();
                    adminsList.AddRange(admins);
                    DrawAdminsPanel(admins, panelListAdmins);
                }
                // actualizamos el Users panel
                users = LoadUsers(words[1]);
                if (CompareListOfUsers(usersList, users)) // NO novedades
                {
                    UpdateUsersPanel(users, panelListUsers);
                }
                else // SI novedades
                {
                    usersList.Clear();
                    usersList.AddRange(users);
                    DrawUsersPanel(users, panelListUsers);
                }
                // actualizamos el Devices panel
                devices = LoadDevices(words[2]);
                if (CompareListOfDevices(devicesList, devices)) // NO novedades
                {
                    UpdateDevicesPanel(devices, panelListDevices);
                }
                else // SI novedades
                {
                    devicesList.Clear();
                    devicesList.AddRange(devices);
                    DrawDevicesPanel(devices, panelListDevices);
                }
            }
            else if (board == 1) // admin
            {
                List<User> users = new List<User>();
                List<Device> devices = new List<Device>();
                try
                {
                    csv = await webClient.GetHTTStringPTaskAsync(new Uri(String.Format("{0}admin.cgi?cmd=12&rnd={1}&user={2}", ServerURL, rndlogin, rndquery)));
                }
                catch
                {
                    // error msg
                    timer.Start();
                    return;
                }
                string[] words = csv.Split('*');
                // actualizamos el Users panel
                users = LoadUsers(words[0]);
                if (CompareListOfUsers(usersList, users)) // NO novedades
                {
                    UpdateUsersPanel(users, panelListUsers);
                }
                else // SI novedades
                {
                    usersList.Clear();
                    usersList.AddRange(users);
                    DrawUsersPanel(users, panelListUsers);
                }
                // actualizamos el Devices panel
                devices = LoadDevices(words[1]);
                if (CompareListOfDevices(devicesList, devices)) // NO novedades
                {
                    UpdateDevicesPanel(devices, panelListDevices);
                }
                else // SI novedades
                {
                    devicesList.Clear();
                    devicesList.AddRange(devices);
                    DrawDevicesPanel(devices, panelListDevices);
                }
                // actualizamos stats now
                LoadStatsOnDGV(dgv_user_now, words[2], "user_now");
            }
            else // user
            {
                List<Device> devices = new List<Device>();
                try
                {
                    csv = await webClient.GetHTTStringPTaskAsync(new Uri(String.Format("{0}user.cgi?cmd=10&rnd={1}", ServerURL, rndlogin)));
                }
                catch
                {
                    // error msg
                    timer.Start();
                    return;
                }
                string[] words = csv.Split('*');
                // actualizamos el Devices panel
                devices = LoadDevices(words[0]);
                if (CompareListOfDevices(devicesList, devices)) // NO novedades
                {
                    UpdateDevicesPanel(devices, panelListDevices);
                }
                else // SI novedades
                {
                    devicesList.Clear();
                    devicesList.AddRange(devices);
                    DrawDevicesPanel(devices, panelListDevices);
                }
                // actualizamos stats now
                LoadStatsOnDGV(dgv_user_now, words[1], "user_now");
            }
            timer.Start();
        }
    }
}
