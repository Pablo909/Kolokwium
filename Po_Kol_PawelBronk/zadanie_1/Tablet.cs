using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1
{
    class Tablet : Urzadzenie
    {
        public Tablet()
        {
            porty = new Dictionary<int, Usb>()
            {
                {1, new UsbC(5, 5) }
            };
        }
        public override void PobierzPrzezUsb(Usb usb)
        {
            foreach (var x in porty)
            {
                if (x.Value == usb)
                {
                    usb.PobierzDane();
                    return;
                }
            }
        }
        public override void WyslijPrzezUsb(Usb usb)
        {
            foreach (var x in porty)
            {
                if (x.Value == usb)
                {
                    usb.WyslijDane();
                    return;
                }
            }

        }
    }
}
