using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Observer
{
    public class StockObserver : IObserver
    {
        private double _ibmPrice;
        private double _aaplePrice;
        private double _googPrice;

        private ISubject _stockGrabber; 

        public StockObserver(ISubject stockGrabber)
        {
            this._stockGrabber = stockGrabber;
            this._stockGrabber.Register(this);
        }

        public void Update(double ibmPrice, double aaplPrice, double googPrice)
        {
            this._ibmPrice = ibmPrice;
            this._aaplePrice = aaplPrice;
            this._googPrice = googPrice;
        }
    }
}
