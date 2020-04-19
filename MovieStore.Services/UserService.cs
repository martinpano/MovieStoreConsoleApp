using MovieStore.Domain;
using MovieStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Services
{
    public class UserService
    {
        HelperService _helperService = new HelperService();
        public User[] Users = new User[]
        {
            new User("John", "Doe", 35, "john_doe", "123123", 070223443, new DateTime(2020, 01, 02)),
            new User("Jane", "Janesky", 30, "jane_janesky", "111111", 078446772, new DateTime(2019, 09, 01)),
            new User("Bob", "Bobsky", 26, "bob_bobsky", "121212", 078333888, new DateTime(2020, 02, 02)),
            new User("Tommy", "Shelby", 31, "tommy_shelby", "223344", 077334223, new DateTime(2019, 06, 01)),
        };

        public User[] GetAllMembers()
        {
            return Users;
        }
        
        public void RegisterMember(User user)
        {

        }

        public bool IsValid(User user)
        {
            if(user != null)
            {
                if (user.FirstName == null || user.LastName == null || user.UserName == null || user.Password == null)
                {
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }
           
        }
    }
}
