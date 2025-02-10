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
    public partial class LoginForm : Form
    {
        private UsersService usersService;

        public LoginForm()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ShowPassword.CheckedChanged += new EventHandler(ShowPassword_CheckedChanged);
            usersService = new UsersService();
            LoadRoles();
        }

        private void LoadRoles()
        {
            DataTable rolesTable = new DataTable();
            rolesTable.Columns.Add("RoleName", typeof(string));
            rolesTable.Rows.Add("Admin");
            rolesTable.Rows.Add("User");

            comboBoxRole.DataSource = rolesTable;
            comboBoxRole.DisplayMember = "RoleName";
            comboBoxRole.ValueMember = "RoleName";
        }

        private void Login_Click(object sender, EventArgs e)
        {

            try
            {
                string email = EmailTextBox.Text;
                string password = LoginPasswordTextBox.Text;
                string role = comboBoxRole.SelectedValue?.ToString() ?? string.Empty;

                //MessageBox.Show("Selected Role: " + role);

                if (string.IsNullOrEmpty(role))
                {
                    MessageBox.Show("Please select a role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool isLoggedIn;
                int userId;
                bool isAdmin;

                bool result = usersService.Login(email, password, out isLoggedIn, out userId, out isAdmin, role);

                if (result && isLoggedIn)
                {
                    if ((role == "Admin" && isAdmin) || (role == "User" && !isAdmin))
                    {
                        MessageBox.Show($"Login successful! User ID: {userId}, Admin: {isAdmin}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (isAdmin)
                        {
                            AdminForm adminForm = new AdminForm();
                            adminForm.Show();
                        }
                        else
                        {
                            UsersForm userForm = new UsersForm(userId);
                            userForm.Show();
                        }

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Role does not match the credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid credentials. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            LoadRoles();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            WelcomeForm welcomeForm = new WelcomeForm();
            welcomeForm.Show();
            this.Hide();
        }

        private void RegisterHere_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            this.Hide();
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked)
            {
                LoginPasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                LoginPasswordTextBox.PasswordChar = '*';
            }
        }
    }
}
