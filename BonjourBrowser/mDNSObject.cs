namespace BonjourBrowser
{
    class mDNSObject
    {
        // properties
        public string Type { get; set; } // http, https
        public string Name { get; set; } // service.Instance
        public string Address { get; set; } = ""; // IPv4 addr
        public int Port { get; set; } // service.Port
        public string Txt { get; set; } // service.Txt

        public mDNSObject()
        {
            // just a container object
        }
    }
}
