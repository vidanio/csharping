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

namespace XMLEdit
{
    public partial class MainForm : Form
    {
        private string found;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string currentFile = "TodoStreaming.vbox.xml";
            string filecontent = File.ReadAllText(currentFile);
            string[] lines = filecontent.Split('<', '>');
            foreach (string line in lines)
            {
                if (line.Contains("BridgedInterface name="))
                {
                    string[] words = line.Split('"', '"');
                    if (words.Length > 1)
                    {
                        txtLog.AppendText(String.Format("[{0}]\r\n\r\n",words[1]));
                        found = words[1];
                    }
                }
            }
            string result = filecontent.Replace(found, "Nueva tarjeta de red");
            txtLog.AppendText(result);
            File.WriteAllText("output.xml", result);
        }
    }
}
