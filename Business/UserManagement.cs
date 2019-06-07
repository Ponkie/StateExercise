using Entity;
using Repository;
using System;
using System.Collections.Generic;

namespace Business
{
    public class UserManagement
    {
        User user = new User();
        private State _state;
        private string _user;
        UserRepository userRep = new UserRepository();


        public void AddUser(string username, string firstName, string lastName)
        {
            User user = new User
            {
                EntityId = new Guid(),
                Username = username,
                FirstName = firstName,
                LastName = lastName,
            };

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
