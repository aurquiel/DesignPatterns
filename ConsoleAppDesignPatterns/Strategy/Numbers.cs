using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Strategy
{
    public class Numbers
    {
        private ISearch _search;
        private List<int> _numbers;

        public ISearch Search { get => _search; set => _search = value; }
        public List<int> NumbersList { get => _numbers; set => _numbers = value; }
    }
}
