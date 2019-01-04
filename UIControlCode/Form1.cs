using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace UIControlCode
{
    public partial class MainForm : Form
    {
        // globales internas
        private string ServerURL = "";

        public MainForm()
        {
            InitializeComponent();
            webClient.Encoding = Encoding.UTF8;
            panel.Visible = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Get settings saved
            formLogin.LoginServer = (int)Properties.Settings.Default["LoginServer"];
            formLogin.LoginMail = (string)Properties.Settings.Default["LoginMail"];
            formLogin.LoginPass = (string)Properties.Settings.Default["LoginPass"];
            // Date of today
            DateTime today = DateTime.Today;
            monYear = String.Format("{0:D4}", today.Year);
            dayYear = monYear;
            monMonth = String.Format("{0:D2}", today.Month);
            dayMonth = monMonth;
            //want to know where is the executable path of this app
            txtDebug.AppendText(Path.GetDirectoryName(Application.ExecutablePath) + "\r\n");
            txtDebug.AppendText(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\r\n");
        }

        private async void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formLogin.ShowDialog() == DialogResult.OK)
            {
                string result;

                panel.Visible = true;
                timer.Stop();
                panel.Controls.Clear();
                LoginMail = formLogin.LoginMail;
                LoginPass = formLogin.LoginPass;
                LoginServer = formLogin.LoginServer;
                ServerURL = String.Format("https://srt{0}.todostreaming.es/", formLogin.LoginServer); //===>

                txtDebug.AppendText(String.Format("Login[{0}]: User={1} Pass={2}\r\n", formLogin.LoginServer, LoginMail, LoginPass));
                statusLblMsg.ForeColor = Color.Blue;
                statusLblMsg.Text = String.Format("Intentando conectar con el Server {0} ...", formLogin.LoginServer);

                result = await webClient.GetHTTPStringPTaskAsync(new Uri(String.Format("{0}admin.cgi?cmd=0&mail={1}&pass={2}", ServerURL, LoginMail, LoginPass)));
                if (result == null)
                {
                    statusLblMsg.ForeColor = Color.Red;
                    statusLblMsg.Text = String.Format("Error al conectar al Server {0}", formLogin.LoginServer);
                    formLogin.LoginServer = 1;
                    formLogin.LoginMail = "";
                    formLogin.LoginPass = "";
                    return;
                }

                DateTime today = DateTime.Today;
                string date = String.Format("{0}-{1:D2}", today.Year, today.Month);
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
                    string csv = await webClient.GetHTTPStringPTaskAsync(new Uri(String.Format("{0}admin.cgi?cmd=8&rnd={1}&date={2}", ServerURL, rndlogin, date)));
                    if (csv != null)
                        LoadStatsOnDGV(dgv_admin_mon, csv, "admin_mon");
                }
                else
                {
                    if (words[0] == "0")
                    {
                        board = 1; // Admin board
                        PaintAdminBoard(LoginName);
                        string csv = await webClient.GetHTTPStringPTaskAsync(new Uri(String.Format("{0}admin.cgi?cmd=8&rnd={1}&date={2}", ServerURL, rndlogin, date)));
                        if (csv != null)
                            LoadStatsOnDGV(dgv_admin_mon, csv, "admin_mon");
                    }
                    else
                    {
                        board = 2; // User board
                        PaintUserBoard(LoginName);
                        string csv = await webClient.GetHTTPStringPTaskAsync(new Uri(String.Format("{0}user.cgi?cmd=8&rnd={1}&date={2}&sum=mon", ServerURL, rndlogin, date)));
                        if (csv != null)
                            LoadStatsOnDGV(dgv_user_mon, csv, "user_mon");
                        csv = await webClient.GetHTTPStringPTaskAsync(new Uri(String.Format("{0}user.cgi?cmd=8&rnd={1}&date={2}&sum=day", ServerURL, rndlogin, date)));
                        if (csv != null)
                            LoadStatsOnDGV(dgv_user_day, csv, "user_day");
                        csv = await webClient.GetHTTPStringPTaskAsync(new Uri(String.Format("{0}user.cgi?cmd=8&rnd={1}&date={2}&sum=now", ServerURL, rndlogin, date)));
                        if (csv != null)
                            LoadStatsOnDGV(dgv_user_now, csv, "user_now");
                    }
                }
                // start timer to update Lists every 1 sec
                timer.Start();
                timer_Tick(null, null);
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
            string result = await webClient.GetHTTPStringPTaskAsync(new Uri(String.Format("{0}admin.cgi?cmd=0&mail={1}&pass={2}", ServerURL, LoginMail, LoginPass)));
            if (result == null)
            {
                statusLblMsg.ForeColor = Color.Red;
                statusLblMsg.Text = String.Format("ERROR: Desconectado del Server {0}", LoginServer);
                timer.Start();
                return;
            }
            statusLblMsg.ForeColor = Color.Green;
            statusLblMsg.Text = String.Format("Conectado al Server {0} como {1}", LoginServer, LoginName);


            // very quick usage, or async thru await
            if (board == 0) // root
            {
                List<User> admins = new List<User>();
                List<User> users = new List<User>();
                List<Device> devices = new List<Device>();
                csv = await webClient.GetHTTPStringPTaskAsync(new Uri(String.Format("{0}admin.cgi?cmd=11&rnd={1}&user={2}", ServerURL, rndlogin, rndquery)));
                if (csv == null)
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
                    DrawAdminsPanel(admins, panelListAdmins);
                }
                adminsList.Clear();
                adminsList.AddRange(admins);
                // actualizamos el Users panel
                users = LoadUsers(words[1]);
                if (CompareListOfUsers(usersList, users)) // NO novedades
                {
                    UpdateUsersPanel(users, panelListUsers);
                }
                else // SI novedades
                {
                    DrawUsersPanel(users, panelListUsers);
                }
                usersList.Clear();
                usersList.AddRange(users);
                // actualizamos el Devices panel
                devices = LoadDevices(words[2]);
                if (CompareListOfDevices(devicesList, devices)) // NO novedades
                {
                    UpdateDevicesPanel(devices, panelListDevices);
                }
                else // SI novedades
                {
                    DrawDevicesPanel(devices, panelListDevices);
                }
                devicesList.Clear();
                devicesList.AddRange(devices);
            }
            else if (board == 1) // admin
            {
                List<User> users = new List<User>();
                List<Device> devices = new List<Device>();
                csv = await webClient.GetHTTPStringPTaskAsync(new Uri(String.Format("{0}admin.cgi?cmd=12&rnd={1}&user={2}", ServerURL, rndlogin, rndquery)));
                if (csv == null)
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
                    DrawUsersPanel(users, panelListUsers);
                }
                usersList.Clear();
                usersList.AddRange(users);
                // actualizamos el Devices panel
                devices = LoadDevices(words[1]);
                if (CompareListOfDevices(devicesList, devices)) // NO novedades
                {
                    UpdateDevicesPanel(devices, panelListDevices);
                }
                else // SI novedades
                {
                    DrawDevicesPanel(devices, panelListDevices);
                }
                devicesList.Clear();
                devicesList.AddRange(devices);
                // actualizamos stats now
                LoadStatsOnDGV(dgv_user_now, words[2], "user_now");
            }
            else // user
            {
                List<Device> devices = new List<Device>();
                csv = await webClient.GetHTTPStringPTaskAsync(new Uri(String.Format("{0}user.cgi?cmd=10&rnd={1}", ServerURL, rndlogin)));
                if (csv == null)
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
                    DrawDevicesPanel(devices, panelListDevices);
                }
                devicesList.Clear();
                devicesList.AddRange(devices);
                // actualizamos stats now
                LoadStatsOnDGV(dgv_user_now, words[1], "user_now");
            }
            timer.Start();
        }
     }
}
