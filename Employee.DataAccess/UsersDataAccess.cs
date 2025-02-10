using System.Data;
using System.Data.SqlClient;
using System.Text;
using Microsoft.Data.SqlClient;

using System.Security.Cryptography;

namespace Employee.DataAccess
{
    public class UsersDataAccess
    {
        private string connectionString = "Server=.;Database=Ecommerce_DB;Trusted_Connection=True;TrustServerCertificate=True";

        //public DataTable GetUsers()
        //{
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        string query = "SELECT * FROM Users";
        //        SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
        //        DataTable usersTable = new DataTable();
        //        adapter.Fill(usersTable);
        //        return usersTable;
        //    }
        //}

        public bool Login(string email, string password, string role)
        {
            try
            {
                string query = "SELECT COUNT(1) FROM Users WHERE Email = @Email AND Password = @Password AND Role = @Role";

                using (SqlConnection conn = new SqlConnection("YourConnectionString"))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Role", role);

                    conn.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }


        public bool InsertUser(string username, string email, string password, int age, string address, string role)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Users (Username, Email, Password, Age, Address, Role) VALUES (@Username, @Email, @Password, @Age, @Address, @Role)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Age", age);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@Role", role);

                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool ValidateUser(string email, string password, out bool isAdmin)
        {
            isAdmin = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT Role FROM Users WHERE Email = @Email AND Password = @Password", connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string role = reader["Role"].ToString();
                    if (role == "Admin")
                    {
                        isAdmin = true;
                    }
                    return true;
                }
                //if (reader.Read())
                //{
                //    string storedHash = reader["Password"].ToString();
                //    string role = reader["Role"].ToString();

                //    if (HashPassword(password) == storedHash)  
                //    {
                //        isAdmin = (role == "Admin");
                //        return true;
                //    }
                //}
            }

            return false;
        }

        public int GetUserIdByEmail(string email)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT UserId FROM Users WHERE Email = @Email", connection);
                command.Parameters.AddWithValue("@Email", email);

                object result = command.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }


        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }
        


    }
}
    
