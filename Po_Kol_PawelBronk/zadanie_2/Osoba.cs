using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2
{
    public abstract class Osoba
    {
        readonly string nazwa;
        public Osoba(string nazwa)
        {
            this.nazwa = nazwa;
        }
    }
}
