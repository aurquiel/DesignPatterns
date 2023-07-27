using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.AbstractFactory
{
    public abstract class EnemyShip
    {

        private string name;

        // Newly defined objects that represent weapon & engine
        // These can be changed easily by assigning new parts 
        // in UFOEnemyShipFactory or UFOBossEnemyShipFactory

        public ESWeapon weapon;
        public ESEngine engine;

        public string Name { get => name; set => name = value; }

        public abstract void makeShip();

        // Because I defined the toString method in engine
        // when it is printed the String defined in toString goes
        // on the screen

        public void followHeroShip()
        {

            Console.WriteLine(Name + " is following the hero at " + engine);

        }

        public void displayEnemyShip()
        {

            Console.WriteLine(Name + " is on the screen");

        }

        public void enemyShipShoots()
        {

            Console.WriteLine(Name + " attacks and does " + weapon);

        }

        // If any EnemyShip object is printed to screen this shows up

        public override string ToString()
        {

            String infoOnShip = "The " + Name + " has a top speed of " + engine +
                    " and an attack power of " + weapon;

            return infoOnShip;

        }

    }
}
