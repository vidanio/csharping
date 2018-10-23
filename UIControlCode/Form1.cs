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

            string test = "";
            test += "E;Encoder11;0;99652;13500;false;true;VRbybdDBvtEsdVol\r\n";
            test += "D;Linux82;0;9000;1256;false;true;WRCQGpzkmhkuGSAb\r\n";
            test += "D;Linux83;0;0;64;false;true;pTrRazSyhCEPRoPJ\r\n";
            test += "D;Linux88;0;0;596;false;true;dFqHwyPSPGPHSlZl\r\n";
            var devices = LoadDevices(test);

            foreach (Device dev in devices)
            {
                txtDebug.AppendText(dev.ToString() + "\r\n");
            }

            string test2 = "";
            test2 += "E;Encoder11;0;99652;0;false;true;VRbybdDBvtEsdVol\r\n";
            test2 += "D;Linux82;0;9000;0;false;true;WRCQGpzkmhkuGSAb\r\n";
            test2 += "D;Linux83;0;0;0;false;true;pTrRazSyhCEPRoPJ\r\n";
            test2 += "D;Linux88;0;0;0;false;true;dFqHwyPSPGPHSlZl\r\n";
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

        }

        private void handlerDevices_Click(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(Button))
            {
                ((Button)sender).Text = "OK";
            }
            else if (sender.GetType() == typeof(Label))
            {
                txtDebug.AppendText(((Label)sender).Name + " clicked\r\n");
            }
        }

        // draws from start all the devices panel
        private void DrawDevicesPanel(List<Device> devices, Panel panel)
        {
            int y = 5, vstep = 23;

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
                label2.AutoSize = false;
                label2.TextAlign = ContentAlignment.MiddleRight;
                label2.ForeColor = Color.Black;
                label2.Size = new Size(101, 13);
                label2.Name = "Time_" + device.Random;
                label2.Text = device.Time;
                label2.Location = new Point(183, y);
                panel.Controls.Add(label2);
                // label for bitrate
                Label label3 = new Label();
                label3.AutoSize = false;
                label3.TextAlign = ContentAlignment.MiddleRight;
                label3.ForeColor = Color.Black;
                label3.Size = new Size(101, 13);
                label3.Name = "Bitrate_" + device.Random;
                label3.Text = device.Kbps.ToString() + " kbps";
                label3.Location = new Point(290, y);
                panel.Controls.Add(label3);
                // picturebox for active
                PictureBox pic0 = new PictureBox();
                pic0.Cursor = Cursors.Hand;
                pic0.Image = global::UIControlCode.Properties.Resources.ok;
                pic0.Location = new Point(363, y);
                pic0.Size = new Size(20, 20);
                pic0.Name = "Active_" + device.Random;
                panel.Controls.Add(pic0);



                y += vstep;
            }
        }
    
    }
}

/*
            this.pictureBox97.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox97.Image = global::UIController.Properties.Resources.ok;
            this.pictureBox97.Location = new System.Drawing.Point(363, 6);
            this.pictureBox97.Name = "pictureBox97";
            this.pictureBox97.Size = new System.Drawing.Size(20, 20);
            this.pictureBox97.TabIndex = 2;
            this.pictureBox97.TabStop = false;

 * random, mail, pass, name, active
rIxGbNezlDJCLNoS;info@todostreaming.es;vertigo2003;TodoStreaming;true
sIxGaMezlEJcLNoP;info@vidanio.com;alabama;Vidanio;true

    tipo, nombre, delay, seconds, kbps, working, active, random
E;Encoder11;0;0;0;false;true;VRbybdDBvtEsdVol
D;Linux82;0;0;0;false;true;WRCQGpzkmhkuGSAb
D;Linux83;0;0;0;false;true;pTrRazSyhCEPRoPJ
D;Linux85;0;0;0;false;true;RmsLUOjJXgcKYgiS
D;Linux88;0;0;0;false;true;dFqHwyPSPGPHSlZl
D;Linux81;0;0;0;false;true;YSZWtRcJpmrMZqpi
D;Linux84;0;0;0;false;true;jBzWJBIpQoGPtfer
D;Linux86;0;0;0;false;true;ECjswsyYrbGPYeTq
D;Linux87;0;0;0;false;true;REIWNXOpZcshEBFP
D;Linux89;0;0;0;false;true;pYtmXPjjQtInQpqF
D;Linux90;0;0;0;false;true;JjHrtBhnhAKuUCsi 
     */
