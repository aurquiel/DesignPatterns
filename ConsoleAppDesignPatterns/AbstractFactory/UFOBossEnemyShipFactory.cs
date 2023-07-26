using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.AbstractFactory
{
    internal class UFOBossEnemyShipFactory : EnemyShipFactory
    {
        public ESWeapon addESGun()
        {
            return new ESUFOBossGun(); // Specific to Boss UFO
        }

        // Defines the engine object to associate with the ship

        public ESEngine addESEngine()
        {
            return new ESUFOBossEngine(); // Specific to Boss UFO
        }
    }
}
