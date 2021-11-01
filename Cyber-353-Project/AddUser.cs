using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Cyber_353_Project
{
    public partial class AddUser : Form
    {

        private string connectionString;

        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            string carrier = "ATT";
            if (DatabaseManager.AddLoginData(UserNameBox.Text, PasswordBox.Text, RoleBox.Text, NameBox.Text, EmailBox.Text, PhoneBox.Text, carrier))
            {
                MessageBox.Show("User added!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error: Please try again");
            }
        }
    }
}
