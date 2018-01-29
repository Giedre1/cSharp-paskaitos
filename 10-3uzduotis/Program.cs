using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_3uzduotis
{
    class Program
    {
        // Padarykite skaičiuotuvą. Kiekvieno ciklo iteracijos metu vartotojas turi suvesti du skaičius. 
        // Iš šių skaičių turi būti grąžinami visi sudėties, skirtumo, sandaugos ir dalmens atsakymai išvedant kartu ir atliekamus veiksmus. 
        // Pvz.:5 + 4 = 95 - 4 = 1…Programa vykdoma tol, kol vartotojas nori atlikinėti skaičiavimus.

        static void Main(string[] args)
        {
            
            var veiksmas = "t";

            while (veiksmas == "t")
            {
                Console.WriteLine("Įveskite du skaičius");
                 var a = Convert.ToInt32(Console.ReadLine());
                 var b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("{0}+{1}={2}", a, b, a + b);
                Console.WriteLine("{0}-{1}={2}", a, b, a - b);
                Console.WriteLine("{0}*{1}={2}", a, b, a * b);
                Console.WriteLine("{0}/{1}={2}", a, b, a / b);

                Console.WriteLine("Ar norite tęsti skaičiavimus?");
                veiksmas = Console.ReadLine();
            }

        }
    }
}
