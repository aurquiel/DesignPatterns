using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleAppDesignPatterns.Adapter
{
    public class EnemyTank : IEnemyAttacker
    {
        Random generator = new Random();

        public void AssignDriver(string driverName)
        {
            Console.WriteLine(driverName + " is driving the tank");
        }

        public void DriverForward()
        {
            int movement = generator.Next(5) + 1;
            Console.WriteLine("Enemy Tank moves " + movement + " spaces");
        }

        public void FireWeapon()
        {
            int attackDamage = generator.Next(10) + 1;
            Console.WriteLine("Enemy Tank Does " + attackDamage + " Damage");
        }
    }
}
