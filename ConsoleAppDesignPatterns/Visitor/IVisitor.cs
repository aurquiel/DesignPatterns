using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Visitor
{
    public interface IVisitor
    {
        public double visit(Liquor item);
        public double visit(Tabacco item);
        public double visit(Necessity item);
    }
}
