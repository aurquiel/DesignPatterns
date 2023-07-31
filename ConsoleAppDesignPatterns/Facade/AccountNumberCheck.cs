using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Facade
{
    public class AccountNumberCheck
    {
        private int accountNumber = 12345678;

        public int AccountNumber { get => accountNumber; }

        public bool AccountActive(int acctNumToCheck)
        {
            if (AccountNumber == acctNumToCheck)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
