using System;
using Entity;
using Business;
using Repository;
using System.Collections.Generic;

namespace SocialMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManagement userMan = new UserManagement();
            string firstName, lastName, username;
            username = Console.ReadLine();
            firstName = Console.ReadLine();
            lastName = Console.ReadLine();

            userMan.AddUser(username, firstName, lastName);
 

            
        }
    }
}
