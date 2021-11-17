using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cyber_353_Project
{
    public partial class RemoteDesktopConnection : Form
    {
        public RemoteDesktopConnection()
        {
            InitializeComponent();
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            try
            {   
                // requiring the destination user's name and password to
                // ensure that user must consent to connection

                RdpClient.Server = DestIPTxtB.Text;
                RdpClient.UserName = DestUserNameTxtB.Text;
                RdpClient.AdvancedSettings2.ClearTextPassword = DestPassTxtB.Text;
                RdpClient.AdvancedSettings7.EnableCredSspSupport = true;
                RdpClient.Connect();
            }
            catch
            {
                MessageBox.Show("Error in connection- please try again and ensure all values are correct");
            }
            finally // always want the logging function to execute, even if connection fails
            {
                Utils.RdpAttemptRecord(DestUserNameTxtB.Text, DestIPTxtB.Text);
            }
            
            


        }

        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            if (RdpClient.Connected == 1)
            //cannot disconnect from a client that hasn't been connected to yet
            {
                RdpClient.Disconnect();
            }
        }
    }
}
