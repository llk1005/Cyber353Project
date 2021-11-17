using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;


namespace Cyber_353_Project
{
    static class NotificationHandler
    {

        private static string from = "email";
        private static string user = "username";
        private static string pass = "password";

        public static bool SendMessage(string message)
        {

            return true;
        }

        public static bool SendText(string message, string phone, string carrier)
        {
            try
            {
                // Sends code to user's email
                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(from);
                mail.To.Add(phone + "@txt.att.net");
                mail.Subject = "Alert!";
                mail.Body = message;

                smtpServer.Port = 587;
                smtpServer.Credentials = new System.Net.NetworkCredential(user, pass);
                smtpServer.EnableSsl = true;

                smtpServer.Send(mail);

                return true;
            }
            catch
            {
                // Message shown if email cannot be sent
                return false;
            }
        }

        public static bool SendEmail(string message, string email)
        {
            try
            {
                // Sends code to user's email
                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(from);
                mail.To.Add(email);
                mail.Subject = "Alert!";
                mail.Body = message;

                smtpServer.Port = 587;
                smtpServer.Credentials = new System.Net.NetworkCredential(user, pass);
                smtpServer.EnableSsl = true;

                smtpServer.Send(mail);

                return true;
            }
            catch (Exception exc)
            {
                // Message shown if email cannot be sent
                Console.WriteLine(exc.Message);
                return false;
            }
        }

        public static void SendFullNotification(string message)
        {
            List<Array> list;
            list = DatabaseManager.getContactInfo();

            foreach(string[] info in list)
            {
                SendEmail(message, info[0]);
                //SendText(message, info[1], info[2]);
            }
        }

    }
}
