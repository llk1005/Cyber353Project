using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cyber_353_Project.Forms
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ScanBtn_Click(object sender, EventArgs e)
        {
            ActivityMonitor scan = new ActivityMonitor();
            scan.Show();
        }

        private void NetworkBtn_Click(object sender, EventArgs e)
        {
            // TODO: Add Network Activity
        }

        private void RDBtn_Click(object sender, EventArgs e)
        {
            RemoteDesktopConnection rdp = new RemoteDesktopConnection();
            rdp.Show();
        }
    }
}
