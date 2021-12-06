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

/*
 * Add user is used to add a user to the database
 * This method will be removed if the project is shipped
 * as it is part of the 'secret menu'
 */

namespace Cyber_353_Project
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            string carrier = "ATT";
            string encryptedPassword;

            encryptedPassword = Utils.SHA256_hash(PasswordBox.Text);

            if (DatabaseManager.AddLoginData(UserNameBox.Text, encryptedPassword, RoleBox.Text, NameBox.Text, EmailBox.Text, PhoneBox.Text, carrier))
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
