using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3
{
    class MicroMechBuilder : IBuilder
    {
        public Robot microMech = new MicroMech();

        public void DodajUdzwig()
        {
            microMech.maxUdzwig = 100;
        }
        public void DodajPancerz()
        {
            microMech.pancerz = Pancerz.brak;
        }
        public void DodajUzbrojenie()
        {
            microMech.uzbrojenie = microMech.uzbrojenieFabryka.WykonajUzbrojenie("Karabin 13mm").nazwa();
        }
        public void DodajWyposazenie()
        {
            microMech.dodatkoweWyposazenie.Add(DodatkoweWyposazenie.DodatkowaBateria);
        }
        public Robot GetRobot()
        {
            return microMech;
        }
    }
}
