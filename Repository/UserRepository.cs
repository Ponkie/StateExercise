using System;
using System.Collections.Generic;
using System.Text;
using Entity;

namespace Repository
{
    public class UserRepository
    {
        public List<User> UserList = new List<User>()
        {
            new User
            {
                EntityId = new Guid(),
                Username = "Ponkie",
                FirstName = "Dino Angelo",
                LastName = "Reyes"
            }
        };
            
  

        public void AddUser(User user)
        {
            UserList.Add(user);
        }

        public void EditUser(User user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
