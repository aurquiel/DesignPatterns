using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Adapter
{
    public interface IEnemyAttacker
    {
        public void FireWeapon();
        public void DriverForward();
        public void AssignDriver(string driverName);
    }
}
