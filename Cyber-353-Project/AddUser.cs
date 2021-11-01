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
using System.Security.Cryptography;

namespace Cyber_353_Project
{
    public partial class AddUser : Form
    {

        private string connectionString;

        public static String sha256_hash(String password)
        {
            StringBuilder sb = new StringBuilder();
            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(password));

                foreach (Byte b in result)
                {
                    sb.Append(b.ToString("x2"));
                }
            }
            return sb.ToString();
        }

        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            string encryptedPassword;

            encryptedPassword = sha256_hash(PasswordBox.Text);

            string carrier = "ATT";
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
