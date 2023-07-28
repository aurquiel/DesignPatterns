using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Decorator
{
    public class TomatoSauce : ToopingDecorator
    {
        public TomatoSauce(IPizza pizza) : base(pizza)
        {
            Console.WriteLine("Adding Souce");
        }

        public override double GetCost()
        {
            return _pizza.GetCost() + 0.35;
        }

        public override string GetDescription()
        {
            return _pizza.GetDescription() + ", Tomato Sauce";
        }
    }
}
