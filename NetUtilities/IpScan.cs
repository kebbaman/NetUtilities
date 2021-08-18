using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Net.NetworkInformation;
using System.ComponentModel;

namespace NetUtilities
{
    public partial class IpScan : UserControl
    {
        BindingList<Device> devices; 
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
            
            string netAddress = "192.168.1.";

            for (int i = 1; i < 254; i++)
            {
                string ipAddress = netAddress + i;
                bottomLabel.Invoke(new Action(() => bottomLabel.Text = ipAddress+"..."));
                Ping ping = new Ping();
                PingReply pingReply = ping.Send(ipAddress);

                if(pingReply.Status == IPStatus.Success)
                {
                    Device device = new Device(ipAddress);
                    kryptonDataGridView1.Invoke(new Action(() => devices.Add(device))); //I use invoke because adding elements to a binding list triggers events that takes effect on the gui.
                }
            }
            bottomLabel.Invoke(new Action(() => bottomLabel.Text =  "Found: "+ (kryptonDataGridView1.Rows.Count)));
        }

        private void IpScan_Load(object sender, EventArgs e)
        {
            string localAddress = Device.GetLocalMachineIpAddress();
            string [] b = localAddress.Split('.');
            netAddress.Text = b[0] + "." + b[1]+"." + b[2]+".0";
            
            devices = new BindingList<Device>();
            kryptonDataGridView1.DataSource = devices;
            kryptonDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.FindForm().Controls["containerPanel"].Controls["MainMenu"].BringToFront();
        }
    }
}
