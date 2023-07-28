using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Command
{
    public class TurnTVUp: ICommand
    {
        private IElectronicDevice _device;

        public TurnTVUp(IElectronicDevice device)
        {
            _device = device;
        }

        public void Execute()
        {
            _device.VolumeUp();
        }

        public void Undo()
        {
            _device.VolumeDown();
        }
    }
}
