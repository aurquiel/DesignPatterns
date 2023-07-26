using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Factory
{
    public abstract class Equipment
    {
        private string _name;
        private double _attack;
        private double _defense;

        protected Equipment(string name, double attack, double defense)
        {
            _name = name;
            _attack = attack;
            _defense = defense;
        }

        public abstract void Attack();
        public abstract void Defense();
    }
}
