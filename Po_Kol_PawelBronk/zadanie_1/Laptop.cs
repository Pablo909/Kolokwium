﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1
{
    class Laptop : Urzadzenie
    {
        public Laptop()
        {
            porty = new Dictionary<int, Usb>()
            {
                { 1, new UsbC( 3, 10) },
                { 2, new UsbA( 4, 2) }
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
