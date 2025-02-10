using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.DataAccess;

namespace Employee.BusinessLogic
{
    public class UserService
    {
        private UserDataAccess userDataAccess;

        public UserService()
        {
            userDataAccess = new UserDataAccess();
        }

        public DataTable GetAllUsers()
        {
            return userDataAccess.GetUsers();
        }

        public bool AddUsers(string userName, string password, string email, int age, string address, string role)
        {
            return userDataAccess.InsertUsers(userName, password, email, age, address, role);
        }

        public bool DeleteUsers(int userId)
        {
            return userDataAccess.DeleteUsers(userId);
        }

        public bool UpdateUsers(int userId, string userName, string password, string email, int age, string address, string role)
        {
            return userDataAccess.UpdateUsers(userId, userName, password, email, age, address,role);
        }
    }
}
