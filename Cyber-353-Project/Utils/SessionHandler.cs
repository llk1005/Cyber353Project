using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyber_353_Project
{
    static class SessionHandler
    {
        private static string uid;
        private static string userName;
        private static string role;
        private static string name;
        private static string email;
        private static string phone;
        private static string carrier;

        public static bool Start(string id)
        {
            try
            {
                uid = id;
                userName = DatabaseManager.getUserName(id);
                role = DatabaseManager.getRole(id);
                name = DatabaseManager.getName(id);
                email = DatabaseManager.getEmail(id);
                phone = DatabaseManager.getPhone(id);
                carrier = DatabaseManager.getCarrier(id);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error Starting Session: " + e.ToString());
                return false;
            }
        }

        public static bool Stop()
        {
            uid = "";
            userName = "";
            role = "";
            name = "";
            email = "";
            phone = "";
            carrier = "";
            return true;
        }

        public static string getUid()
        {
            return uid;
        }
        public static string getUserName()
        {
            return userName;
        }
        public static string getRole()
        {
            return role;
        }
        public static string getName()
        {
            return name;
        }
        public static string getEmail()
        {
            return email;
        }
        public static string getPhone()
        {
            return phone;
        }
        public static string getCarrier()
        {
            return carrier;
        }
    }
}
