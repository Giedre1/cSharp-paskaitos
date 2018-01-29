using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Sugeneruokite atsitiktinio dydžio sąrašą, kurį užpildykite atsitiktiniais skaičiais nuo 1 iki 100. 
                Raskite:
                mažiausią skaičių;
                didžiausią skaičių;
                vidurkį;
                kiek skaičių yra žemesni už vidurkį;
                lyginių skaičių sumą;
            */

            var sarasas = new List<int>();
            var skaicius = new Random();
            var kiek = 5;
           
            //var didziausia = sarasas.Max();
            //var vidurkis = sarasas.Average();
            //var ZemUzVid = 0;
            //var lyg_SK_suma = 0;

            sarasas.Add(skaicius.Next(1, 100));

            for (int i = 1; i < kiek; i++)
            {
                sarasas.Add(skaicius.Next(1, 100));
            }

            foreach (var sk in sarasas)
            {
                Console.WriteLine(sk);
            }
            var maziausias = sarasas.Min();
            Console.WriteLine("Mažiausias skaičius iš sąrašo: " + maziausias);

            Console.WriteLine();

            var didziausias = sarasas.Max();
            Console.WriteLine("Didžiausias skaičius iš sąrašo: " + didziausias);

            Console.WriteLine();

            var vidurkis = sarasas.Average();
            Console.WriteLine("sąrašo vidurkis: " + vidurkis);

            kiek = 0;

            foreach (var sk in sarasas)
            {
                if (sk < vidurkis)
                {
                    kiek++;
                }
            }
            Console.WriteLine("Skaičių mažesnių už vidurkį: " + kiek);

            Console.WriteLine();

            var suma = 0;
            
            foreach (var sk in sarasas)
            {                
                if (sk % 2 == 0)
                {
                    suma += sk;
                }
            }
            Console.WriteLine("Lyginių skaičių suma: " + suma);
        }
    }
}
