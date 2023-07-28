using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Command
{
    public class TurnTVOff : ICommand
    {
        private IElectronicDevice _device;

        public TurnTVOff(IElectronicDevice device)
        {
            _device = device;
        }

        public void Execute()
        {
            _device.Off();
        }

        public void Undo()
        {
            _device.On();
        }
    }
}
