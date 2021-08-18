using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.Net.NetworkInformation;

namespace NetUtilities
{
    public partial class IpScan : UserControl
    {
        public IpScan()
        {
            InitializeComponent();
        }

        private void scanButton_Click(object sender, EventArgs e)
        {
            Thread fetchThread = new Thread(new ThreadStart(FetchDevices));
            fetchThread.Start();
        }

        private void FetchDevices()
        {
            richTextBox1.Invoke(new Action(() => richTextBox1.Text += "Start"));
            string netAddress = "192.168.1.";
            for (int i = 1; i < 255; i++)
            {
                Ping ping = new Ping();
                PingReply pingReply = ping.Send(netAddress + i);
                if(pingReply.Status == IPStatus.Success)
                {
                    IPHostEntry host = Dns.GetHostEntry(IPAddress.Parse(netAddress + i));
                    
                    richTextBox1.Invoke(new Action(() => richTextBox1.Text += "\n" + netAddress + i + "|" + host.HostName));
                }
                
            }
            richTextBox1.Invoke(new Action(() => richTextBox1.Text += "Finish"));
        }
    }
}
