using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3
{
    public interface IUzbrojenie
    {
        string nazwa();
        double waga();
    }
    public interface IUzbrojenieFabryka
    {
        IUzbrojenie WykonajUzbrojenie(string name);
    }
    public class Karabin13mm : IUzbrojenie
    {
        public string nazwa()
        {
            return "Karabin 13mm";
        }
        public double waga()
        {
            return 10;
        }
    }
    public class Karabin20mm : IUzbrojenie
    {
        public string nazwa()
        {
            return "Karabin 20mm";
        }
        public double waga()
        {
            return 20;
        }
    }
    public class WyrzutniaZiemiaPowietrze : IUzbrojenie
    {
        public string nazwa()
        {
            return "Wyrzutnia ziemia-powietrze";
        }
        public double waga()
        {
            return 50;
        }
    }
    public class WyrzutniaZiemiaZiemia : IUzbrojenie
    {
        public string nazwa()
        {
            return "Wyrzutnia ziemia-ziemia";
        }
        public double waga()
        {
            return 50;
        }
    }
    public class UzbrojenieFabryka : IUzbrojenieFabryka
    {
        private readonly Dictionary<string, IUzbrojenie> uzbrojenia = new Dictionary<string, IUzbrojenie>()
    {
        { "Karabin 13mm", new Karabin13mm() },
        { "Karabin 20mm", new Karabin20mm() },
        { "Wyrzutnia ziemia-powietrze", new WyrzutniaZiemiaPowietrze() },
        { "Wyrzutnia ziemia-ziemia", new WyrzutniaZiemiaZiemia() }
    };

        public IUzbrojenie WykonajUzbrojenie(string name)
        {
            IUzbrojenie uzbrojenie;
            this.uzbrojenia.TryGetValue(name, out uzbrojenie);
            return uzbrojenie;
        }
    }
}
