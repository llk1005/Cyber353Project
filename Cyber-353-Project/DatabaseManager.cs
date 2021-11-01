using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace Cyber_353_Project
{
    class DatabaseManager
    {
        private static string connectionString;
        private static SqlConnection connection;

        public static void InitialConnect()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Cyber_353_Project.Properties.Settings.DatabaseConnectionString"].ConnectionString;
        }

        public static bool AddLoginData(string userName, string password, string role, string accountLocked)
        {
            using (connection = new SqlConnection())
            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                connection.Open();

                DataTable loginData = new DataTable();

                adapter.Fill(loginData);

                return true;
            }
        }
    }
}
