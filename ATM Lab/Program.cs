using System;

namespace ATM_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM();


            while (true)
            {
                Console.WriteLine("Would you like to Login (1) or Register? (2) ");

                var userResponse = Console.ReadLine();

                if (userResponse == "1")
                {
                    Console.WriteLine("Enter in a user name");
                    var userName = Console.ReadLine();

                    Console.WriteLine("Enter a password");
                    var userPassword = Console.ReadLine();

                    atm.Login(userName, userPassword);

                    Console.WriteLine($"Thanks for for logging in {atm.LoggedIn.Name}");

                }
                else if (userResponse == "2")
                {
                    Console.WriteLine("Please enter name");
                    var name = Console.ReadLine();

                    Console.WriteLine("Please enter password");
                    var password = Console.ReadLine();
                    atm.Register(name, password);
                }


                bool keepAtming = true;
                while (keepAtming)
                {


                    Console.WriteLine("Please select an action");
                    DisplayMenu();
                    userResponse = Console.ReadLine();

                    int amount = 0;
                    switch (userResponse)
                    {
                        case "1":
                            Console.WriteLine("How much would you like to deposit? ");
                            amount = int.Parse(Console.ReadLine());
                            atm.Deposit(amount);
                            break;
                        case "2":
                            Console.WriteLine("How much would you like to withdraw? ");
                            amount = int.Parse(Console.ReadLine());
                            atm.Withdraw(amount);
                            break;
                        case "3":
                            atm.CheckBalance();
                            break;
                        case "4":
                            atm.Logout();
                            keepAtming = false;
                            Console.Clear();
                            Console.WriteLine("Thank you have a good day!");
                            break;
                        default:
                            Console.WriteLine("Invalid Option");
                            break;
                    }
                }
            }
        }

        public static void DisplayMenu()
        {
            Console.WriteLine("1.) Deposit Money");
            Console.WriteLine("2.) Withdraw");
            Console.WriteLine("3.) Check Balance");
            Console.WriteLine("4.) Logout");
        }
    }
}
