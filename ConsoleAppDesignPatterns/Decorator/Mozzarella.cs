using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Decorator
{
    public class Mozzarella : ToopingDecorator
    {
        public Mozzarella(IPizza pizza) : base(pizza)
        {
            Console.WriteLine("Adding Dough");
            Console.WriteLine("Adding Moz");
        }

        public override double GetCost()
        {
            return _pizza.GetCost() + 0.50;
        }

        public override string GetDescription()
        {
            return _pizza.GetDescription() + ", Mozzarella";
        }
    }
}
