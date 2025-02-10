using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Employee.DataAccess
{
    public class UserDataAccess
    {
        private string connectionString = "Server=.;Database=Ecommerce_DB;Trusted_Connection=True;TrustServerCertificate=True";

        public DataTable GetUsers()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Users";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable usersTable = new DataTable();
                adapter.Fill(usersTable);
                return usersTable;
            }
        }
        
        public bool InsertUsers(string userName, string password, string email, int age, string address, string role)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string query = "INSERT INTO Users (UserName, Password, Email, Age, Address, Role) VALUES (@UserName, @Password, @Email, @Age, @Address, @Role)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@UserName", userName);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Age", age);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@Role", role);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteUsers(int userId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Users WHERE UserId = @UserId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", userId);
                connection.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateUsers(int userId, string userName, string password, string email, int age, string address, string role)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Users SET UserName = @UserName, Password = @Password, Email = @Email, Age = @Age, Address = @Address, Role = @Role WHERE UserId = @UserId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@UserName", userName);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Age", age);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@Role", role);
                connection.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }
    }
}
