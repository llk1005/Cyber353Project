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
 * LoginWindow is shown on initial startup
 * Allows the user to login and when credentials
 * are accepted, 2 factor authentication is displayed
 */

namespace Cyber_353_Project
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        // Used for encrypting the user's password
        // TODO: Move to Utils class
        

        // Called when login button is clicked
        private void LoginBtn_Click(object sender, EventArgs e)
        {  
            // Password is encrypted
            string encryptedPassword;

            encryptedPassword = Utils.sha256_hash(PasswordTxtBox.Text);
            Utils.LoginAttemptRecord(UserTxtBox.Text);    // logs a login attempt from IP and with username

            // Checks if username and encrypted password are in database
            if (DatabaseManager.checkLoginInfo(UserTxtBox.Text, encryptedPassword))
            {
                string uid = DatabaseManager.getUserId(UserTxtBox.Text, encryptedPassword);

                // If so, 2FA form is started sending user's email as parameter
                //   SecondFA fa2 = new SecondFA(DatabaseManager.getEmail(uid), uid);
                //   fa2.Show();

                SessionHandler.Start(uid);

                UserMainMenu main = new UserMainMenu();
                main.Show();

                // This form is hidden
                this.Hide();  


            }
            else
            {
                // If the uername and password are not found, a message saying incoorect credentials is shown
                MessageBox.Show("Incorrect Credentials");
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
