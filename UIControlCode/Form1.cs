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
        private string test = "E;Encoder11;0;99652;0;false;true;VRbybdDBvtEsdVol\r\nD;Linux82;0;9000;0;false;true;WRCQGpzkmhkuGSAb\r\n";
        //private string test = "";

        public MainForm()
        {
            InitializeComponent();

            ParseDevices(test);
        }

        private void ParseAdmins(string csv)
        {
            StringReader strReader = new StringReader(csv);

            while (true)
            {
                string line = strReader.ReadLine();
                if (line != null)
                {
                    txtDebug.AppendText(new User(0, line).Print() + "\r\n");
                }
                else
                {
                    break;
                }
            }
        }

        private void ParseUsers(string csv)
        {
            StringReader strReader = new StringReader(csv);

            while (true)
            {
                string line = strReader.ReadLine();
                if (line != null)
                {
                    txtDebug.AppendText(new User(1, line).Print() + "\r\n");
                }
                else
                {
                    break;
                }
            }
        }

        private void ParseDevices(string csv)
        {
            StringReader strReader = new StringReader(csv);

            while (true)
            {
                string line = strReader.ReadLine();
                if (line != null)
                {
                    txtDebug.AppendText(new Device(line).Print() + "\r\n");
                }
                else
                {
                    break;
                }
            }
        }

        private void txtDebug_TextChanged(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(TextBox))
            {

            }
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
