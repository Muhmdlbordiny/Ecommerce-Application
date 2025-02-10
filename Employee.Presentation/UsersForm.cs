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
    public partial class UsersForm : Form
    {
        private int currentUserId;
        private ProductService productService;
        private FavouritesForm favouritesForm;
        private UsersService usersService;
        private FavoritesService favouritesService;

        public UsersForm(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
            productService = new ProductService();
            favouritesForm = new FavouritesForm(userId);
            usersService = new UsersService();
            favouritesService = new FavoritesService();
        }

        private void LoadProducts()
        {
            ProductsDataGridView.DataSource = productService.GetAllProducts();
        }


        private void ViewProducts_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }


        private void AddProductToFavourite_Click(object sender, EventArgs e)
        {
            try
            {
                int productId = Convert.ToInt32(ProductIdTextBox.Text);

                if (favouritesService.AddProductToFavorites(currentUserId, productId))
                {
                    MessageBox.Show("Product added to favourites successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to add product to favourites", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("This product has already been added to favorites", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        

        private void OpenMyFavourites_Click(object sender, EventArgs e)
        {
            FavouritesForm favoritesForm = new FavouritesForm(currentUserId); 
            favoritesForm.Show();
            this.Hide();

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

        private void BackButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
