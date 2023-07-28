using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Decorator
{
    public class PlainPizza : IPizza
    {
        public double GetCost()
        {
            return 4.00;
        }

        public string GetDescription()
        {
            return "Thin Dough";
        }
    }
}
