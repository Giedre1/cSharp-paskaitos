using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAK_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // sudėti į masyvą skaičius, kurie dalinasi iš 5 ir patenka į [30-150] rėžius. Masyvą išvesti gražiai.
            // for
            // if
            // pats masyvas

            var skaiciai = new int [120];
            var indeksas = 0;

            for (int i = 30; i <= 150; i++)
            {
                if (i % 5 == 0)
                {
                    skaiciai[indeksas] = i;
                    indeksas++;
                }
            }
            foreach (var skaicius in skaiciai)
            {
                Console.Write("[{0}] ", skaicius);
            }

            Console.WriteLine();


            for (int i = 0; i < indeksas; i++)
            {
                Console.Write("[{0}] ", skaiciai[i]);
            }

            Console.WriteLine();

            // rasti skaičių sumą, vidurkį, didžiausią, mažiausią skaičius iš turimo masyvo
            // sumos paieška

            var suma = 0;

            for (int i = 0; i < indeksas; i++)
            {
                suma += skaiciai[i];
            }
            Console.WriteLine("Suma: " + suma);

            // vidurkio paieška

            var vidurkis = (double)suma / indeksas; // int padalinti iš into, kad gauti skaičių per kablelį, reikia, kad bent vienas būtų double

            Console.WriteLine("Vidurkis: " + vidurkis);

            // didžiausio skaičiaus paieška

            var didziausias = skaiciai[indeksas - 1];

            Console.WriteLine("Didžiausias: " + didziausias);

            // mažiausio skaičiaus paiešk

            var maziausias = skaiciai[0];

            Console.WriteLine("Mažiausias: " + maziausias);
        }
    }
}
