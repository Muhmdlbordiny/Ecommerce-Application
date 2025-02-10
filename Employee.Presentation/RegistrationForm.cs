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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Employee.Presentation
{
    public partial class RegistrationForm : Form
    {
        private UsersService usersService;
        public RegistrationForm()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            ShowPassword.CheckedChanged += new EventHandler(ShowPassword_CheckedChanged);
            usersService = new UsersService();
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


        private void Back_Click(object sender, EventArgs e)
        {
            WelcomeForm welcomeForm = new WelcomeForm();
            welcomeForm.Show();
            this.Close();
        }

        private void Register_Click_1(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string email = EmailTextBox.Text;
            string password = PasswordTextBox.Text;
            string address = AddressTextBox.Text;
            int age = (int)AgeUpDown.Value;

            if (RoleComboBox.SelectedValue == null)
            {
                MessageBox.Show("Please select a valid role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string role = RoleComboBox.SelectedValue.ToString();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || age <= 0 || string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isRegistered = usersService.RegisterUser(username, email, password, age, address, role);

            if (isRegistered)
            {
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Registration failed, Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            LoadRoles();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void LoginHere_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked)
            {
                PasswordTextBox.PasswordChar = '\0'; 
            }
            else
            {
                PasswordTextBox.PasswordChar = '*'; 
            }
        }
    }
}
