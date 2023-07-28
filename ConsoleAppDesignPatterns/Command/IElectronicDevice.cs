using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Command
{
    public interface IElectronicDevice
    {
        public void On();
        public void Off();
        public void VolumeUp();
        public void VolumeDown();
    }
}
