using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1
{
    public abstract class Usb : IUsb
    {
        internal double maxPredkoscPobierania;
        internal double maxPredkoscWysylania;

        public Usb(double maxPredkoscPobierania, double maxPredkoscWysylania)
        {
            this.maxPredkoscPobierania = maxPredkoscPobierania;
            this.maxPredkoscWysylania = maxPredkoscWysylania;
        }

        public abstract void PobierzDane();
        public abstract void WyslijDane();
    }
}
