using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.AbstractFactory
{
    internal class ESUFOBossGun : ESWeapon
    {
        public override string ToString()
        {
            return "40 damage";
        }
    }
}
