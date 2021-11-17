using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Numerics;

/*
 * DatabaseManager contains
 * static methods that interact with the database
 */

namespace Cyber_353_Project
{
    class DatabaseManager
    {

        // Adds user data to the database
        public static bool AddLoginData(string userName, string password, string role, string name, string email, string phone, string carrier)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Cyber_353_Project.Properties.Settings.Database1ConnectionString"].ConnectionString;

            string query = "INSERT INTO LoginData VALUES (@UserName, @Password, @Role, 'FALSE', @Name, @Email, @Phone, @Carrier)";

            using (SqlConnection connection = new SqlConnection(connectionString))
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

                    connection.Close();

                    return true;
                }
                catch
                {
                    connection.Close();
                    return false;
                }
            }
        }

        // Gets the email of the user
        public static List<Array> getContactInfo()
        {
            List<Array> users = new List<Array>();

            string connectionString = ConfigurationManager.ConnectionStrings["Cyber_353_Project.Properties.Settings.Database1ConnectionString"].ConnectionString;

            string query = "SELECT * FROM LoginData;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string[] array = new string[3];

                    array[0] = reader[6].ToString();
                    array[1] = reader[7].ToString();
                    array[2] = reader[8].ToString();

                    users.Add(array);
                }

                return users;
            }
        }

        // Checks if login data is contained in the database
        public static bool checkLoginInfo(string userName, string password)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Cyber_353_Project.Properties.Settings.Database1ConnectionString"].ConnectionString;

            string query = "SELECT * FROM LoginData WHERE UserName = @UserName and Password = @Password;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@UserName", userName);
                command.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    connection.Close();
                    return true;
                }

                connection.Close();
                return false;
            }
            
        }

        // Gets the email of the user
        public static string getUserId(string userName, string password)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Cyber_353_Project.Properties.Settings.Database1ConnectionString"].ConnectionString;

            string query = "SELECT * FROM LoginData WHERE UserName = @UserName and Password = @Password;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@UserName", userName);
                command.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = command.ExecuteReader();

                reader.Read();

                return reader[0].ToString();
            }
        }

        // Gets the email of the user
        public static string getEmail(string uid)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Cyber_353_Project.Properties.Settings.Database1ConnectionString"].ConnectionString;

            string query = "SELECT * FROM LoginData WHERE Id = @Id;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@Id", uid);

                SqlDataReader reader = command.ExecuteReader();

                reader.Read();

                return reader[6].ToString();
            }
        }

        // Gets the phone number of the user
        public static string getPhone(string uid)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Cyber_353_Project.Properties.Settings.Database1ConnectionString"].ConnectionString;

            string query = "SELECT * FROM LoginData WHERE Id = @Id;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@Id", uid);

                SqlDataReader reader = command.ExecuteReader();

                reader.Read();

                return reader[7].ToString();
            }
        }
    }    
}

