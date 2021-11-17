using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * This method is not to be used in the final release
 * This is used specifically for accessing menus quickly and manipulating databases
 */

namespace Cyber_353_Project
{
    public partial class SecretMenu : Form
    {
        public SecretMenu()
        {
            InitializeComponent();
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            AddUser addUserForm = new AddUser();
            addUserForm.Show();
        }

        private void ActivityMonitorBtn_Click(object sender, EventArgs e)
        {
            ActivityMonitor activity = new ActivityMonitor();
            activity.Show();
        }

        private void RDBtn_Click(object sender, EventArgs e)
        {
            RemoteDesktopConnection rdp = new RemoteDesktopConnection();
            rdp.Show();
        }

        private void NotificationTestBtn_Click(object sender, EventArgs e)
        {
            NotificationTest nTest = new NotificationTest();
            nTest.Show();
        }
    }
}
