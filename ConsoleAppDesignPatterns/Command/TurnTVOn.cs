using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Command
{
    public class TurnTVOn : ICommand
    {
        private IElectronicDevice _device;

        public TurnTVOn(IElectronicDevice device)
        {
            _device = device;
        }

        public void Execute()
        {
            _device.On();
        }

        public void Undo()
        {
            _device.Off();
        }
    }
}
