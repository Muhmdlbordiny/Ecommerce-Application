using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employee.BusinessLogic;

namespace Employee.Presentation
{
    public partial class ProductForm : Form
    {
        private ProductService productService;
        public ProductForm()
        {
            InitializeComponent();
            productService = new ProductService();
            LoadProducts();
        }
        private void LoadProducts()
        {
            ProductsDataGridView.DataSource = productService.GetAllProducts();
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            string productName = ProductNameTextBox.Text;
            decimal price = decimal.Parse(PriceTextBox.Text);
            int categoryId = int.Parse(CategoryIdTextBox.Text);

            if (productService.AddProduct(productName, price, categoryId))
            {
                MessageBox.Show("Product added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProducts();
            }
            else
            {
                MessageBox.Show("Failed to add product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            int productId = int.Parse(ProductIdTextBox.Text);

            if (productService.RemoveProduct(productId))
            {
                MessageBox.Show("Product deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProducts();
            }
            else
            {
                MessageBox.Show("Failed to delete product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateProduct_Click(object sender, EventArgs e)
        {
            int productId = int.Parse(ProductIdTextBox.Text);
            string productName = ProductNameTextBox.Text;
            decimal price = decimal.Parse(PriceTextBox.Text);
            int categoryId = int.Parse(CategoryIdTextBox.Text);

            if (productService.ModifyProduct(productId, productName, price, categoryId))
            {
                MessageBox.Show("Product updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProducts();
            }
            else
            {
                MessageBox.Show("Failed to update product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void ProductsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ProductsDataGridView.Rows[e.RowIndex];

                ProductIdTextBox.Text = row.Cells["ProductId"].Value.ToString();
                ProductNameTextBox.Text = row.Cells["ProductName"].Value.ToString();
                PriceTextBox.Text = row.Cells["Price"].Value.ToString();
                CategoryIdTextBox.Text = row.Cells["CategoryId"].Value.ToString();
            }

        }

        private void Back_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Close();
        }
    }
}
