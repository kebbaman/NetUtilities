using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetUtilities
{
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ipScanButton_Click(object sender, EventArgs e)
        {
            IpScan ipScan = new IpScan();
            ipScan.Dock = DockStyle.Fill;
            this.FindForm().Controls["containerPanel"].Controls.Add(ipScan);
            ipScan.BringToFront();
        }
    }
}
