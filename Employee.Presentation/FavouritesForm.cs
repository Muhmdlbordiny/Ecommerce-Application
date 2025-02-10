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
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;

namespace Employee.Presentation
{
    public partial class FavouritesForm : Form
    {
        private FavoritesService favoritesService;
        public int currentUserId;
        public FavouritesForm(int userId)
        {
            InitializeComponent();
            favoritesService = new FavoritesService();
            currentUserId = userId;
            LoadFavorites();
        }

        private void LoadFavorites()
        {
            try
            {
                FavouritesGridView.DataSource = favoritesService.GetUserFavorites(currentUserId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading favorites: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void Back_Click(object sender, EventArgs e)
        {

            UsersForm usersForm = new UsersForm(currentUserId);
            usersForm.Show();
            this.Hide();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (FavouritesGridView.SelectedRows.Count > 0)
                {
                    int productId = Convert.ToInt32(FavouritesGridView.SelectedRows[0].Cells["ProductId"].Value);

                    if (favoritesService.RemoveProductFromFavorites(currentUserId, productId))
                    {
                        MessageBox.Show("Product removed from favourites successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadFavorites();
                    }
                    else
                    {
                        MessageBox.Show("Failed to remove product from favourites", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a product to remove", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FavouritesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
