using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3
{
    public class ProductionCheef
    {
        public Robot BudujRobota(IBuilder builder)
        {
            builder.DodajPancerz();
            builder.DodajUdzwig();
            builder.DodajUzbrojenie();
            builder.DodajWyposazenie();

            return builder.GetRobot();
        }
    }
}
