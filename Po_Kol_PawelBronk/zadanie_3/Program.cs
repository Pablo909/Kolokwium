using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductionCheef szefProdukcji = new ProductionCheef();
            IBuilder MicroMechBuilder= new MicroMechBuilder();

            szefProdukcji.BudujRobota(MicroMechBuilder);

            Robot micro = MicroMechBuilder.GetRobot();
            Console.WriteLine(micro.pancerz +" " +micro.uzbrojenie);
            Console.ReadKey();
        }
    }
}
