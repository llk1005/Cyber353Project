using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.IO;

namespace Cyber_353_Project
{
    public partial class UserMainMenu : Form
    {
        public UserMainMenu()
        {
            InitializeComponent();

            welcomeLbl.Text += "\n" + SessionHandler.getName();
            ScanBtn.Hide();
            NetworkBtn.Hide();
            RDBtn.Hide();
            AddUser.Hide();

            if (SessionHandler.getRole() == "Super User")
            {
                ScanBtn.Show();
                NetworkBtn.Show();
                RDBtn.Show();
            }
            else if (SessionHandler.getRole() == "Admin")
            {
                NetworkBtn.Show();
                RDBtn.Show();
            }
            else if (SessionHandler.getRole() == "Security Personnel")
            {
                ScanBtn.Show();
            }
            else if (SessionHandler.getRole() == "System Administrator")
            {
                NetworkBtn.Show();
            }
            else if (SessionHandler.getRole() == "IT")
            {
                AddUser.Show();
            }
        }

        private void ScanBtn_Click(object sender, EventArgs e)
        {
            ActivityMonitor scan = new ActivityMonitor();
            scan.Show();
        }

        private void NetworkBtn_Click(object sender, EventArgs e)
        {
            Utils.networkAnalysis();
        }

        private void RDBtn_Click(object sender, EventArgs e)
        {
            RemoteDesktopConnection rdp = new RemoteDesktopConnection();
            rdp.Show();
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
        }
    }
}
