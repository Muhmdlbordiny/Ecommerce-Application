using System.Data;
using Employee.DataAccess;

namespace Employee.BusinessLogic
{
    public class ProductService
    {
        private ProductsDataAccess productsDataAccess;

        public ProductService()
        {
            productsDataAccess = new ProductsDataAccess();
        }

        public DataTable GetAllProducts()
        {
            return productsDataAccess.GetProducts();
        }

        public bool AddProduct(string productName, decimal price, int categoryId)
        {
            return productsDataAccess.InsertProduct(productName, price, categoryId);
        }

        public bool RemoveProduct(int productId)
        {
            return productsDataAccess.DeleteProduct(productId);
        }

        public bool ModifyProduct(int productId, string productName, decimal price, int categoryId)
        {
            return productsDataAccess.UpdateProduct(productId, productName, price, categoryId);
        }
    }
}
