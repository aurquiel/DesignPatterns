using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.AbstractFactory
{
    public abstract class EnemyShipBuilding
    {
        protected abstract EnemyShip makeEnemyShip(string typeOfShip);

        public EnemyShip orderTheShip(string typeOfShip)
        {
            EnemyShip theEnemyShip = makeEnemyShip(typeOfShip);
            theEnemyShip.makeShip();
            theEnemyShip.displayEnemyShip();
            theEnemyShip.followHeroShip();
            theEnemyShip.enemyShipShoots();

            return theEnemyShip;
        }
    }
}
