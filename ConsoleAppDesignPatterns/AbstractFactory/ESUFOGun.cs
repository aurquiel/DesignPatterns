using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.AbstractFactory
{
    internal class ESUFOGun : ESWeapon
    {
        public string toString()
        {
            return "20 damage";
        }
    }
}
