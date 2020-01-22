using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2
{
    class PracownikMiesiaca : Osoba, IKasjer, IBok
    {
        public PracownikMiesiaca(string nazwa):base(nazwa)
        {

        }

        public void Obsluz(Klient k)
        {

        }
    }
}
