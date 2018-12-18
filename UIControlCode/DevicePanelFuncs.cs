using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace UIControlCode
{
    public partial class MainForm : Form
    {
        // click handler for all controls inside the devices panel
        private async void handlerDevices_Click(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(PictureBox))
            {
                PictureBox pic = (PictureBox)sender;
                txtDebug.AppendText(pic.Name + " clicked[Device handler]\r\n");

                if (pic.Name == "addDevice")
                {
                    if (board < 2) // admin or root
                    {
                        User user = GetSelectedUser();
                        if (user != null)
                        {
                            // hay user seleccionado, le añadimos un encoder
                            formDevice.Reset();
                            if (formDevice.ShowDialog() == DialogResult.OK)
                            {
                                string enc = await webClient.GetHTTPStringPTaskAsync(new Uri(String.Format("{0}user.cgi?cmd=2&rnd={1}", ServerURL, rndquery)));
                                if (enc != null)
                                {
                                    await webClient.GetHTTPStringPTaskAsync(new Uri(String.Format("{0}user.cgi?cmd=4&rnd={1}&enc={2}&name={3}&active={4}",
                                        ServerURL, rndquery, enc, formDevice.DeviceName, (formDevice.DeviceActive) ? "1" : "0")));
                                }
                            }
                        }
                    }
                    else // user streamer
                    {
                        // le añadimos un encoder al logged user
                        // hay user seleccionado, le añadimos un encoder
                        formDevice.Reset();
                        if (formDevice.ShowDialog() == DialogResult.OK)
                        {
                            string enc = await webClient.GetHTTPStringPTaskAsync(new Uri(String.Format("{0}user.cgi?cmd=2&rnd={1}", ServerURL, rndlogin)));
                            if (enc != null)
                            {
                                await webClient.GetHTTPStringPTaskAsync(new Uri(String.Format("{0}user.cgi?cmd=4&rnd={1}&enc={2}&name={3}&active={4}",
                                    ServerURL, rndlogin, enc, formDevice.DeviceName, (formDevice.DeviceActive) ? "1" : "0")));
                            }
                        }
                    }

                    return;
                }

                string[] words = pic.Name.Split('_');
                if (words.Length != 3) return;
                string action = words[0];
                string random = words[1];
                string type = words[2];

                string rnd;

                if (board < 2) // admin or root
                {
                    rnd = rndquery;
                }
                else // user streamer
                {
                    rnd = rndlogin;
                }

                if (action == "AddDeco")
                {
                    formDevice.Reset();
                    if (formDevice.ShowDialog() == DialogResult.OK)
                    {
                        string enc = await webClient.GetHTTPStringPTaskAsync(new Uri(String.Format("{0}user.cgi?cmd=5&rnd={1}&enc={2}", ServerURL, rnd, random)));
                        if (enc != null)
                        {
                            await webClient.GetHTTPStringPTaskAsync(new Uri(String.Format("{0}user.cgi?cmd=7&rnd={1}&enc={2}&dec={3}&name={4}&active={5}",
                                ServerURL, rnd, random, enc, formDevice.DeviceName, (formDevice.DeviceActive) ? "1" : "0")));
                        }
                    }
                }

                if (type == "E") // encoder
                {
                    switch (action)
                    {
                        case "Inactive":
                            if (MessageBox.Show("Esta seguro de que quiere desactivar a este Emisor?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                await webClient.GetHTTPStringPTaskAsync(new Uri(String.Format("{0}user.cgi?cmd=4&rnd={1}&enc={2}&active=0", ServerURL, rnd, random)));
                            }
                            break;
                        case "Active":
                            if (MessageBox.Show("Esta seguro de que quiere activar a este Emisor?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                await webClient.GetHTTPStringPTaskAsync(new Uri(String.Format("{0}user.cgi?cmd=4&rnd={1}&enc={2}&active=1", ServerURL, rnd, random)));
                            }
                            break;
                        case "Delete":
                            if (MessageBox.Show("Esta seguro de que quiere borrar este Emisor?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                await webClient.GetHTTPStringPTaskAsync(new Uri(String.Format("{0}user.cgi?cmd=3&rnd={1}&enc={2}", ServerURL, rnd, random)));
                            }
                            break;
                        case "Edit":
                            Device device = GetDeviceByRandom(random);
                            formDevice.LoadData(device.Name, device.Active);
                            if (formDevice.ShowDialog() == DialogResult.OK)
                            {
                                await webClient.GetHTTPStringPTaskAsync(new Uri(String.Format("{0}user.cgi?cmd=4&rnd={1}&enc={2}&name={3}&active={4}",
                                    ServerURL, rnd, random, formDevice.DeviceName, (formDevice.DeviceActive) ? "1" : "0")));
                            }
                            break;
                    }
                }
                else // decoder
                {
                    // rnd = (executor), dec = random, averiguar enc al q pertenece
                    string enc = await webClient.GetHTTPStringPTaskAsync(new Uri(String.Format("{0}user.cgi?cmd=11&rnd={1}&dec={2}", ServerURL, rnd, random)));
                    if (enc == null) return;
                    txtDebug.AppendText("Owns to : " + enc + "\r\n");

                    switch (action)
                    {
                        case "Inactive":
                            if (MessageBox.Show("Esta seguro de que quiere desactivar a este Receptor?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                await webClient.GetHTTPStringPTaskAsync(new Uri(String.Format("{0}user.cgi?cmd=7&rnd={1}&enc={2}&dec={3}&active=0", ServerURL, rnd, enc, random)));
                            }
                            break;
                        case "Active":
                            if (MessageBox.Show("Esta seguro de que quiere activar a este Receptor?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                await webClient.GetHTTPStringPTaskAsync(new Uri(String.Format("{0}user.cgi?cmd=7&rnd={1}&enc={2}&dec={3}&active=1", ServerURL, rnd, enc, random)));
                            }
                            break;
                        case "Delete":
                            if (MessageBox.Show("Esta seguro de que quiere borrar este Receptor?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                await webClient.GetHTTPStringPTaskAsync(new Uri(String.Format("{0}user.cgi?cmd=6&rnd={1}&enc={2}&dec={3}", ServerURL, rnd, enc, random)));
                            }
                            break;
                        case "Edit":
                            Device device = GetDeviceByRandom(random);
                            formDevice.LoadData(device.Name, device.Active);
                            if (formDevice.ShowDialog() == DialogResult.OK)
                            {
                                await webClient.GetHTTPStringPTaskAsync(new Uri(String.Format("{0}user.cgi?cmd=7&rnd={1}&enc={2}&dec={3}&name={4}&active={5}",
                                    ServerURL, rnd, enc, random, formDevice.DeviceName, (formDevice.DeviceActive) ? "1" : "0")));
                            }
                            break;
                    }
                }

            }
            else // Label
            {
                Label lbl = (Label)sender;
                txtDebug.AppendText(lbl.Name + " clicked[Device handler]\r\n");

                string[] words = lbl.Name.Split('_');
                if (words.Length != 3) return;
                string action = words[0];
                string random = words[1];
                string type = words[2];

                if (action == "Name")
                {
                    // smartN://random/0
                    //Clipboard.SetText(random);
                    Clipboard.SetText(String.Format("smart{0}://{1}/0", LoginServer, random));
                }
            }
        }

        // draws from start all the devices panel
        private void DrawDevicesPanel(List<Device> devices, Panel panel)
        {
            int y = 5, vstep = 23;

            // clear all the old controls
            panel.Controls.Clear();

            foreach (Device device in devices)
            {
                // label for device name
                Label label0 = new Label();
                label0.AutoSize = true;
                label0.TextAlign = ContentAlignment.MiddleCenter;
                label0.ForeColor = (device.Type == "E") ? Color.Red : Color.Blue;
                label0.Size = new Size(116, 13);
                label0.Name = "Name_" + device.Random + "_" + device.Type;
                label0.Text = device.Name;
                label0.Location = new Point(9, y);
                label0.Cursor = Cursors.Hand;
                tooltip.SetToolTip(label0, (device.Type == "E") ? "Copiar encoder smart url": "Copiar Streaming URL");
                label0.Click += new EventHandler(handlerDevices_Click);
                panel.Controls.Add(label0);
                // label for delay
                Label label1 = new Label();
                label1.AutoSize = true;
                label1.TextAlign = ContentAlignment.MiddleCenter;
                label1.ForeColor = Color.Black;
                label1.Size = new Size(47, 13);
                label1.Name = "Delay_" + device.Random + "_" + device.Type;
                label1.Text = device.Delay.ToString() + " ms";
                tooltip.SetToolTip(label1, "buffer delay");
                label1.Location = new Point(131, y);
                panel.Controls.Add(label1);
                // label for time
                Label label2 = new Label();
                label2.AutoSize = true;
                label2.TextAlign = ContentAlignment.MiddleCenter;
                label2.ForeColor = Color.Black;
                label2.Size = new Size(101, 13);
                label2.Name = "Time_" + device.Random + "_" + device.Type;
                label2.Text = device.Time;
                tooltip.SetToolTip(label2, "tiempo conectado");
                label2.Location = new Point(183, y);
                panel.Controls.Add(label2);
                // label for bitrate
                Label label3 = new Label();
                label3.AutoSize = true;
                label3.TextAlign = ContentAlignment.MiddleCenter;
                label3.ForeColor = Color.Black;
                label3.Size = new Size(101, 13);
                label3.Name = "Bitrate_" + device.Random + "_" + device.Type;
                label3.Text = device.Kbps.ToString() + " kbps";
                tooltip.SetToolTip(label3, "bitrate en Kbps");
                label3.Location = new Point(290, y);
                panel.Controls.Add(label3);
                // picturebox for active
                PictureBox pic0 = new PictureBox();
                pic0.Cursor = Cursors.Hand;
                pic0.Image = (device.Active) ? Properties.Resources.ok : Properties.Resources.cancel;
                pic0.Location = new Point(363, y);
                pic0.Size = new Size(20, 20);
                pic0.Name = (device.Active) ? "Inactive_" + device.Random + "_" + device.Type : "Active_" + device.Random + "_" + device.Type;
                tooltip.SetToolTip(pic0, (device.Active) ? "Desactivar equipo" : "Activar equipo");
                pic0.Click += new EventHandler(handlerDevices_Click);
                panel.Controls.Add(pic0);
                // picturebox for working
                PictureBox pic1 = new PictureBox();
                pic1.Image = (device.Working) ? Properties.Resources.on_20x20 : Properties.Resources.off_20x20;
                pic1.Location = new Point(386, y);
                pic1.Size = new Size(20, 20);
                pic1.Name = "Working_" + device.Random + "_" + device.Type;
                tooltip.SetToolTip(pic1, (device.Working) ? "equipo conectado" : "equipo desconectado");
                panel.Controls.Add(pic1);
                // picturebox for delete
                PictureBox pic2 = new PictureBox();
                pic2.Cursor = Cursors.Hand;
                pic2.Image = Properties.Resources.delete_20x20;
                pic2.Location = new Point(409, y);
                pic2.Size = new Size(20, 20);
                pic2.Name = "Delete_" + device.Random + "_" + device.Type;
                tooltip.SetToolTip(pic2, "Borrar equipo");
                pic2.Click += new EventHandler(handlerDevices_Click);
                panel.Controls.Add(pic2);
                // picturebox for edit
                PictureBox pic3 = new PictureBox();
                pic3.Cursor = Cursors.Hand;
                pic3.Image = Properties.Resources.edit_20x20;
                pic3.Location = new Point(432, y);
                pic3.Size = new Size(20, 20);
                pic3.Name = "Edit_" + device.Random + "_" + device.Type;
                tooltip.SetToolTip(pic3, "Editar equipo");
                pic3.Click += new EventHandler(handlerDevices_Click);
                panel.Controls.Add(pic3);
                // picturebox to add decoders
                if (device.Type == "E")
                {
                    PictureBox pic4 = new PictureBox();
                    pic4.Cursor = Cursors.Hand;
                    pic4.Image = Properties.Resources.add2_20x20;
                    pic4.Location = new Point(455, y);
                    pic4.Size = new Size(20, 20);
                    pic4.Name = "AddDeco_" + device.Random + "_" + device.Type;
                    tooltip.SetToolTip(pic4, "Añadir un Nuevo Receptor");
                    pic4.Click += new EventHandler(handlerDevices_Click);
                    panel.Controls.Add(pic4);
                }

                y += vstep;
            }
        }

        // update controls that changed at devices panel
        private void UpdateDevicesPanel(List<Device> devices, Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control.GetType() == typeof(Label))
                {
                    Label crtl = (Label)control;
                    var words = crtl.Name.Split('_');
                    var device = devices.Find(x => x.Random == words[1]); // recojo el device al que pertenece este control
                    switch (words[0])
                    {
                        case "Name":
                            crtl.Text = device.Name;
                            break;
                        case "Delay":
                            crtl.Text = device.Delay.ToString() + " ms";
                            break;
                        case "Time":
                            crtl.Text = device.Time;
                            break;
                        case "Bitrate":
                            crtl.Text = device.Kbps.ToString() + " kbps";
                            break;
                    }
                }
                else // PictureBox
                {
                    PictureBox crtl = (PictureBox)control;
                    var words = crtl.Name.Split('_');
                    var device = devices.Find(x => x.Random == words[1]); // recojo el device al que pertenece este control
                    switch (words[0])
                    {
                        case "Inactive":
                        case "Active":
                            crtl.Image = (device.Active) ? Properties.Resources.ok : Properties.Resources.cancel;
                            crtl.Name = (device.Active) ? "Inactive_" + device.Random + "_" + device.Type : "Active_" + device.Random + "_" + device.Type;
                            break;
                        case "Working":
                            crtl.Image = (device.Working) ? Properties.Resources.on_20x20 : Properties.Resources.off_20x20;
                            tooltip.SetToolTip(crtl, (device.Working) ? "equipo conectado" : "equipo desconectado");
                            break;
                    }
                }
            }
        }
    }
}
