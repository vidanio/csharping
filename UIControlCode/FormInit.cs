using System;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Generic;
using Tmds.MDns;
using System.Net;
using System.Net.Sockets;

namespace UIControlCode
{
    public partial class FormInit : Form
    {
        public string Result { get; set; } = "";
        public string UUID { get; set; } = "";
        public string mDNSURL { get; set; } = "";
        public string mDNSIP { get; set; } = "";
        public string mDNSName { get; set; } = "";

        Process process = new Process();
        ProcessStartInfo proccessInfo = new ProcessStartInfo();
        string stdout, stderr;
        List<NetIF> netIFs = new List<NetIF>();
        NetIF currentIF = new NetIF();
        bool vmfound = false;
        
        public FormInit()
        {
            InitializeComponent();
        }

        private async void FormInit_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            // initialize properties of external process to use
            process.EnableRaisingEvents = true;
            proccessInfo.CreateNoWindow = true;
            proccessInfo.UseShellExecute = false;
            proccessInfo.RedirectStandardOutput = true;
            proccessInfo.RedirectStandardError = true;

            // configure VBox
            proccessInfo.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + @"\Oracle\VirtualBox\VBoxManage.exe";
            proccessInfo.Arguments = @"setextradata global GUI/UpdateDate never";
            try
            {
                process = Process.Start(proccessInfo);
                lblMessage.Text = "Comienza la Configuración ...";
                await WaitForExitTaskAsync(process);
                lblMessage.Text = "Configuración Finalizada";
            }
            catch
            {
                // Error, VBox not installed OK, Exit
                lblMessage.Text = "VBox no esta correctamente instalado. Vuelva a instalar la aplicación.";
                Result = "VBOX_NOT_FOUND";
                btnOK.Visible = true;
                return;
            }

            // List all VMs
            proccessInfo.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + @"\Oracle\VirtualBox\VBoxManage.exe";
            proccessInfo.Arguments = @"list vms";
            process = Process.Start(proccessInfo);
            process.OutputDataReceived += Process_ListOutputDataReceived;
            process.BeginOutputReadLine();
            lblMessage.Text = "Buscando nuestra VM ...";
            await WaitForExitTaskAsync(process);

            // Import OVA
            if (UUID == "")
            {
                proccessInfo.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + @"\Oracle\VirtualBox\VBoxManage.exe";
                proccessInfo.Arguments = @"import libs\TodoStreaming.ova";
                process = Process.Start(proccessInfo);
                lblMessage.Text = "Comienza la Importación VM ...";
                await WaitForExitTaskAsync(process);
                lblMessage.Text = "Importación VM terminada";
                // list and find TodoStreaming VM
                proccessInfo.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + @"\Oracle\VirtualBox\VBoxManage.exe";
                proccessInfo.Arguments = @"list vms";
                process = Process.Start(proccessInfo);
                process.OutputDataReceived += Process_ListOutputDataReceived;
                process.BeginOutputReadLine();
                lblMessage.Text = "Buscando nuestra VM ...";
                await WaitForExitTaskAsync(process);
                if (UUID == "")
                {
                    // Error, VM TodoStreaming not found
                    lblMessage.Text = "VM no encontrada. Vuelva a instalar la aplicación.";
                    Result = "VM_NOT_FOUND";
                    btnOK.Visible = true;
                    return;
                }
            }
            lblMessage.Text = "VM encontrada";

            // Get all possible Bridge Network Interfaces
            proccessInfo.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + @"\Oracle\VirtualBox\VBoxManage.exe";
            proccessInfo.Arguments = @"list bridgedifs";
            process = Process.Start(proccessInfo);
            process.OutputDataReceived += Process_NetIFOutputDataReceived;
            process.BeginOutputReadLine();
            lblMessage.Text = "Buscando interfaces de red ...";
            await WaitForExitTaskAsync(process);
            if (netIFs.Count == 0)
            {
                // Error, No hay red conectada, Exit
                lblMessage.Text = "No se encuentra ninguna Red. Conectese a una y vuelva a intentarlo";
                Result = "NET_NOT_FOUND";
                btnOK.Visible = true;
                return;
            }
            // Find the best net IF for us
            string ifname = "";
            foreach (NetIF netif in netIFs)
            {
                if (!netif.Wireless)
                {
                    ifname = netif.Name;
                    break;
                }
                ifname = netif.Name;
            }
            proccessInfo.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + @"\Oracle\VirtualBox\VBoxManage.exe";
            proccessInfo.Arguments = String.Format("modifyvm \"TodoStreaming\" --bridgeadapter1 \"{0}\"", ifname);
            process = Process.Start(proccessInfo);

            // Launch our VM
            proccessInfo.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + @"\Oracle\VirtualBox\VBoxManage.exe";
            proccessInfo.Arguments = String.Format("startvm \"TodoStreaming\" --type headless");
            process = Process.Start(proccessInfo);
            lblMessage.Text = "Arrancando VM ...";
            await WaitForExitTaskAsync(process);

            // Searching for local VM server
            ServiceBrowser serviceBrowser = new ServiceBrowser();
            List<string> serviceTypes = new List<string>();
            serviceTypes.Add("_https._tcp");
            serviceTypes.Add("_http._tcp");
            serviceBrowser.ServiceAdded += onServiceAdded;
            serviceBrowser.StartBrowse(serviceTypes);
            lblMessage.Text = "Buscando VM para conectar ...";
            await WaitForVMFoundTaskAsync();
            lblMessage.Text = "VM arrancada y preparada. Todo listo para trabajar";

            // Once finished show button
            btnOK.Visible = true;
        }

        private void onServiceAdded(object sender, ServiceAnnouncementEventArgs e)
        {
            ServiceAnnouncement service = e.Announcement;
            mDNSObject mDNS = new mDNSObject();

            mDNS.Type = (service.Type == "_https._tcp") ? "https" : "http";
            mDNS.Name = service.Instance;
            if (!mDNS.Name.Contains("TodoStreaming Control on SRTProxy")) return;
            foreach (string txt in service.Txt)
            {
                if (txt.Contains("uuid"))
                {
                    string[] word = txt.Split('=');
                    mDNS.Txt = word[1];
                }
            }
            foreach (IPAddress ipaddr in service.Addresses)
            {
                if (ipaddr.AddressFamily.ToString() == ProtocolFamily.InterNetwork.ToString()) // IPv4
                {
                    mDNS.Address = ipaddr.ToString();
                }
            }
            if (mDNS.Address == "") return;
            mDNS.Port = service.Port;
            // revisar si es el nuestro
            if (mDNS.Txt == UUID)
            {
                mDNSURL = String.Format("{0}://{1}:{2}", mDNS.Type, mDNS.Address, mDNS.Port);
                mDNSName = mDNS.Name;
                mDNSIP = mDNS.Address;
                vmfound = true;
            }
        }

        private void Process_NetIFOutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                if (e.Data.Contains("Name:") && !e.Data.Contains("VBoxNetworkName:"))
                {
                    string[] words = e.Data.Split(':');
                    currentIF.Name = words[1].Trim();
                }
                else if (e.Data.Contains("Wireless:"))
                {
                    string[] words = e.Data.Split(':');
                    currentIF.Wireless = (words[1].Trim() == "Yes") ? true : false;
                }
                else if (e.Data.Contains("Status:")) // last line, record object or not
                {
                    string[] words = e.Data.Split(':');
                    if ( words[1].Trim() == "Up" )
                    {
                        netIFs.Add(currentIF);
                    }
                }
            }
        }

        private void Process_ListOutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                if (e.Data.Contains("TodoStreaming"))
                {
                    UUID = getuuid(e.Data);
                }
            }
        }

        private Task WaitForExitTaskAsync(Process proc)
        {
            return Task.Run(() => WaitForExitSlow(proc));
        }

        private void WaitForExitSlow(Process proc)
        {
            proc.WaitForExit();
        }

        private Task WaitForVMFoundTaskAsync()
        {
            return Task.Run(() => WaitForVMFound());
        }

        private void WaitForVMFound()
        {
            while(!vmfound)
            {
                Thread.Sleep(100);
            }
        }

        private string getuuid(string line)
        {
            string uuid = "";

            string[] word = line.Split('{', '}');
            if (word.Length > 1)
            {
                uuid = word[1];
            }

            return uuid;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
