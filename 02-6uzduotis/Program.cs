using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_6uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Susikurkite reikiamus kintamuosius užduočiai atlikti. Į ekraną išveskite:Automobilio {markė} {modelis} ({metai} m.) rida - {rida} km.Tarp {} nurodyti reikiami kintamieji, šiose vietose jų reikšmės turi būti įsistatytos.

            var marke = "Audi";
            var modelis = "A6";
            var metai = 2010;
            var rida = 20000;

            Console.WriteLine("Automobilio {0} {1} ({2} m.) - {3} km.", marke, modelis, metai, rida);
            Console.ReadLine();
           
        }
    }
}
