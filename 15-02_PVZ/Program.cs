using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_02_PVZ
{
    class Program
    {
        static void Main(string[] args)
        {
            var zmogus1 = new Zmogus(); // patys suvesim duomenis
            zmogus1.Isvedimas();

            var zmogus2 = new Zmogus("Jonas", "Jonaitis", 180, 28, 'V');  // is karto isveda
            zmogus2.Isvedimas();

            var seima = new Seima();
            seima.Isvedimas();

            var seima2 = new Seima("Kaunas", new List<Zmogus>
            {
                new Zmogus ("Jonas", "Kažkoks", 55, 189, 'v'),
                new Zmogus ("Ona", "Kažkokia", 52, 170, 'm'),
            });
            seima2.Isvedimas();
        }
    }
}
