using jwt.Models;
using System.Collections.Generic;
using System.Linq;

namespace jwt.Repositories
{
    public static class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>()
            {
                new User {Id = 1, UserName="bob",Password = "bob", Role = "employee"},
                new User {Id = 1, UserName="barry",Password = "barry", Role = "manager"},
                new User {Id = 1, UserName="jackson",Password = "jackson", Role = "employee"},
            };

            return users.Where(x => x.UserName.ToLower() == username.ToLower() && x.Password.ToLower() == password.ToLower()).FirstOrDefault();
        }
    }
}
