using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.AbstractFactory
{
    public abstract class EnemyShip
    {

        private String name;

        // Newly defined objects that represent weapon & engine
        // These can be changed easily by assigning new parts 
        // in UFOEnemyShipFactory or UFOBossEnemyShipFactory

        public ESWeapon weapon;
        public ESEngine engine;

        public String getName() { return name; }
        public void setName(String newName) { name = newName; }

        public abstract void makeShip();

        // Because I defined the toString method in engine
        // when it is printed the String defined in toString goes
        // on the screen

        public void followHeroShip()
        {

            Console.WriteLine(getName() + " is following the hero at " + engine);

        }

        public void displayEnemyShip()
        {

            Console.WriteLine(getName() + " is on the screen");

        }

        public void enemyShipShoots()
        {

            Console.WriteLine(getName() + " attacks and does " + weapon);

        }

        // If any EnemyShip object is printed to screen this shows up

        public override string ToString()
        {

            String infoOnShip = "The " + name + " has a top speed of " + engine +
                    " and an attack power of " + weapon;

            return infoOnShip;

        }

    }
}
