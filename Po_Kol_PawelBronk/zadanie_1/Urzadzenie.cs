using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1
{
    public abstract class Urzadzenie
    {
        public Dictionary<int, Usb> porty;
        
        public Urzadzenie()
        {
        }

        public abstract void PobierzPrzezUsb(Usb usb);
        public abstract void WyslijPrzezUsb(Usb usb);
    }
}
