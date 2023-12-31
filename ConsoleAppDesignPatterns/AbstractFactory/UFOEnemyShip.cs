﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.AbstractFactory
{
    internal class UFOEnemyShip: EnemyShip
    {

        // We define the type of ship we want to create
        // by stating we want to use the factory that 
        // makes enemy ships

        EnemyShipFactory shipFactory;

        // The enemy ship required parts list is sent to 
        // this method. They state that the enemy ship
        // must have a weapon and engine assigned. That 
        // object also states the specific parts needed
        // to make a regular UFO versus a Boss UFO

        public UFOEnemyShip(EnemyShipFactory shipFactory)
        {

            this.shipFactory = shipFactory;

        }

        // EnemyShipBuilding calls this method to build a 
        // specific UFOEnemyShip

        public override void makeShip()
        {

            Console.WriteLine("Making enemy ship " + Name);

            // The specific weapon & engine needed were passed in
            // shipFactory. We are assigning those specific part
            // objects to the UFOEnemyShip here

            weapon = shipFactory.addESGun();
            engine = shipFactory.addESEngine();

        }

    }
}
