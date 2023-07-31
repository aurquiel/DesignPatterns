using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Bridge
{
    public abstract class EntretaimentDevice
    {
        public int devideState;
        public int maxSetting;
        public int volumeLevel = 0;

        public abstract void ButtonFivePressed();
        public abstract void ButtonSixPressed();

        public void DeviceFeedback()
        {
            if(devideState > maxSetting || devideState < 0)
            {
               devideState = 0;
            }
            Console.WriteLine("On " + devideState);
        }

        public void ButtonSevenPressed()
        {
            volumeLevel++;
            Console.WriteLine("Volumen at: " + volumeLevel);
        }

        public void ButtonEightPressed()
        {
            volumeLevel--;
            Console.WriteLine("Volumen at: " + volumeLevel);
        }

    }
}
