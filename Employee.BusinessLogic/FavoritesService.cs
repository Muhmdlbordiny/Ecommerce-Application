using System.Data;
using Employee.DataAccess;

namespace Employee.BusinessLogic
{
    public class FavoritesService
    {
        private FavoritesDataAccess favoritesDataAccess;

        public FavoritesService()
        {
            favoritesDataAccess = new FavoritesDataAccess();
        }

        public bool AddProductToFavorites(int userId, int productId)
        {
            try
            {
                return favoritesDataAccess.AddToFavorites(userId, productId);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while adding the product to favorites.", ex);
            }
        }

        public DataTable GetUserFavorites(int userId)
        {
            try
            {
                return favoritesDataAccess.GetFavorites(userId);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching the favorites.", ex);
            }
        }

        public bool RemoveProductFromFavorites(int userId, int productId)
        {
            try
            {
                return favoritesDataAccess.RemoveFromFavorites(userId, productId);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while removing from favorites.", ex);
            }
        }

    }

}
