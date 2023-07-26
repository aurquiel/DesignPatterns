using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Strategy
{
    public class BinarySearch : ISearch
    {
        public bool ElementInList(List<int> list, int item)
        {
            int result = list.BinarySearch(item);
            return result > 0;
        }
    }
}
