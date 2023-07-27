using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Visitor
{
    internal class TaxHolidayVisitor : IVisitor
    {
        public double visit(Liquor item)
        {
            return item.Price * 0.48 + item.Price;
        }

        public double visit(Tabacco item)
        {
            return item.Price * 0.52 + item.Price;
        }

        public double visit(Necessity item)
        {
            return item.Price * 0.10 + item.Price;
        }
    }
}
