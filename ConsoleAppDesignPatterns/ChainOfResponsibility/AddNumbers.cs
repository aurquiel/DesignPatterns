using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.ChainOfResponsibility
{
    public class AddNumbers : Chain
    {
        private Chain nextInChain;

        public void Calculate(NumbersOperation request)
        {
            if(request.CalculationWanted == "add")
            {
                Console.WriteLine(request.Number1 + " + " +request.Number2 + " = " + (request.Number1 + request.Number2));
            }
            else
            {
                nextInChain.Calculate(request);
            }
        }

        public void SetNextChain(Chain nextChain)
        {
            nextInChain = nextChain;
        }
    }
}
