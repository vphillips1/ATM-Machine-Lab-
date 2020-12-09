using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_Lab
{
    public class Account
    {
        public string Name { get; set; }
        
        public string Password { get; set; }

        public int Balance { get; set; }
        



        public Account(string name, string password)
        {
            Name = name;
            Password = password;
            Balance = 0;
        }
    }
}
