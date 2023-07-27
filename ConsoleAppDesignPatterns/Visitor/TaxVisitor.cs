using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Visitor
{
    internal class TaxVisitor : IVisitor
    {
        public double visit(Liquor item)
        {
            return item.Price * 0.18 + item.Price;
        }

        public double visit(Tabacco item)
        {
            return item.Price * 0.32 + item.Price;
        }

        public double visit(Necessity item)
        {
            return item.Price * 0 + item.Price;
        }
    }
}
