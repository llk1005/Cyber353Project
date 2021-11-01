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

        public static bool AddLoginData(string userName, string password, string role, string name, string email, string phone, string carrier)
        {
            connectionString = ConfigurationManager.ConnectionStrings["Cyber_353_Project.Properties.Settings.Database1ConnectionString"].ConnectionString;

            string query = "INSERT INTO LoginData VALUES (@UserName, @Password, @Role, 'FALSE', @Name, @Email, @Phone, @Carrier)";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@UserName", userName);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Role", role);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@Carrier", carrier);

                    command.ExecuteNonQuery();

                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public static bool checkLoginInfo(string userName, string password)
        {
            connectionString = ConfigurationManager.ConnectionStrings["Cyber_353_Project.Properties.Settings.Database1ConnectionString"].ConnectionString;

            string query = "SELECT * FROM LoginData WHERE UserName = @UserName;";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@UserName", userName);

                SqlDataReader reader = command.ExecuteReader();

                reader.Read();

                try
                {
                    if (reader[1].ToString() == password)
                    {
                        return true;
                    }
                }
                catch
                {
                    return false;
                }

            }
           return false;
        }
    }
}
