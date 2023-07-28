using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Command
{
    public class DeviceButton
    {
        private ICommand _command;

        public DeviceButton(ICommand command)
        {
            _command = command;
        }

        public void Press()
        {
            _command.Execute();
        }

        public void PressUndo()
        {
            _command.Undo();
        }
    }
}
