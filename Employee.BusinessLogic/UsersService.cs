using System.Data;
using Employee.DataAccess;

namespace Employee.BusinessLogic
{
    public class UsersService
    {
        private UsersDataAccess usersDataAccess;

        public UsersService()
        {
            usersDataAccess = new UsersDataAccess();
        }

        //public DataTable GetAllUsers()
        //{
        //    return usersDataAccess.GetUsers();
        //}

        public bool RegisterUser(string username, string email, string password, int age, string address, string role)
        {
            return usersDataAccess.InsertUser(username, email, password, age, address, role);
        }

        public bool Login(string email, string password, out bool isLoggedIn, out int userId, out bool isAdmin, string role)
        {
            isLoggedIn = false;
            userId = 0;
            isAdmin = false;

            if (usersDataAccess.ValidateUser(email, password, out isAdmin))
            {
                userId = usersDataAccess.GetUserIdByEmail(email);
                if (userId > 0)
                {
                    isLoggedIn = true;
                    return true;
                }
            }

            return false;
        }

        //public bool AddProduct(int userId, int productId)
        //{
        //    return usersDataAccess.InsertProduct(userId,productId);
        //}
    }
}
