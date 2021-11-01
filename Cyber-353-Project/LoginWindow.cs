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
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            RemoteDesktopConnection rdp = new RemoteDesktopConnection();
            rdp.Show();

        }

        private void SecretMenuBtn_Click(object sender, EventArgs e)
            // this method is purely for testing purposes, inserts data into the database
            // if this project were to be released, this method would not be shipped 
        {
            SecretMenu secret = new SecretMenu();
            secret.Show();
        }
    }
}
