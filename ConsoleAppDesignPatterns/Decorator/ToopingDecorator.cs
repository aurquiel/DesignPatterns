using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Decorator
{
    public class ToopingDecorator : IPizza
    {
        protected IPizza _pizza;

        public ToopingDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public virtual double GetCost()
        {
            return _pizza.GetCost();
        }

        public virtual string GetDescription()
        {
            return _pizza.GetDescription();
        }
    }
}
