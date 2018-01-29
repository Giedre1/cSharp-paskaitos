using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var pinigai = new List<int>
            {
                40, 20, 15, 555, 850, 900, 1021, 1333
            };

            foreach (var pinigas in pinigai)
            {
                Console.Write(pinigas + " ");
               // Console.Write("[{0}] ", pinigas);
            }

            // rasti min, max , average

            var maziausias = pinigai.Min();
            var didziausias = pinigai.Max();
            var vidurkis = pinigai.Average();

            Console.WriteLine("Mažiausias: " + maziausias);
            Console.WriteLine("Didžiausias: " + didziausias);
            Console.WriteLine("Vidurkis: " + vidurkis);
            Console.WriteLine("Mažiausias: " + maziausias);

            
            // atrinkti į kitą sąrašą mažesnius už vidurkį

            var mazUzVid = new List<int>();

            foreach (var pinigas in pinigai) // skaičiuojame
            {
                if (pinigas < vidurkis)
                {
                    mazUzVid.Add(pinigas);
                }
            }

            Console.WriteLine("Mažesni už vidurkį: ");  // išvedame

            foreach (var i in mazUzVid)
            {
                Console.WriteLine(i + ", ");
            }

            // atrinkti į kitą sąrašą lyginius skaičius

            var lyginiai = new List<int>();

            foreach (var pinigas in pinigai) // skaičiuojame
            {
                if (pinigas % 2 == 0)
                {
                    lyginiai.Add(pinigas);
                }
            }

            Console.WriteLine("Lyginiai skaičiai: ");  // išvedame

            foreach (var i in lyginiai)
            {
                Console.WriteLine(i + ", ");
            }

            // atrinkti į kitą sąrašą skaičius esančius tarp 50 ir max

            var noreciau = new List<int>();

            foreach (var pinigas in pinigai) // skaičiuojame
            {
                if (pinigas > 50 && pinigas <= pinigai.Max())
                {
                    noreciau.Add(pinigas);
                }
            }

            Console.WriteLine("Norimi pinigai: ");  // išvedame

            foreach (var i in noreciau)
            {
                Console.WriteLine(i + ", ");
            }
        }
    }
}
