using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Observer
{
    public interface IObserver
    {
        void Update(double ibmPrice, double aaplPrice, double googPrice);
    }
}
