using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tmds.MDns;
using System.Net;
using System.Net.Sockets;

namespace BonjourBrowser
{
    public partial class FormMDNS : Form
    {
        public string mDNSURL { get; set; } = "";
        public string mDNSName { get; set; } = "";
        public string mDNSIP { get; set; } = "";
        public string mDNSTxt { get; set; } = "";

        ServiceBrowser serviceBrowser = new ServiceBrowser();
        List<mDNSObject> services = new List<mDNSObject>();

        public FormMDNS()
        {
            InitializeComponent();
        }

        private void cboxDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            if (combo.SelectedIndex != -1)
            {
                mDNSObject mDNS = new mDNSObject();
                mDNS = services.Find(x => x.Name == combo.Items[combo.SelectedIndex].ToString());
                mDNSURL = String.Format("{0}://{1}:{2}", mDNS.Type, mDNS.Address, mDNS.Port);
                mDNSName = mDNS.Name;
                mDNSIP = mDNS.Address;
                mDNSTxt = mDNS.Txt;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // clean before exit
            serviceBrowser.StopBrowse();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // clean before exit
            serviceBrowser.StopBrowse();
            this.Close();
        }

        private void FormMDNS_Load(object sender, EventArgs e)
        {
            List<string> serviceTypes = new List<string>();
            serviceTypes.Add("_https._tcp");
            serviceTypes.Add("_http._tcp");

            serviceBrowser.ServiceAdded += onServiceAdded;
            serviceBrowser.ServiceRemoved += onServiceRemoved;

            serviceBrowser.StartBrowse(serviceTypes);
        }

        private void onServiceRemoved(object sender, ServiceAnnouncementEventArgs e)
        {
            ServiceAnnouncement service = e.Announcement;
            mDNSObject mDNS = new mDNSObject();
            mDNS = services.Find(x => x.Name == service.Instance);
            services.Remove(mDNS);
            cboxDevice.Items.Clear();
            foreach (mDNSObject mdns in services)
            {
                cboxDevice.Items.Add(mdns.Name);
            }
        }

        private void onServiceAdded(object sender, ServiceAnnouncementEventArgs e)
        {
            ServiceAnnouncement service = e.Announcement;
            mDNSObject mDNS = new mDNSObject();

            mDNS.Type = (service.Type == "_https._tcp") ? "https" : "http";
            mDNS.Name = service.Instance;
            foreach (string txt in service.Txt)
            {
                if (txt.Contains("uuid"))
                {
                    mDNS.Txt = txt;
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
            services.Add(mDNS);
            cboxDevice.Items.Add(mDNS.Name);
        }
    }
}
