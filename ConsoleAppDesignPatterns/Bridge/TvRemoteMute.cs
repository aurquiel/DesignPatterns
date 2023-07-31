using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Bridge
{
    public class TvRemoteMute : RemoteButton
    {
        public TvRemoteMute(EntretaimentDevice theDevice) : base(theDevice)
        {
        }

        public override void ButtonNinePressed()
        {
            Console.WriteLine("Tv was Muted");
        }
    }
}
