using System.Data;
using Employee.DataAccess;

namespace Employee.BusinessLogic
{
    public class CategoriesService
    {
        private CategoriesDataAccess categoriesDataAccess;

        public CategoriesService()
        {
            categoriesDataAccess = new CategoriesDataAccess();
        }

        public DataTable GetAllCategories()
        {
            return categoriesDataAccess.GetCategories();
        }

        public bool AddCategory(string categoryName)
        {
            return categoriesDataAccess.InsertCategory(categoryName);
        }

        public bool DeleteCategory(int categoryId)
        {
            return categoriesDataAccess.DeleteCategory(categoryId);
        }

        public bool UpdateCategory(int categoryId, string categoryName)
        {
            return categoriesDataAccess.UpdateCategory(categoryId, categoryName);
        }

    }
}
