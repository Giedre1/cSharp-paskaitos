using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAK_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Leisti vartotojui pasirinkti, kiek duomenų jis nori suvesti, leisti šiuos duomenis sukelti į masyvą, rasti: vidurkį, in, max, sumą. 
            // Atlikti atrinkimą į kitą masyvą duomenų, kurie tenkina šią sąlygą: visos temperatūros, kurios yra daugiau už vidurkį. Abiejų masyvų duomenis išvesti.

            Console.WriteLine("Kiek temteratūrų norite įvesti?");
            var kiek = Convert.ToInt32(Console.ReadLine());

            var temperaturos = new int[kiek];

            for (int i = 0; i < kiek; i++)
            {
                Console.WriteLine("Įveskite {0}-ąją temperatūrą: ", i+1);
                temperaturos[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Įvesti duomenys:");

            foreach (var temperatura in temperaturos)
            {
                Console.WriteLine("[{0}]", temperatura);
            }

            Console.WriteLine();

            // suma

            var suma = 0;

            foreach (var temp in temperaturos)
            {
                suma += temp;
                // suma = suma + temp
            }

            Console.WriteLine("Suma: " + suma);

            Console.WriteLine();

            // vidurkis

            var vidurkis = (double)suma / temperaturos.Length;

            Console.WriteLine("Vidurkis: " + Math.Round(vidurkis, 2)); // Math.Round - kad graŽus skaičius būtų (po kablelio 2 skaičiai)

            // mažiausia temperatūra

            var maziausias = temperaturos[0];

            foreach (var temp in temperaturos)
            {
                if (temp < maziausias)
                {
                    maziausias = temp;
                }
            }
            Console.WriteLine("Mažiausia: " + maziausias);
            
            Console.WriteLine();

            // didžiausia

            var didziausia = 0;

            foreach (var temp in temperaturos)
            {
                if (temp > didziausia)
                {
                    didziausia = temp;
                }
            }
            Console.WriteLine("Dižiausia: " + didziausia);
           
            Console.WriteLine();

            // atrinkimas
            // temperatūros, kuri yra didesnė už vidurkį

            var atrinkta = new int[kiek]; // kiek - nezinom tikslaus skaiciaus
            var kiekAtrinkta = 0;

            foreach (var temp in temperaturos)
            {
                if (temp > vidurkis)
                {
                    atrinkta[kiekAtrinkta] = temp;
                    kiekAtrinkta++;
                }
            }
            Console.WriteLine("ATRINKTI DUOMENYS");
            for (int i = 0; i < kiekAtrinkta; i++)
            {
                Console.WriteLine("[{0}]", atrinkta[i]);
            }

            Console.WriteLine();
        }
    }
}
