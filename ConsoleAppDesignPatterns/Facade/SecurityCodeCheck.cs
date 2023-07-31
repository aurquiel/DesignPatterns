using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Facade
{
    public class SecurityCodeCheck
    {
        private int securityCode = 1234;

        public int SecurityCode { get => securityCode; }

        public bool IsCodeCorrect(int sedCodeToCheck)
        {
            if (SecurityCode == sedCodeToCheck)
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
