using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Observer
{
    internal class StockGrabber : ISubject
    {
        private List<IObserver> _observers;
        private double _ibmPrice;
        private double _aaplePrice;
        private double _googPrice;

        public double IbmPrice 
        { 
            get => _ibmPrice; 
            set { 
                _ibmPrice = value;
                notifyObserver();
            } 
        }

        public double AaplePrice
        {
            get => _aaplePrice;
            set
            {
                _aaplePrice = value;
                notifyObserver();
            }
        }

        public double GoogPrice 
        { 
            get => _googPrice;
            set
            {
                _googPrice = value;
                notifyObserver();
            }
        }

        public StockGrabber()
        {
            _observers = new List<IObserver>();
        }

        public void Register(IObserver observer)
        {
           _observers.Add(observer);
        }

        public void Unregister(IObserver observer)
        {
            _observers.Remove(observer);   
        }

        public void notifyObserver()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(IbmPrice, AaplePrice, GoogPrice);
            }
        }
    }
}
