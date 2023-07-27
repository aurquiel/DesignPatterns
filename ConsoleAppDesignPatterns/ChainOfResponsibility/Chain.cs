using ConsoleAppDesignPatterns.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.ChainOfResponsibility
{
    public interface Chain
    {
        public void SetNextChain(Chain nextChain);
        public void Calculate(NumbersOperation request);
    }
}
