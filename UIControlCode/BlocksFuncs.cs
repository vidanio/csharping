using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System;

namespace UIControlCode
{
    public partial class MainForm : Form
    {
        object[] MonthNames = new object[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

        ToolTip tooltip = new ToolTip(); // for all the controls in the window
        // Logging Block
        PictureBox loggingPicture = new PictureBox();
        Label loggingLabel = new Label();
        // Admins Panel Block
        Panel panelListAdmins = new Panel();
        Label lblTitleAdmins = new Label();
        PictureBox addAdmin = new PictureBox();
        // Users Panel Block
        Panel panelListUsers = new Panel();
        Label lblTitleUsers = new Label();
        PictureBox addUser = new PictureBox();
        // Devices Panel Block
        Panel panelListDevices = new Panel();
        Label lblTitleDevices = new Label();
        PictureBox addDevice = new PictureBox();
        // Combos
        ComboBox cboxMonth_mon = new ComboBox();
        ComboBox cboxYear_mon = new ComboBox();
        ComboBox cboxMonth_day = new ComboBox();
        ComboBox cboxYear_day = new ComboBox();

        private void DrawLoggingBlock(int x, int y, string text)
        {
            // Login picture
            loggingPicture.Location = new Point(x, y);
            loggingPicture.Size = new Size(20, 20);
            loggingPicture.Image = Properties.Resources.pass20x20;
            loggingPicture.Name = "loggingPicture";
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
            tooltip.SetToolTip(addAdmin, "Añadir Nuevo Admin");
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
            tooltip.SetToolTip(addUser, "Añadir Nuevo Usuario");
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
            tooltip.SetToolTip(addDevice, "Añadir Nuevo Encoder");
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
        private void handlerCombos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbox = (ComboBox)sender;
            if (cbox.SelectedIndex != -1)
            {
                txtDebug.AppendText(String.Format("{0} selected [{1}] = {2}\r\n", cbox.Name, cbox.SelectedIndex.ToString(), cbox.Items[cbox.SelectedIndex].ToString()));
            }
        }
    }
}
