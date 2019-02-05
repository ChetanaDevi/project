using Demo.DataAccess;
using Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Business
{
    public class UserManager
    {
        UserRepository userRepository = new UserRepository();

        public bool ValidateUser(string username,string password)
        {
            User user = userRepository.GetUserByName(username);
            if (user != null)
                return user.Username == username && user.Password == password;
            else
                return false;
        }
    }
}
