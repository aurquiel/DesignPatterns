using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Template
{
    public class VeggeiHoagie : Hoagie
    {
        String[] veggiesUsed = { "Lettuce", "Tomatoes", "Onions", "Sweet Peppers" };
        String[] condimentsUsed = { "Oil", "Vinegar" };


        bool CustomerWantsMeat()
        {
            return false;
        }

        bool CustomerWantsCheese()
        {
            return false;
        }


        public override void AddCheese()
        {
            
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding the Condiments: ");

            foreach (String condiment in condimentsUsed)
            {

                Console.WriteLine(condiment + " ");

            }
        }

        public override void AddMeat()
        {
            
        }

        public override void AddVegetables()
        {
            Console.WriteLine("Adding the Vegetables: ");

            foreach (String vegetable in veggiesUsed)
            {

                Console.WriteLine(vegetable + " ");

            }
        }
    }
}
