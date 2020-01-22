using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3
{
    public interface IBuilder
    {
        void DodajUdzwig();
        void DodajPancerz();
        void DodajUzbrojenie();
        void DodajWyposazenie();
        Robot GetRobot();
    }
}
