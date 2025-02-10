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
    public partial class CategoriesForm : Form
    {
        private CategoriesService categoriesService;
        public CategoriesForm()
        {
            InitializeComponent();
            categoriesService = new CategoriesService();
            LoadCategories();
        }
        private void LoadCategories()
        {
            CategoriesDataGridView.DataSource = categoriesService.GetAllCategories();
        }

        private void AddCategory_Click(object sender, EventArgs e)
        {
            string categoryName = CategoryNameTextBox.Text;

            if (string.IsNullOrWhiteSpace(categoryName))
            {
                MessageBox.Show("Please enter a category name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool isAdded = categoriesService.AddCategory(categoryName);
            if (isAdded)
            {
                MessageBox.Show("Category added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCategories();
            }
            else
            {
                MessageBox.Show("Failed to add category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CategoriesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = CategoriesDataGridView.Rows[e.RowIndex];

                CategoryIdTextBox.Text = row.Cells["CategoryId"].Value.ToString();
                CategoryNameTextBox.Text = row.Cells["CategoryName"].Value.ToString();

            }
        }

        private void UpdateCategory_Click(object sender, EventArgs e)
        {
            int productId = int.Parse(CategoryIdTextBox.Text);
            string categoryName = CategoryNameTextBox.Text;

            if (categoriesService.UpdateCategory(productId, categoryName))
            {
                MessageBox.Show("Category updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCategories();
            }
            else
            {
                MessageBox.Show("Failed to update category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteCategory_Click(object sender, EventArgs e)
        {
            int productId = int.Parse(CategoryIdTextBox.Text);

            if (categoriesService.DeleteCategory(productId))
            {
                MessageBox.Show("Category deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCategories();
            }
            else
            {
                MessageBox.Show("Failed to delete category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Close();
        }

        private void CategoryNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
