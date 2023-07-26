using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.AbstractFactory
{
    internal interface EnemyShipFactory
    {
        public ESWeapon addESGun();
	    public ESEngine addESEngine();
    }
}
