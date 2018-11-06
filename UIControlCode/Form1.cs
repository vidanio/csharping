﻿using System;
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
        private string ServerURL = "http://192.168.1.47/";

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

        private void btnStart1E_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["Source1E"] = txtSource1E.Text;
            Properties.Settings.Default["Smartkey1E"] = txtSmartkey1E.Text;
            Properties.Settings.Default["ServID1E"] = numServID1E.Value;
        }

        private void btnStop1E_Click(object sender, EventArgs e)
        {

        }

        private void btnStart2E_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["Source2E"] = txtSource2E.Text;
            Properties.Settings.Default["Smartkey2E"] = txtSmartkey2E.Text;
            Properties.Settings.Default["ServID2E"] = numServID2E.Value;
        }

        private void btnStop2E_Click(object sender, EventArgs e)
        {

        }

        private void btnStart1D_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["Smartkey1D"] = txtSmartkey1D.Text;
            Properties.Settings.Default["ServID1D"] = numServID1D.Value;
        }

        private void btnStop1D_Click(object sender, EventArgs e)
        {

        }

        private void btnStart2D_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["Smartkey2D"] = txtSmartkey2D.Text;
            Properties.Settings.Default["ServID2D"] = numServID2D.Value;
        }

        private void btnStop2D_Click(object sender, EventArgs e)
        {

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
                statusLblMsg.ForeColor = Color.Green;
                statusLblMsg.Text = String.Format("Conectado al Dispositivo Local: {0}", mDNSName);
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
    }
}
/*
0*http://192.168.1.168/0.ts*smart://192.168.1.47/VRbybdDBvtEsdVol*16*3058*false*true\r\n

0*NULL
1*NULL
2*NULL
3*NULL
*/
