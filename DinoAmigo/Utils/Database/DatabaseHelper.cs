using MySqlConnector;
using System.Security.Cryptography;
using System.Text;

namespace DinoAmigoApp.Utils.Database.DatabaseHelper
{
    public static class DatabaseHelper
    {
        const string ConnStr = "server=localhost;port=3306;user=root;password=;database=minigamehub_db;";

        public static MySqlConnection GetConnection()
            => new MySqlConnection(ConnStr);

        public static string HashPassword(string pwd)
        {
            using var sha256 = SHA256.Create();
            var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(pwd));
            var sb = new StringBuilder(bytes.Length * 2);
            foreach (var b in bytes) sb.Append(b.ToString("x2"));
            return sb.ToString();
        }

        public static async Task<bool> LoginUser(string email, string hash)
        {
            await using var c = GetConnection();
            await c.OpenAsync();
            await using var cmd = new MySqlCommand(
                "SELECT COUNT(*) FROM users WHERE email=@e AND password_hash=@h", c);
            cmd.Parameters.AddWithValue("@e", email);
            cmd.Parameters.AddWithValue("@h", hash);
            var count = Convert.ToInt32(await cmd.ExecuteScalarAsync());
            return count > 0;
        }

        public static async Task<bool> RegisterUser(string username, string email, string hash)
        {
            await using var c = GetConnection();
            await c.OpenAsync();
            await using var cmd = new MySqlCommand(
                "INSERT IGNORE INTO users(username,email,password_hash) VALUES(@u,@e,@h)", c);
            cmd.Parameters.AddWithValue("@u", username);
            cmd.Parameters.AddWithValue("@e", email);
            cmd.Parameters.AddWithValue("@h", hash);
            return await cmd.ExecuteNonQueryAsync() > 0;
        }
    }
}



