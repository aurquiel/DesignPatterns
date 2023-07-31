using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Bridge
{
    public class TvDevice : EntretaimentDevice
    {
        public TvDevice(int newDeviceState, int newMaxSetting)
        {
            devideState = newDeviceState;
            maxSetting = newMaxSetting;
        }

        public override void ButtonFivePressed()
        {
            Console.WriteLine("Channel Down");
            devideState--;
        }

        public override void ButtonSixPressed()
        {
            Console.WriteLine("Channel Up");
            devideState++;
        }
    }
}
