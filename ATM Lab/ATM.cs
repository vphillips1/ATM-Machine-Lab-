using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_Lab
{
   public class ATM
   {
        public List<Account> Accounts { get; set; }

        public Account LoggedIn { get; set; }

        public ATM()
        {
            Accounts = new List<Account>
            {
                new Account("steve", "password!"),
                new Account("verkeia", "Hello1234"),
                new Account("Jeffrey", "simple2"),
            };

        }

        public void Register (string name,string password)
        {
            var account = new Account(name, password);

            Accounts.Add(account);

           
        }

        
        public void Login(string userName, string password)
        {
            foreach (var account in Accounts)
            {
                if(account.Name == userName && account.Password == password)
                {
                    LoggedIn = account;
                    break;
                }
            }

        }
           

        public void Logout()

        {
            LoggedIn = null;

        }

        public void CheckBalance()

        {
            Console.WriteLine($"{LoggedIn.Balance:C2}");

        }

        public void Deposit(int amount)

        {
            LoggedIn.Balance += amount;

            
        }

        public void Withdraw(int amount)

        {
            if (LoggedIn.Balance >= amount)
            {
                LoggedIn.Balance -= amount;

            }

        }
        


   }
}
