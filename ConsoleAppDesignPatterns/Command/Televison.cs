using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Command
{
    public class Televison : IElectronicDevice
    {
        private int volume = 0;

        public void Off()
        {
            Console.WriteLine("Tv is Off");
        }

        public void On()
        {
            Console.WriteLine("Tv is ON");
        }

        public void VolumeDown()
        {
            volume--;
            Console.WriteLine("Tv Volume is at " + volume);
        }

        public void VolumeUp()
        {
            volume++;
            Console.WriteLine("Tv Volume is at " + volume);
        }
    }
}
