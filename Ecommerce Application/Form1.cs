using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;
using Microsoft.Data.SqlClient;

namespace Ecommerce_Application
{
    public partial class WelcomePage : Form
    {

        //define connection
        SqlConnection connect;
        //define adapter
        SqlDataAdapter adapter;
        //define dataset
        DataSet ds;

        public WelcomePage()
        {
            InitializeComponent();

            //intialize connection
            connect = new SqlConnection(ConfigurationManager.ConnectionStrings["Ecommerce_DB"].ToString());

            adapter = new SqlDataAdapter();

            ds = new DataSet();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            RegistrationForm registerForm = new RegistrationForm();
            registerForm.Show();
            this.Hide();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            //LoginForm loginForm = new LoginForm();
            //loginForm.Show();
            //this.Hide();
        }
    }
}
