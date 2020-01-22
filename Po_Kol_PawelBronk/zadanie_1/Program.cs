using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop = new Laptop();
            KomputerStacjonarny pc = new KomputerStacjonarny();

            UsbA usbA1 = new UsbA(2, 2);
            UsbC usbC1 = new UsbC(2, 1);
            UsbA usbA2 = new UsbA(12, 10);
            UsbC usbC2 = new UsbC(6, 4);

            laptop.porty.Add(3, usbA1);
            laptop.porty.Add(4, usbC1);
            pc.porty.Add(3, usbA2);
            pc.porty.Add(4, usbC2);


            laptop.PobierzPrzezUsb(usbA1);
            laptop.WyslijPrzezUsb(usbA1);
            pc.WyslijPrzezUsb(usbA2);
            pc.PobierzPrzezUsb(usbC2);

            Console.ReadKey();


        }
    }
}
