using System;
using Entity;
using Business;
using System.Collections.Generic;

namespace SocialMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> user = new List<User>();
            UserManagement userMan = new UserManagement();
            string firstName, lastName, username;

            username = Console.ReadLine();
            firstName = Console.ReadLine();
            lastName = Console.ReadLine();

            userMan.AddUser(username, firstName, lastName);

            foreach (var list in user)
            {
                Console.WriteLine("{0} {1} {2}", list.Username, list.FirstName, list.LastName);
            }

            
        }
    }
}
