using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Command
{
    public class Radio : IElectronicDevice
    {
        private int volume = 0;

        public void Off()
        {
            Console.WriteLine("Radio is Off");
        }

        public void On()
        {
            Console.WriteLine("Radio is ON");
        }

        public void VolumeDown()
        {
            volume--;
            Console.WriteLine("Radio Volume is at " + volume);
        }

        public void VolumeUp()
        {
            volume++;
            Console.WriteLine("Radio Volume is at " + volume);
        }
    }
}
