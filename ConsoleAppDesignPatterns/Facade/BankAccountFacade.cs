using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Facade
{
    public class BankAccountFacade
    {
        private int accountNumber;
        private int securityCode;

        public int AccountNumber { get => accountNumber; }
        public int SecurityCode { get => securityCode; }

        AccountNumberCheck acctChecker;
        SecurityCodeCheck codeChecker;
        FundsCheck fundChecker;

        WelcomeToBank bankWelcome;

        public BankAccountFacade(int accountNumber, int securityCode)
        {
            this.accountNumber = accountNumber;
            this.securityCode = securityCode;

            bankWelcome = new WelcomeToBank();
            acctChecker = new AccountNumberCheck();
            codeChecker = new SecurityCodeCheck();
            fundChecker = new FundsCheck();
        }

        public void WithdrawCash(double cashToGet)
        {
            if(acctChecker.AccountActive(AccountNumber) &&
                codeChecker.IsCodeCorrect(SecurityCode) &&
                fundChecker.HaveEnoughMoney(cashToGet)) 
            {
                Console.WriteLine("Transaction Complete");
            }
            else
            {
                Console.WriteLine("Transaction Failed");
            }
        }

        public void DepositCash(double cashToDeposit)
        {
            if (acctChecker.AccountActive(AccountNumber) &&
                codeChecker.IsCodeCorrect(SecurityCode))
            {
                fundChecker.MakeDeposit(cashToDeposit);
                Console.WriteLine("Transaction Complete");
            }
            else
            {
                Console.WriteLine("Transaction Failed");
            }

        }
 
    }
}
