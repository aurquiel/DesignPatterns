using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Adapter
{
    public class EnemyRobotAdpater : IEnemyAttacker
    {
        private EnemyRobot _enemyRobot;

        public EnemyRobotAdpater(EnemyRobot enemyRobot)
        {
            _enemyRobot = enemyRobot;
        }

        public void AssignDriver(string driverName)
        {
            _enemyRobot.ReactToHuman(driverName);
        }

        public void DriverForward()
        {
            _enemyRobot.WalkForward();
        }

        public void FireWeapon()
        {
            _enemyRobot.SmashWithHands();
        }
    }
}
