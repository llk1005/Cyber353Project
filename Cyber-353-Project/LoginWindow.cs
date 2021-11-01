using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Cyber_353_Project
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

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

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            string encryptedPassword;

            encryptedPassword = sha256_hash(PasswordTxtBox.Text);

            if (DatabaseManager.checkLoginInfo(UserTxtBox.Text, encryptedPassword))
            {
                MessageBox.Show("Works!");
            }
            else
            {
                MessageBox.Show("Not Working");
            }

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
