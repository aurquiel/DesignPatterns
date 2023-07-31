using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Template
{
    public class ItalianHoagie : Hoagie
    {
        String[] meatUsed = { "Salami", "Pepperoni", "Capicola Ham" };
        String[] cheeseUsed = { "Provolone" };
        String[] veggiesUsed = { "Lettuce", "Tomatoes", "Onions", "Sweet Peppers" };
        String[] condimentsUsed = { "Oil", "Vinegar" };

        public override void AddCheese()
        {
            Console.WriteLine("Adding the Cheese: ");

            foreach (String cheese in cheeseUsed)
            {

                Console.WriteLine(cheese + " ");

            }
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
            Console.WriteLine("Adding the Meat: ");

            foreach(String meat in meatUsed)
            {

                Console.WriteLine(meat + " ");

            }
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
