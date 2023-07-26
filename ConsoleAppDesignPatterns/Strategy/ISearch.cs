using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Strategy
{
    public interface ISearch
    {
        public bool ElementInList(List<int> list, int item);
    }
}
