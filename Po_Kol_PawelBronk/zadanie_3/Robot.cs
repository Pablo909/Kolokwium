using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3
{
    public enum Pancerz
    {
        brak,
        Kewlarowy,
        Tytanowy,
        Reaktywny
    }

    public enum DodatkoweWyposazenie
    {
        Radar,
        Maskowanie,
        DodatkowaBateria,
        EMP
    }

    public abstract class Robot
    {
        public double maxUdzwig;
        public Pancerz pancerz;
        public List<DodatkoweWyposazenie> dodatkoweWyposazenie = new List<DodatkoweWyposazenie>();
        public string uzbrojenie;
        public UzbrojenieFabryka uzbrojenieFabryka = new UzbrojenieFabryka();
    }
}
