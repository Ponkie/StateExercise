using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using Repository;

namespace Business
{
    class UserManagement
    {
        User user = new User();
        private State _state;
        private string _user;
        UserRepository userRep = new UserRepository();

        
        public void AddUser(string username, string firstName, string lastName)
        {
            user.EntityId = new Guid();
            user.Username = username;
            user.FirstName = firstName;
            user.LastName = lastName;

            userRep.AddUser(user);
        }

        public void EditUser(string username)
        {
            user.Username = username;

            userRep.EditUser(user); 
        }

        public void DeleteUser(string username)
        {
            user.Username = username;

            userRep.DeleteUser(user); 
        }

        public void ShowUser(List<User> user)
        {
            foreach (var list in user)
                {
                Console.WriteLine("==================");
                Console.WriteLine(user);
                Console.WriteLine("==================");
                }
        }

    }
}
