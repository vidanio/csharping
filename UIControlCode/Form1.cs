using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;
using System.Threading;

namespace UIControlCode
{
    public partial class MainForm : Form
    {
        // globales internas
        private string ServerURL = "http://192.168.1.38/";
        private string ServerIP = "192.168.1.38";

        public MainForm()
        {
            InitializeComponent();
            webClient.Encoding = Encoding.UTF8;
            panel.Visible = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Load FormInit to start the Linux VM
            FormInit forminit = new FormInit();
            forminit.ShowDialog();
            // Get settings saved
            formLogin.LoginServer = (int)Properties.Settings.Default["LoginServer"];
            formLogin.LoginMail = (string)Properties.Settings.Default["LoginMail"];
            formLogin.LoginPass = (string)Properties.Settings.Default["LoginPass"];
            txtSource1E.Text = (string)Properties.Settings.Default["Source1E"];
            txtSource2E.Text = (string)Properties.Settings.Default["Source2E"];
            txtSmartkey1E.Text = (string)Properties.Settings.Default["Smartkey1E"];
            txtSmartkey2E.Text = (string)Properties.Settings.Default["Smartkey2E"];
            txtSmartkey1D.Text = (string)Properties.Settings.Default["Smartkey1D"];
            txtSmartkey2D.Text = (string)Properties.Settings.Default["Smartkey2D"];
            numServID1E.Value = (int)Properties.Settings.Default["ServID1E"];
            numServID2E.Value = (int)Properties.Settings.Default["ServID2E"];
            numServID1D.Value = (int)Properties.Settings.Default["ServID1D"];
            numServID2D.Value = (int)Properties.Settings.Default["ServID2D"];
            // Date of today
            DateTime today = DateTime.Today;
            monYear = String.Format("{0:D4}", today.Year);
            dayYear = monYear;
            monMonth = String.Format("{0:D2}", today.Month);
            dayMonth = monMonth;
            //want to know where is the executable path of this app
            txtDebug.AppendText(Path.GetDirectoryName(Application.ExecutablePath) + "\r\n");
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
                // ServerURL = String.Format("https://srt{0}.todostreaming.es/", formLogin.LoginServer); //===>

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
            timerMDNS.Stop();
            timerMDNS.Dispose();
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

        private void controlarEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMDNS formMDNS = new FormMDNS();

            if (formMDNS.ShowDialog() == DialogResult.OK)
            {
                panel.Visible = false;
                lblText1E.Text = "";
                lblText1D.Text = "";
                lblText2E.Text = "";
                lblText2D.Text = "";
                mDNSURL = formMDNS.mDNSURL;
                mDNSName = formMDNS.mDNSName;
                mDNSIP = formMDNS.mDNSIP;
                mDNSconnected = true;
                txtDebug.AppendText(mDNSURL + "\r\n");
                statusLblMsg.ForeColor = Color.Green;
                statusLblMsg.Text = String.Format("Conectado al Dispositivo Local: {0}", mDNSName);
                timerMDNS.Start();
                timerMDNS_Tick(null, null);
            }
        }

        private async void btnStart1E_Click(object sender, EventArgs e)
        {
            if (!mDNSconnected) return;
            int proxy = 0;
            string source = txtSource1E.Text;
            string destiny = String.Format("smart://srt{0}.todostreaming.es/{1}", numServID1E.Value, txtSmartkey1E.Text);
            destiny = String.Format("smart://{0}/{1}", ServerIP, txtSmartkey1E.Text); // ==> erase for real tests outside
            Properties.Settings.Default["Source1E"] = txtSource1E.Text;
            Properties.Settings.Default["Smartkey1E"] = txtSmartkey1E.Text;
            Properties.Settings.Default["ServID1E"] = (int)numServID1E.Value; 
            Properties.Settings.Default.Save();

            btnStart1E.Visible = false;
            lblText1E.Text = "Conectando (espere no más de 20 segundos) ...";
            timerMDNS_Tick(null, null);
            if (await startProxyTaskAsync(proxy, source, destiny))
            {
                btnStart1E.Visible = false;
                btnStop1E.Visible = true;
                lblText1E.Text = "Negociando el envío de datos SRT (espere ...)";
            }
            else
            {
                btnStart1E.Visible = true;
                btnStop1E.Visible = false;
                lblText1E.Text = "";
            }
        }

        private async void btnStop1E_Click(object sender, EventArgs e)
        {
            if (!mDNSconnected) return;
            int proxy = 0;

            btnStop1E.Visible = false;
            lblText1E.Text = "Desconectando ...";
            timerMDNS_Tick(null, null);
            if (await stopProxyTaskAsync(proxy))
            {
                lblText1E.Text = "";
                btnStop1E.Visible = false;
                btnStart1E.Visible = true;
            }
            else
            {
                lblText1E.Text = "No se pudo parar. Vuelva a intentarlo";
                btnStop1E.Visible = true;
                btnStart1E.Visible = false;
            }
        }

        private async void btnStart2E_Click(object sender, EventArgs e)
        {
            if (!mDNSconnected) return;
            int proxy = 1;
            string source = txtSource2E.Text;
            string destiny = String.Format("smart://srt{0}.todostreaming.es/{1}", numServID2E.Value, txtSmartkey2E.Text);
            destiny = String.Format("smart://{0}/{1}", ServerIP, txtSmartkey2E.Text); // ==> erase for real tests outside
            Properties.Settings.Default["Source2E"] = txtSource2E.Text;
            Properties.Settings.Default["Smartkey2E"] = txtSmartkey2E.Text;
            Properties.Settings.Default["ServID2E"] = (int)numServID2E.Value;
            Properties.Settings.Default.Save();

            btnStart2E.Visible = false;
            lblText2E.Text = "Conectando (espere no más de 20 segundos) ...";
            timerMDNS_Tick(null, null);
            if (await startProxyTaskAsync(proxy, source, destiny))
            {
                btnStart2E.Visible = false;
                btnStop2E.Visible = true;
                lblText2E.Text = "Negociando el envío de datos SRT (espere ...)";
            }
            else
            {
                btnStart2E.Visible = true;
                btnStop2E.Visible = false;
                lblText2E.Text = "";
            }
        }

        private async void btnStop2E_Click(object sender, EventArgs e)
        {
            if (!mDNSconnected) return;
            int proxy = 1;

            btnStop2E.Visible = false;
            lblText2E.Text = "Desconectando ...";
            timerMDNS_Tick(null, null);
            if (await stopProxyTaskAsync(proxy))
            {
                lblText2E.Text = "";
                btnStop2E.Visible = false;
                btnStart2E.Visible = true;
            }
            else
            {
                lblText2E.Text = "No se pudo parar. Vuelva a intentarlo";
                btnStop2E.Visible = true;
                btnStart2E.Visible = false;
            }
        }

        private async void btnStart1D_Click(object sender, EventArgs e)
        {
            if (!mDNSconnected) return;
            int proxy = 2;
            string source = String.Format("smart://srt{0}.todostreaming.es/{1}", numServID1D.Value, txtSmartkey1D.Text);
            source = String.Format("smart://{0}/{1}", ServerIP, txtSmartkey1D.Text); // ==> erase for real tests outside
            string destiny = String.Format("tcp://127.0.0.1:1024");
            Properties.Settings.Default["Smartkey1D"] = txtSmartkey1D.Text;
            Properties.Settings.Default["ServID1D"] = (int)numServID1D.Value;
            Properties.Settings.Default.Save();

            btnStart1D.Visible = false;
            lblText1D.Text = "Conectando (espere no más de 20 segundos) ...";
            timerMDNS_Tick(null, null);
            if (await startProxyTaskAsync(proxy, source, destiny))
            {
                btnStart1D.Visible = false;
                btnStop1D.Visible = true;
                tcp1D = String.Format("tcp://{0}:1025", mDNSIP);
                tooltip.SetToolTip(lblcopypaste1D, "Copiar en el Portapapeles: " + tcp1D);
                lblText1D.Text = "Negociando la recepción de datos SRT (espere ...)";
            }
            else
            {
                btnStart1D.Visible = true;
                btnStop1D.Visible = false;
                tcp1D = "";
                tooltip.SetToolTip(lblcopypaste1D, "");
                lblText1D.Text = "";
            }
        }

        private async void btnStop1D_Click(object sender, EventArgs e)
        {
            if (!mDNSconnected) return;
            int proxy = 2;

            btnStop1D.Visible = false;
            lblText1D.Text = "Desconectando ...";
            timerMDNS_Tick(null, null);
            if (await stopProxyTaskAsync(proxy))
            {
                lblText1D.Text = "";
                btnStop1D.Visible = false;
                btnStart1D.Visible = true;
                tcp1D = "";
                tooltip.SetToolTip(lblcopypaste1D, "");
            }
            else
            {
                lblText1D.Text = "No se pudo parar. Vuelva a intentarlo";
                btnStop1D.Visible = true;
                btnStart1D.Visible = false;
            }
        }

        private async void btnStart2D_Click(object sender, EventArgs e)
        {
            if (!mDNSconnected) return;
            int proxy = 3;
            string source = String.Format("smart://srt{0}.todostreaming.es/{1}", numServID2D.Value, txtSmartkey2D.Text);
            source = String.Format("smart://{0}/{1}", ServerIP, txtSmartkey2D.Text); // ==> erase for real tests outside
            string destiny = String.Format("tcp://127.0.0.1:1026");
            Properties.Settings.Default["Smartkey2D"] = txtSmartkey2D.Text;
            Properties.Settings.Default["ServID2D"] = (int)numServID2D.Value;
            Properties.Settings.Default.Save();

            btnStart2D.Visible = false;
            lblText2D.Text = "Conectando (espere no más de 20 segundos) ...";
            timerMDNS_Tick(null, null);
            if (await startProxyTaskAsync(proxy, source, destiny))
            {
                btnStart2D.Visible = false;
                btnStop2D.Visible = true;
                tcp2D = String.Format("tcp://{0}:1027", mDNSIP);
                tooltip.SetToolTip(lblcopypaste2D, "Copiar en el Portapapeles: " + tcp2D);
                lblText2D.Text = "Negociando la recepción de datos SRT (espere ...)";
            }
            else
            {
                btnStart2D.Visible = true;
                btnStop2D.Visible = false;
                tcp2D = "";
                tooltip.SetToolTip(lblcopypaste2D, "");
                lblText2D.Text = "";
            }
        }

        private async void btnStop2D_Click(object sender, EventArgs e)
        {
            if (!mDNSconnected) return;
            int proxy = 3;

            btnStop2D.Visible = false;
            lblText2D.Text = "Desconectando ...";
            timerMDNS_Tick(null, null);
            if (await stopProxyTaskAsync(proxy))
            {
                lblText2D.Text = "";
                btnStop2D.Visible = false;
                btnStart2D.Visible = true;
                tcp2D = "";
                tooltip.SetToolTip(lblcopypaste2D, "");
            }
            else
            {
                lblText2D.Text = "No se pudo parar. Vuelva a intentarlo";
                btnStop2D.Visible = true;
                btnStart2D.Visible = false;
            }
        }

        private async void timerMDNS_Tick(object sender, EventArgs e)
        {
            timerMDNS.Stop();

            // let's start with UI updates
            string csv = await webClient.GetHTTPStringPTaskAsync(new Uri(String.Format("{0}/cmd.cgi?cmd=4", mDNSURL)));
            if (csv == null)
            {
                mDNSconnected = false;
                statusLblMsg.ForeColor = Color.Red;
                statusLblMsg.Text = String.Format("Desconectado del Dispositivo Local: {0}", mDNSName);
                timerMDNS.Start();
                return;
            }
            if (!mDNSconnected)
            {
                mDNSconnected = true;
                statusLblMsg.ForeColor = Color.Green;
                statusLblMsg.Text = String.Format("Conectado al Dispositivo Local: {0}", mDNSName);
            }

            StringReader strReader = new StringReader(csv);
            while (true)
            {
                string line = strReader.ReadLine();
                if (line != null)
                {
                    string[] word = line.Split('*');
                    if (word.Length < 7) continue;
                    if (word[5] != "true") continue; // moving data
                    switch (word[0])
                    {
                        case "0":
                            lblText1E.Text = String.Format("Enviando {0} seg. a {1} kbps", word[3], word[4]);
                            if (btnStart1E.Visible)
                            {
                                btnStart1E.Visible = false;
                                btnStop1E.Visible = true;
                            }
                            break;
                        case "1":
                            lblText2E.Text = String.Format("Enviando {0} seg. a {1} kbps", word[3], word[4]);
                            if (btnStart2E.Visible)
                            {
                                btnStart2E.Visible = false;
                                btnStop2E.Visible = true;
                            }
                            break;
                        case "2":
                            lblText1D.Text = String.Format("Recibiendo {0} seg. a {1} kbps", word[3], word[4]);
                            if (btnStart1D.Visible)
                            {
                                btnStart1D.Visible = false;
                                btnStop1D.Visible = true;
                            }
                            break;
                        case "3":
                            lblText2D.Text = String.Format("Recibiendo {0} seg. a {1} kbps", word[3], word[4]);
                            if (btnStart2D.Visible)
                            {
                                btnStart2D.Visible = false;
                                btnStop2D.Visible = true;
                            }
                            break;
                    }
                }
                else break;
            }

            timerMDNS.Start();
        }

        private void lblcopypaste1D_Click(object sender, EventArgs e)
        {
            if (tcp1D != "")
            {
                Clipboard.SetText(tcp1D);
            }
        }

        private void lblcopypaste2D_Click(object sender, EventArgs e)
        {
            if (tcp2D != "")
            {
                Clipboard.SetText(tcp2D);
            }
        }

        private Task<bool> startProxyTaskAsync(int proxy, string src, string dst)
        {
            return Task<bool>.Run(() => startProxySlow(proxy, src, dst));
        }

        private Task<bool> stopProxyTaskAsync(int proxy)
        {
            return Task<bool>.Run(() => stopProxySlow(proxy));
        }

        // this will take at most 12 seconds
        private bool startProxySlow(int proxy, string src, string dst)
        {
            string csv = webClient.GetHTTPStringRetry(new Uri(String.Format("{0}/cmd.cgi?cmd=0&proxy={1}&src={2}&dst={3}", mDNSURL, proxy, src, dst)), 3);
            if (csv == null)
                return false;
            Thread.Sleep(2000);
            return true;
        }

        // this will take at most 7 seconds
        private bool stopProxySlow(int proxy)
        {
            string csv = webClient.GetHTTPStringRetry(new Uri(String.Format("{0}/cmd.cgi?cmd=1&proxy={1}", mDNSURL, proxy)), 3);
            if (csv == null)
                return false;
            Thread.Sleep(2000);
            return true;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Stop OVA and exit
        }
    }
}
