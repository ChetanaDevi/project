using Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DataAccess
{
    public class UserRepository
    {
        List<User> users = new List<User> {
                           new User {Username="demo",Password="demo" } };
        public User GetUserByName(string userName)
        {
            return users.Where(u => u.Username == userName).SingleOrDefault();
        }
    }
}
