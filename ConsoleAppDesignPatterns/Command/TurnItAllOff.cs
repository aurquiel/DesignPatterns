using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Command
{
    public class TurnItAllOff : ICommand
    {
        private List<IElectronicDevice> _devices;

        public TurnItAllOff(List<IElectronicDevice> device)
        {
            _devices = device;
        }

        public void Execute()
        {
            foreach(var device in _devices)
            {
                device.Off();
            }
        }

        public void Undo()
        {
            foreach (var device in _devices)
            {
                device.On();
            }
        }
    }
}
