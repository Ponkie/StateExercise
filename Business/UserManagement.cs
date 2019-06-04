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

        public void AddUser(string username, string firstName, string lastName)
        {
            UserRepository userRep = new UserRepository();
            user.EntityId = new Guid();
            user.FirstName = firstName;
            user.LastName = lastName;

            userRep.AddUser(user);
        }

    }
}
