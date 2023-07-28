using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Decorator
{
    public interface IPizza
    {
        public string GetDescription();
        public double GetCost();
    }
}
