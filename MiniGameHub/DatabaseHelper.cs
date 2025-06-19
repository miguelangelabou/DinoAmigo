using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Text;

namespace MiniGameHub
{
    public class DatabaseHelper
    {
        // IMPORTANT: User must configure this connection string.
        private static readonly string connectionString = "server=YOUR_SERVER;user=YOUR_USER;database=minigamehub_db;port=3306;password=YOUR_PASSWORD;";

        /// <summary>
        /// Creates and returns a new MySqlConnection.
        /// </summary>
        /// <returns>A MySqlConnection object.</returns>
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        /// <summary>
        /// Hashes a password using SHA256.
        /// </summary>
        /// <param name="password">The password to hash.</param>
        /// <returns>The SHA256 hashed password as a hex string.</returns>
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        /// <summary>
        /// Registers a new user in the database.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="passwordHash">The pre-hashed password.</param>
        /// <returns>True if registration is successful, false otherwise.</returns>
        public static bool RegisterUser(string username, string passwordHash)
        {
            using (MySqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO users (username, password_hash) VALUES (@username, @password_hash)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password_hash", passwordHash);
                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
                catch (MySqlException ex)
                {
                    // Handle potential exceptions, e.g., duplicate username (error code 1062)
                    // Console.WriteLine($"MySQL Error {ex.Number}: {ex.Message}");
                    return false;
                }
                catch (Exception ex)
                {
                    // Handle other potential exceptions
                    // Console.WriteLine($"Error: {ex.Message}");
                    return false;
                }
            }
        }

        /// <summary>
        /// Verifies a user's credentials.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="passwordHash">The pre-hashed password to verify.</param>
        /// <returns>True if the username exists and the password hash matches, false otherwise.</returns>
        public static bool VerifyUser(string username, string passwordHash)
        {
            using (MySqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT password_hash FROM users WHERE username = @username";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        string storedHash = result.ToString();
                        return storedHash == passwordHash;
                    }
                    return false; // User not found
                }
                catch (Exception ex)
                {
                    // Handle potential exceptions
                    // Console.WriteLine($"Error: {ex.Message}");
                    return false;
                }
            }
        }
    }
}
