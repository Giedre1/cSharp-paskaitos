using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Garazas
{
    class Program
    {
        static void Main(string[] args)
        {
            var garazas = new Garazas("Pas Joną", "Kaunas, kažkur", 3, new List<Automobilis>
            {
                new Automobilis("Audi", "A6", 2014, 30000, 120, 2.0, "Juoda"),
                new Automobilis("Opel", "Astra", 2015, 150000, 100, 1.9, "Balta"),
                new Automobilis("BMW", "X5", 2017, 15000, 160, 3.0, "Mėlyna"),
                new Automobilis("Nissan", "Quashqai", 2000, 160000, 99, 3.2, "Raudona"),
            });
            garazas.Isvedimas();
            garazas.AtnaujintiPasirinkta();
            garazas.Skaiciavimai();

        }
    }
}
