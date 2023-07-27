using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Visitor
{
    public interface IVisitable
    {
        public double accept(IVisitor visitor);
    }
}
