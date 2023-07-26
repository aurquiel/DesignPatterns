using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Factory
{
    internal class Bow : Equipment
    {
        private string _name;
        private double _attack;
        private double _defense;

        public Bow(string name, double attack, double defense) : base(name, attack, defense)
        {
            _name = name;
            _attack = attack;
            _defense = defense;
            Console.WriteLine("Equipment create: " + _name);
        }

        public override void Attack()
        {
            Console.WriteLine("Damage: " + _attack);
        }

        public override void Defense()
        {
            Console.WriteLine("Defense: " + _defense);
        }
    }
}
