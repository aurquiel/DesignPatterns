using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Strategy
{
    public class LinearSearch : ISearch
    {
        public bool ElementInList(List<int> list, int item)
        {
            foreach (int i in list)
            {
                if (i == item)
                {
                    return true;
                }   
            }

            return false;   
        }
    }
}
