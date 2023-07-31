using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Facade
{
    public class FundsCheck
    {
        private double cashInAccount = 1000.00;

        public double CashInAccount { get => cashInAccount; }

        public void DecreaseCashInAccount(double cashWithdrawn)
        {
            cashInAccount -= cashWithdrawn;
        }

        public void IncreaseCashInAccount(double cashDeposit)
        {
            cashInAccount += cashDeposit;
        }

        public bool HaveEnoughMoney(double cashToWithdrawal)
        {
            if (cashToWithdrawal > cashInAccount)
            {
                Console.WriteLine("Error: You don't have enough money");
                Console.WriteLine("Current Balance: " + CashInAccount);
                return false;
            }
            else 
            {
                DecreaseCashInAccount(cashToWithdrawal);
                Console.WriteLine("Withdrawal Complete: Current Balance is " + CashInAccount);
                return true;
            }
        }

        public void MakeDeposit(double cashToDeposit)
        {
            IncreaseCashInAccount(cashToDeposit);
            Console.WriteLine("Deposit Complete: Current Balance is " + CashInAccount);
        }

    }
}
