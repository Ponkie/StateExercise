using System;

namespace testing
{
    /// <summary>

    /// MainApp startup class for Real-World 

    /// State Design Pattern.

    /// </summary>

    class MainApp

    {
        /// <summary>

        /// Entry point into console application.

        /// </summary>

        static void Main()
        {
            // Open a new account

            Account account = new Account("Jim Johnson");

            // Apply financial transactions
            int amt = 0;
            while (true)
            {
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Interest");
                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("Enter Amount: ");
                    amt = int.Parse(Console.ReadLine());
                    account.Deposit(amt);
                }
                else if (choice==2)
                {
                    Console.Write("Enter Amount: ");
                    amt = int.Parse(Console.ReadLine());
                    account.Withdraw(amt);
                }
                else if (choice==3) account.PayInterest();
                
            }
        }
    }

  

    
    

 
    
}