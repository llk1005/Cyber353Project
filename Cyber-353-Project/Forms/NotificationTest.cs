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
    public partial class NotificationTest : Form
    {
        public NotificationTest()
        {
            InitializeComponent();
        }

        private void sendTxtBtn_Click(object sender, EventArgs e)
        {
            if (NotificationHandler.SendText(MessageTxtBox.Text, PhoneTxtBox.Text, "ATT"))
            {
                MessageBox.Show("Text Message Sent");
            }
            else
            {
                MessageBox.Show("Failed to send message");
            }
        }

        private void sendEmailBtn_Click(object sender, EventArgs e)
        {
            if (NotificationHandler.SendEmail(MessageTxtBox.Text, EmailTxtBox.Text))
            {
                MessageBox.Show("Email Sent");
            }
            else
            {
                MessageBox.Show("Failed to send email");
            }
        }

        private void SendFull_Click(object sender, EventArgs e)
        {
            NotificationHandler.SendFullNotification(MessageTxtBox.Text);
        }
    }
}
