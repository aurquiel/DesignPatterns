using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Factory
{
    public class EquipmentFactory
    {
        public enum SELECTOR { Sword = 0 , Shield = 1, Bow = 2}

        public static Equipment CreateEquipment(SELECTOR selector)
        {
            switch(selector)
            {
                case SELECTOR.Sword:
                {
                    return new Sword("Espada", 40, 5);
                }
                case SELECTOR.Shield:
                {
                    return new Sword("Escudo", 10, 80);
                }
                case SELECTOR.Bow:
                {
                    return new Sword("Arco", 90, 0);
                }
                default:
                {
                    throw new Exception("Equipo no existe.");
                }
            } 

        }
    }
}
