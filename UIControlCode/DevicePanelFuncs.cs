using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace UIControlCode
{
    public partial class MainForm : Form
    {
        // click handler for all controls inside the devices panel
        private void handlerDevices_Click(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(PictureBox))
            {
                txtDebug.AppendText(((PictureBox)sender).Name + " clicked[Device handler]\r\n");
            }
            else // Label
            {
                txtDebug.AppendText(((Label)sender).Name + " clicked[Device handler]\r\n");
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
                label0.Name = "Name_" + device.Random;
                label0.Text = device.Name;
                label0.Location = new Point(9, y);
                label0.Cursor = Cursors.Hand;
                tooltip.SetToolTip(label0, "Copiar smartkey");
                label0.Click += new EventHandler(handlerDevices_Click);
                panel.Controls.Add(label0);
                // label for delay
                Label label1 = new Label();
                label1.AutoSize = true;
                label1.TextAlign = ContentAlignment.MiddleCenter;
                label1.ForeColor = Color.Black;
                label1.Size = new Size(47, 13);
                label1.Name = "Delay_" + device.Random;
                label1.Text = device.Delay.ToString() + " ms";
                label1.Location = new Point(131, y);
                panel.Controls.Add(label1);
                // label for time
                Label label2 = new Label();
                label2.AutoSize = true;
                label2.TextAlign = ContentAlignment.MiddleCenter;
                label2.ForeColor = Color.Black;
                label2.Size = new Size(101, 13);
                label2.Name = "Time_" + device.Random;
                label2.Text = device.Time;
                label2.Location = new Point(183, y);
                panel.Controls.Add(label2);
                // label for bitrate
                Label label3 = new Label();
                label3.AutoSize = true;
                label3.TextAlign = ContentAlignment.MiddleCenter;
                label3.ForeColor = Color.Black;
                label3.Size = new Size(101, 13);
                label3.Name = "Bitrate_" + device.Random;
                label3.Text = device.Kbps.ToString() + " kbps";
                label3.Location = new Point(290, y);
                panel.Controls.Add(label3);
                // picturebox for active
                PictureBox pic0 = new PictureBox();
                pic0.Cursor = Cursors.Hand;
                pic0.Image = (device.Active) ? Properties.Resources.ok : Properties.Resources.cancel;
                pic0.Location = new Point(363, y);
                pic0.Size = new Size(20, 20);
                pic0.Name = (device.Active) ? "Inactive_" + device.Random: "Active_" + device.Random;
                tooltip.SetToolTip(pic0, (device.Active) ? "Desactivar equipo" : "Activar equipo");
                pic0.Click += new EventHandler(handlerDevices_Click);
                panel.Controls.Add(pic0);
                // picturebox for working
                PictureBox pic1 = new PictureBox();
                pic1.Image = (device.Working) ? Properties.Resources.on_20x20 : Properties.Resources.off_20x20;
                pic1.Location = new Point(386, y);
                pic1.Size = new Size(20, 20);
                pic1.Name = "Working_" + device.Random;
                panel.Controls.Add(pic1);
                // picturebox for delete
                PictureBox pic2 = new PictureBox();
                pic2.Cursor = Cursors.Hand;
                pic2.Image = Properties.Resources.delete_20x20;
                pic2.Location = new Point(409, y);
                pic2.Size = new Size(20, 20);
                pic2.Name = "Delete_" + device.Random;
                tooltip.SetToolTip(pic2, "Borrar equipo");
                pic2.Click += new EventHandler(handlerDevices_Click);
                panel.Controls.Add(pic2);
                // picturebox for edit
                PictureBox pic3 = new PictureBox();
                pic3.Cursor = Cursors.Hand;
                pic3.Image = Properties.Resources.edit_20x20;
                pic3.Location = new Point(432, y);
                pic3.Size = new Size(20, 20);
                pic3.Name = "Edit_" + device.Random;
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
                    pic4.Name = "AddDeco_" + device.Random;
                    tooltip.SetToolTip(pic4, "Añadir un Nuevo Decoder");
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
                            crtl.Name = (device.Active) ? "Inactive_" + device.Random : "Active_" + device.Random;
                            break;
                        case "Working":
                            crtl.Image = (device.Working) ? Properties.Resources.on_20x20 : Properties.Resources.off_20x20;
                            break;
                    }
                }
            }
        }

    }
}
