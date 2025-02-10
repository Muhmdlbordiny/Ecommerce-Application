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
    public partial class UesrForm : Form
    {
        private UserService userService;
        public UesrForm()
        {

            InitializeComponent();
            this.Load += new System.EventHandler(this.UesrForm_Load);
            ShowPassword.CheckedChanged += new EventHandler(ShowPassword_CheckedChanged);
            userService = new UserService();
            LoadUsers();
            LoadRoles();
        }

        private void LoadRoles()
        {
            DataTable rolesTable = new DataTable();
            rolesTable.Columns.Add("RoleName", typeof(string));
            rolesTable.Columns.Add("RoleValue", typeof(string));

            rolesTable.Rows.Add("Admin", "Admin");
            rolesTable.Rows.Add("User", "User");

            RoleComboBox.DataSource = rolesTable;
            RoleComboBox.DisplayMember = "RoleName";
            RoleComboBox.ValueMember = "RoleValue";
        }

        private void LoadUsers()
        {
            UsersDataGridView.DataSource = userService.GetAllUsers();
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            string userName = UserNameTextBox.Text;
            string password = UserPasswordTextBox.Text;
            string email = EmailTextBox.Text;
            int age = (int)AgeUpDown.Value;
            string address = AddressTextBox.Text;
            string role = RoleComboBox.SelectedValue.ToString();

            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(role) || age <= 0)
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isAdded = userService.AddUsers(userName, password, email, age, address, role);
            if (isAdded)
            {
                MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers();
            }
            else
            {
                MessageBox.Show("Failed to add user. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateUser_Click(object sender, EventArgs e)
        {
            int userId = int.Parse(UserIdTextBox.Text);
            string userName = UserNameTextBox.Text;
            string password = UserPasswordTextBox.Text;
            string email = EmailTextBox.Text;
            int age = (int)AgeUpDown.Value;
            string address = AddressTextBox.Text;
            string role = RoleComboBox.SelectedValue.ToString();

            if (userService.UpdateUsers(userId, userName, password, email, age, address, role))
            {
                MessageBox.Show("User updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers();
            }
            else
            {
                MessageBox.Show("Failed to update user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            int userId = int.Parse(UserIdTextBox.Text);

            if (userService.DeleteUsers(userId))
            {
                MessageBox.Show("User deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers();
            }
            else
            {
                MessageBox.Show("Failed to delete user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UesrForm_Load(object sender, EventArgs e)
        {
            LoadRoles();
            UserPasswordTextBox.PasswordChar = '*';

        }

        private void UsersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = UsersDataGridView.Rows[e.RowIndex];

                UserIdTextBox.Text = row.Cells["UserId"].Value.ToString();
                UserNameTextBox.Text = row.Cells["UserName"].Value.ToString();
                EmailTextBox.Text = row.Cells["Email"].Value.ToString();
                UserPasswordTextBox.Text = row.Cells["Password"].Value.ToString();
                AddressTextBox.Text = row.Cells["Address"].Value.ToString();
                AgeUpDown.Text = row.Cells["Age"].Value.ToString();
                RoleComboBox.Text = row.Cells["Role"].Value.ToString();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Close();
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked)
            {
                UserPasswordTextBox.PasswordChar = '\0';  
            }
            else
            {
                UserPasswordTextBox.PasswordChar = '*';  
            }
        }
    }
}
