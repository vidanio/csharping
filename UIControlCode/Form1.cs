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
            UpdateDevicesPanel(devices2, panelDevices);
        }
    }
}

/*
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
