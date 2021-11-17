using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Cyber_353_Project
{
    public partial class SecondFA : Form
    {
        private string email;
        private int number;

        /*
         * Second Factor Authentication form
         * Takes email as parameter
         * On load, sends code to user's email
         */
        public SecondFA(string email)
        {
            InitializeComponent();

            // Initialize instance of Random class
            Random rand = new Random();

            // Sets email to email parameter
            this.email = email;
            
            // Generates random number between 100000 and 999999
            number = rand.Next(100000, 1000000);

            try
            {
                // Sends code to user's email
                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("fullemail");
                mail.To.Add(email);
                mail.Subject = "Authentication Code";
                mail.Body = "Hello, \n\nYour authentication code is: " + number.ToString();

                smtpServer.Port = 587;
                smtpServer.Credentials = new System.Net.NetworkCredential("username", "password");
                smtpServer.EnableSsl = true;

                smtpServer.Send(mail);
            }
            catch (Exception exc)
            {
                // Message shown if email cannot be sent
                MessageBox.Show("Error\n" + exc.ToString());
            }
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (AuthCodeTxtBox.Text == number.ToString())
            {
                UserMainMenu menu = new UserMainMenu();

                menu.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid code!");
            }
        }
    }
}
