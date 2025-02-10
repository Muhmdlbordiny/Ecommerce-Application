using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Employee.DataAccess
{
    public class CategoriesDataAccess
    {
        private string connectionString = "Server=.;Database=Ecommerce_DB;Trusted_Connection=True;TrustServerCertificate=True";

        public DataTable GetCategories()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Categories";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable categoriesTable = new DataTable();
                adapter.Fill(categoriesTable);
                return categoriesTable;
            }
        }

        public bool InsertCategory(string categoryName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Categories (CategoryName) VALUES (@CategoryName)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CategoryName", categoryName);

                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteCategory(int categoryId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Categories WHERE CategoryId = @CategoryId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CategoryId", categoryId);
                connection.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateCategory(int categoryId, string categoryName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Categories SET CategoryName = @CategoryName WHERE CategoryId = @CategoryId";
                SqlCommand command = new SqlCommand(query, connection);                
                command.Parameters.AddWithValue("@CategoryId", categoryId);
                command.Parameters.AddWithValue("@CategoryName", categoryName);
                connection.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }
    }
}
