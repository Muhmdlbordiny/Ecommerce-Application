using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Employee.DataAccess
{
    public class FavoritesDataAccess
    {
        private string connectionString = "Server=.;Database=Ecommerce_DB;Trusted_Connection=True;TrustServerCertificate=True";

        public bool AddToFavorites(int userId, int productId)
        {
            string query = "INSERT INTO Favorites (UserId, ProductId) VALUES (@UserId, @ProductId)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.Parameters.AddWithValue("@ProductId", productId);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public DataTable GetFavorites(int userId)
        {
            string query = @"
            SELECT P.ProductId, P.ProductName, P.Price, P.CategoryId
            FROM Favorites F
            INNER JOIN Products P ON F.ProductId = P.ProductId
            WHERE F.UserId = @UserId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        public bool RemoveFromFavorites(int userId, int productId)
        {
            string query = "DELETE FROM Favorites WHERE UserId = @UserId AND ProductId = @ProductId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.Parameters.AddWithValue("@ProductId", productId);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0; 
                }
            }
        }

    }

}
