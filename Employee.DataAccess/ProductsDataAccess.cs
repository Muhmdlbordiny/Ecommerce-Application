using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Employee.DataAccess
{
    public class ProductsDataAccess
    {
        private string connectionString = "Server=.;Database=Ecommerce_DB;Trusted_Connection=True;TrustServerCertificate=True";

        public DataTable GetProducts()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Products";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable productsTable = new DataTable();
                adapter.Fill(productsTable);
                return productsTable;
            }
        }

        public bool InsertProduct( string productName, decimal price, int categoryId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                string query = "INSERT INTO Products (ProductName, Price, CategoryId) VALUES (@ProductName, @Price, @CategoryId)";
                SqlCommand command = new SqlCommand(query, connection);
                //command.Parameters.AddWithValue("@ProductId", productId);
                command.Parameters.AddWithValue("@ProductName", productName);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@CategoryId", categoryId);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteProduct(int productId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Products WHERE ProductId = @ProductId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductId", productId);
                connection.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateProduct(int productId, string productName, decimal price, int categoryId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Products SET ProductName = @ProductName, Price = @Price, CategoryId = @CategoryId WHERE ProductId = @ProductId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductId", productId);
                command.Parameters.AddWithValue("@ProductName", productName);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@CategoryId", categoryId);
                connection.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }
    }
}
