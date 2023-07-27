using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Visitor
{
    public class Necessity : IVisitable
    {
        private double _price;

        public Necessity(double price)
        {
            Price = price;
        }

        public double Price { get => _price; set => _price = value; }

        public double accept(IVisitor visitor)
        {
            return visitor.visit(this);
        }
    }
}
