using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Template
{
    public abstract class Hoagie
    {
        public void MakeSandwich()
        {
            CutBun();

            if(CustomerWantsMeat())
            {
                AddMeat();
            }

            if (CustomerWantsCheese())
            {
                AddCheese();
            }

            if (CustomerWantsVegetables())
            {
                AddVegetables();
            }

            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }

            WrapTheHaogie();
        }

        public void CutBun()
        {
            Console.WriteLine("The Hoagie is Cut");
        }

        public abstract void AddMeat();
        public abstract void AddCheese();
        public abstract void AddVegetables();
        public abstract void AddCondiments();

        bool CustomerWantsMeat()
        {
            return true;
        }

        bool CustomerWantsCheese()
        {
            return true;
        }

        bool CustomerWantsVegetables()
        {
            return true;
        }

        bool CustomerWantsCondiments()
        {
            return true;
        }

        public void WrapTheHaogie()
        {
            Console.WriteLine("The Hoagie is Wrap");
        }

    }
}
