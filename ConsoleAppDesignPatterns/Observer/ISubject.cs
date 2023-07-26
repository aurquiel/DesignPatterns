using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Observer
{
    public interface ISubject
    {
        public void Register(IObserver observer);
        public void Unregister(IObserver observer);
        public void notifyObserver();
    }
}
