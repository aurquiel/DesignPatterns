using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.AbstractFactory
{
    internal class UFOEnemyShipFactory : EnemyShipFactory
    {
        public ESWeapon addESGun()
        {
            return new ESUFOGun(); // Specific to regular UFO
        }

        public ESEngine addESEngine()
        {
            return new ESUFOEngine(); // Specific to regular UFO
        }
    }
}
