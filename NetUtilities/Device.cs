using System;
using System.Net;
using System.Net.Sockets;


namespace NetUtilities
{
    class Device
    {
        private IPAddress ipAddress;
        private string hostName;
        public IPAddress IpAddress { get => ipAddress; set => ipAddress = value; }
        public string HostName { get => hostName; set => hostName = value; }

        public Device(string ipAddress)
        {
            this.IpAddress = IPAddress.Parse(ipAddress);
            try
            {
                this.HostName = Dns.GetHostEntry(this.IpAddress).HostName;


            }
            catch (SocketException)
            {
                this.HostName = "-";
            }
            
        }

        public static string GetLocalMachineIpAddress()
        {
            IPAddress[] addresses = Dns.GetHostEntry(Dns.GetHostName()).AddressList;
            foreach(IPAddress address in addresses)
            {
                if (!address.ToString().Contains(":"))
                    return address.ToString();
            }
            return "";
        }
    }
}
