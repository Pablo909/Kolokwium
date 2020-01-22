using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1
{
    class UsbA : Usb
    {
        public UsbA(double maxPredkoscPobierania, double maxPredkoscWysylania) : base(maxPredkoscPobierania, maxPredkoscWysylania)
        {
        }

        public override void PobierzDane()
        {
            Console.WriteLine("Pobieram dane z prędkością " + maxPredkoscPobierania);
        }
        public override void WyslijDane()
        {
            Console.WriteLine("Wysyłam dane z prędkością " + maxPredkoscPobierania);
        }
    }
}
