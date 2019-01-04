using System.Windows.Forms;
using System.Drawing;
using System;

namespace UIControlCode
{
    public partial class MainForm : Form
    {
        private async void handlerPassChange_Click(object sender, EventArgs e)
        {
            FormNewPass form = new FormNewPass();

            if (form.ShowDialog() == DialogResult.OK)
            {
                await webClient.GetHTTPStringPTaskAsync(new Uri(String.Format("{0}user.cgi?cmd=1&rnd={1}&pass={2}", ServerURL, rndlogin, form.LoginPass)));
            }
        }

        private void DrawLoggingBlock(int x, int y, string text)
        {
            // Login picture
            loggingPicture.Location = new Point(x, y);
            loggingPicture.Size = new Size(20, 20);
            loggingPicture.Image = Properties.Resources.pass20x20;
            loggingPicture.Name = "loggingPicture";
            loggingPicture.Cursor = Cursors.Hand;
            tooltip.SetToolTip(loggingPicture, "Cambie su Clave");
            loggingPicture.Click += new EventHandler(handlerPassChange_Click);
            panel.Controls.Add(loggingPicture);
            // Login label
            loggingLabel.Location = new Point(x + 22, y + 7);
            loggingLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            loggingLabel.AutoSize = true;
            loggingLabel.TextAlign = ContentAlignment.MiddleCenter;
            loggingLabel.Name = "loggingLabel";
            loggingLabel.Text = text;
            panel.Controls.Add(loggingLabel);

        }

        // (x,y) = coords of title; (sizex, sizey) = size of panel
        private void DrawAdminsPanelBlock(int x, int y, int sizex, int sizey)
        {
            // container panel
            panelListAdmins.AutoScroll = true;
            panelListAdmins.BorderStyle = BorderStyle.FixedSingle;
            panelListAdmins.Location = new Point(x, y + 23);
            panelListAdmins.Size = new Size(sizex, sizey); // sizex, sizey
            panelListAdmins.Name = "panelListAdmins";
            panel.Controls.Add(panelListAdmins);
            // title above the panel
            lblTitleAdmins.AutoSize = false;
            lblTitleAdmins.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lblTitleAdmins.Location = new Point(x, y);
            lblTitleAdmins.Size = new Size(sizex - 20, 20);
            lblTitleAdmins.Text = "Lista de Administradores";
            lblTitleAdmins.Name = "lblTitleAdmins";
            lblTitleAdmins.TextAlign = ContentAlignment.MiddleCenter;
            panel.Controls.Add(lblTitleAdmins);
            // Add Admin button
            addAdmin.Location = new Point(x + sizex - 20, y);
            addAdmin.Size = new Size(20, 20);
            addAdmin.Image = Properties.Resources.add_20x20;
            addAdmin.Name = "addAdmin";
            addAdmin.Cursor = Cursors.Hand;
            addAdmin.Click += new EventHandler(handlerAdmins_Click);
            tooltip.SetToolTip(addAdmin, "Añadir un Nuevo Admin");
            panel.Controls.Add(addAdmin);
        }

        // (x,y) = coords of title; (sizex, sizey) = size of panel
        private void DrawUsersPanelBlock(int x, int y, int sizex, int sizey)
        {
            // container panel
            panelListUsers.AutoScroll = true;
            panelListUsers.BorderStyle = BorderStyle.FixedSingle;
            panelListUsers.Location = new Point(x, y + 23);
            panelListUsers.Size = new Size(sizex, sizey); // sizex, sizey
            panelListUsers.Name = "panelListUsers";
            panel.Controls.Add(panelListUsers);
            // title above the panel
            lblTitleUsers.AutoSize = false;
            lblTitleUsers.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lblTitleUsers.Location = new Point(x, y);
            lblTitleUsers.Size = new Size(sizex - 20, 20);
            lblTitleUsers.Text = "Lista de Usuarios";
            lblTitleUsers.Name = "lblTitleUsers";
            lblTitleUsers.TextAlign = ContentAlignment.MiddleCenter;
            panel.Controls.Add(lblTitleUsers);
            // Add Admin button
            addUser.Location = new Point(x + sizex - 20, y);
            addUser.Size = new Size(20, 20);
            addUser.Image = Properties.Resources.add_20x20;
            addUser.Name = "addUser";
            addUser.Cursor = Cursors.Hand;
            addUser.Click += new EventHandler(handlerUsers_Click);
            tooltip.SetToolTip(addUser, "Añadir un Nuevo Usuario");
            panel.Controls.Add(addUser);
        }

        // (x,y) = coords of title; (sizex, sizey) = size of panel
        private void DrawDevicesPanelBlock(int x, int y, int sizex, int sizey)
        {
            // container panel
            panelListDevices.AutoScroll = true;
            panelListDevices.BorderStyle = BorderStyle.FixedSingle;
            panelListDevices.Location = new Point(x, y + 23);
            panelListDevices.Size = new Size(sizex, sizey); // sizex, sizey
            panelListDevices.Name = "panelListDevices";
            panel.Controls.Add(panelListDevices);
            // title above the panel
            lblTitleDevices.AutoSize = false;
            lblTitleDevices.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lblTitleDevices.Location = new Point(x, y);
            lblTitleDevices.Size = new Size(sizex - 20, 20);
            lblTitleDevices.Text = "Lista de Dispositivos";
            lblTitleDevices.Name = "lblTitleDevices";
            lblTitleDevices.TextAlign = ContentAlignment.MiddleCenter;
            panel.Controls.Add(lblTitleDevices);
            // Add Admin button
            addDevice.Location = new Point(x + sizex - 20, y);
            addDevice.Size = new Size(20, 20);
            addDevice.Image = Properties.Resources.add_20x20;
            addDevice.Name = "addDevice";
            addDevice.Cursor = Cursors.Hand;
            addDevice.Click += new EventHandler(handlerDevices_Click);
            tooltip.SetToolTip(addDevice, "Añadir un Nuevo Emisor");
            panel.Controls.Add(addDevice);
        }

        private DataGridView DrawStatsTableBlock(int x, int y, int sizex, int sizey, string csv, string sum)
        {
            string[]  Headers = (sum == "admin_mon") ? AdminMonHeaders : (sum == "user_mon") ? UserMonHeaders : (sum == "user_day") ? UserDayHeaders : UserNowHeaders;

            DataGridView dgv = DrawDataGridView(Headers, new Size(sizex, sizey), new Point(x, y), "dgv_" + sum);
            LoadStatsOnDGV(dgv, csv, sum);
            panel.Controls.Add(dgv);

            if (sum != "user_now")
            {
                ComboBox cboxMonth = (sum == "user_day") ? cboxMonth_day : cboxMonth_mon;
                ComboBox cboxYear = (sum == "user_day") ? cboxYear_day : cboxYear_mon;
                DateTime today = DateTime.Today;
                cboxMonth = CreateComboBox("Mes", MonthNames, x + sizex - 90, y - 24, 90, 21, "Month_" + sum, today.Month - 1);
                object[] years = new object[] { today.Year-2, today.Year-1 , today.Year };
                cboxYear = CreateComboBox("Año", years, x + sizex - 153, y - 24, 60, 21, "Year_" + sum, 2);
                panel.Controls.Add(cboxMonth);
                panel.Controls.Add(cboxYear);
            }

            return dgv;
        }

        private ComboBox CreateComboBox(string title, object[] options, int x, int y, int sizex, int sizey, string suffix, int selected)
        {
            ComboBox cbox = new ComboBox();
            cbox.Items.AddRange(options);
            cbox.Text = title;
            cbox.Name = "cbox_" + suffix;
            cbox.FormattingEnabled = true;
            cbox.Location = new Point(x, y);
            cbox.Size = new Size(sizex, sizey);
            if (selected < cbox.Items.Count)
            {
                cbox.SelectedIndex = selected;
            }
            cbox.SelectedIndexChanged += new EventHandler(handlerCombos_SelectedIndexChanged);

            return cbox;
        }

        // select index changed event handler for all comboboxes in the window
        private async void handlerCombos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbox = (ComboBox)sender;
            if (cbox.SelectedIndex != -1)
            {
                string sum = "", statsum = "", date = "", url = "";
                DataGridView dgv = null;

                txtDebug.AppendText(String.Format("{0} selected [{1}] = {2}\r\n", cbox.Name, cbox.SelectedIndex.ToString(), cbox.Items[cbox.SelectedIndex].ToString()));

                if (board == 2) // user streamer (user_mon, user_day)
                {
                    switch (cbox.Name)
                    {
                        case "cbox_Month_user_mon":
                            monMonth = String.Format("{0:D2}", cbox.SelectedIndex + 1);
                            sum = "user_mon";
                            statsum = "mon";
                            date = String.Format("{0}-{1}", monYear, monMonth);
                            dgv = dgv_user_mon;
                            break;
                        case "cbox_Year_user_mon":
                            monYear = String.Format("{0}", cbox.Items[cbox.SelectedIndex].ToString());
                            sum = "user_mon";
                            statsum = "mon";
                            date = String.Format("{0}-{1}", monYear, monMonth);
                            dgv = dgv_user_mon;
                            break;
                        case "cbox_Month_user_day":
                            dayMonth = String.Format("{0:D2}", cbox.SelectedIndex + 1);
                            sum = "user_day";
                            statsum = "day";
                            date = String.Format("{0}-{1}", dayYear, dayMonth);
                            dgv = dgv_user_day;
                            break;
                        case "cbox_Year_user_day":
                            dayYear = String.Format("{0}", cbox.Items[cbox.SelectedIndex].ToString());
                            sum = "user_day";
                            statsum = "day";
                            date = String.Format("{0}-{1}", dayYear, dayMonth);
                            dgv = dgv_user_day;
                            break;
                    }
                    url = String.Format("{0}user.cgi?cmd=8&rnd={1}&date={2}&sum={3}", ServerURL, rndlogin, date, statsum);
                }
                else // admin or root (admin_mon, user_day)
                {
                    switch (cbox.Name)
                    {
                        case "cbox_Month_admin_mon":
                            monMonth = String.Format("{0:D2}", cbox.SelectedIndex + 1);
                            sum = "admin_mon";
                            statsum = "mon";
                            date = String.Format("{0}-{1}", monYear, monMonth);
                            dgv = dgv_admin_mon;
                            url = String.Format("{0}admin.cgi?cmd=8&date={1}&rnd={2}", ServerURL, date, rndlogin);
                            break;
                        case "cbox_Year_admin_mon":
                            monYear = String.Format("{0}", cbox.Items[cbox.SelectedIndex].ToString());
                            sum = "admin_mon";
                            statsum = "mon";
                            date = String.Format("{0}-{1}", monYear, monMonth);
                            dgv = dgv_admin_mon;
                            url = String.Format("{0}admin.cgi?cmd=8&date={1}&rnd={2}", ServerURL, date, rndlogin);
                            break;
                        case "cbox_Month_user_day":
                            dayMonth = String.Format("{0:D2}", cbox.SelectedIndex + 1);
                            sum = "user_day";
                            statsum = "day";
                            date = String.Format("{0}-{1}", dayYear, dayMonth);
                            dgv = dgv_user_day;
                            if (selected == "") return;
                            url = String.Format("{0}user.cgi?cmd=8&rnd={1}&date={2}&sum={3}", ServerURL, rndquery, date, statsum);
                            break;
                        case "cbox_Year_user_day":
                            dayYear = String.Format("{0}", cbox.Items[cbox.SelectedIndex].ToString());
                            sum = "user_day";
                            statsum = "day";
                            date = String.Format("{0}-{1}", dayYear, dayMonth);
                            dgv = dgv_user_day;
                            if (selected == "") return;
                            url = String.Format("{0}user.cgi?cmd=8&rnd={1}&date={2}&sum={3}", ServerURL, rndquery, date, statsum);
                            break;
                    }
                }
                // call HTTP server and load Stats table
                txtDebug.AppendText(url + "\r\n");
                string csv = await webClient.GetHTTPStringPTaskAsync(new Uri(url));
                dgv.Rows.Clear();
                if (csv != null)
                {
                    LoadStatsOnDGV(dgv, csv, sum);
                    //txtDebug.AppendText("Response: " + csv + "\r\n");
                }

            }
        }
    }
}
