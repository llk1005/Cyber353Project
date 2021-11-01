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

        public static bool AddLoginData(string userName, string password, string role, string accountLocked)
        {
            connectionString = ConfigurationManager.ConnectionStrings["Cyber_353_Project.Properties.Settings.Database1ConnectionString"].ConnectionString;

            string query = "INSERT INTO LoginData VALUES (@UserName, @Password, @Role, 'FALSE')";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@UserName", userName);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Role", role);

                    command.ExecuteNonQuery();

                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
