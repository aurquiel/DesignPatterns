using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Bridge
{
    internal class TvRemotePause : RemoteButton
    {
        public TvRemotePause(EntretaimentDevice theDevice) : base(theDevice)
        {
        }

        public override void ButtonNinePressed()
        {
            Console.WriteLine("Tv was Paused");
        }
    }
}
