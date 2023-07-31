using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Bridge
{
    public abstract class RemoteButton
    {
        private EntretaimentDevice theDevice;

        public RemoteButton(EntretaimentDevice theDevice)
        {
            this.theDevice = theDevice;
        }

        public void ButtonFivePressed()
        {
            theDevice.ButtonFivePressed();
        }

        public void ButtonSixPressed()
        {
            theDevice.ButtonSixPressed();
        }

        public void DeviceFeedBack()
        {
            theDevice.DeviceFeedback();
        }

        public abstract void ButtonNinePressed();

    }
}
