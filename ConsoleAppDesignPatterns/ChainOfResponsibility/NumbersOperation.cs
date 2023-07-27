using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.ChainOfResponsibility
{
    public class NumbersOperation
    {
        private int number1;
        private int number2;

        private string calculationWanted;

        public NumbersOperation(int number1, int number2, string calculationWanted)
        {
            this.number1 = number1;
            this.number2 = number2;
            this.calculationWanted = calculationWanted;
        }

        public int Number1 { get => number1; }
        public int Number2 { get => number2;}
        public string CalculationWanted { get => calculationWanted; }
    }
}
