using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_1uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Liepkite vartotojui įvesti tris sveikuosius skaičius. Parašykite šias atskiras if sąlygas:
                patikrinkite ar pirmas ir antras skaičiai yra lygūs;
                patikrinkite ar antras ir trečias skaičiai yra lygūs;
                patikrinkite ar pirmas skaičius yra didesnis už antrąjį;
                patikrinkite ar antras skaičius yra didesnis už dvigubą trečiojo skaičiaus reikšmę (trečias skaičius padaugintas iš dviejų);
                patikrinkite ar pirmas skaičius yra lyginis (dalinti per % ir žiūrėti ar gautas atsakymas yra lygus nuliui);
                patikrinkite ar antras skaičius skaičius yra nelyginis (dalinti per % ir žiūrėti ar gautas atsakymas nėra lygus nuliui);
                patikrinkite ar trečias skaičius yra teigiamas (daugiau už 0);
                patikrinkite ar trečias skaičius yra neigiamas (mažiau už 0).
             */

            Console.WriteLine("Įveskite tris sveikuosius skaičius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("Pirmas ir antras skaičiai lygūs");
            }

            if (b == c)
            {
                Console.WriteLine("Antras ir trečias skaičiai lygūs");
            }

            if (a > b)
            {
                Console.WriteLine("Pirmas skaičiaus yra didesnis už antrą");
            }

            if (b > a * 2)
            {
                Console.WriteLine("Antras skaičiaus yra didesnis už dvigubą pirmą skaičių");
            }

            if (a % 2 == 0)
            {
                Console.WriteLine("Pirmas skaičius yra lyginis");
            }

            if (b % 2 != 0)
            {
                Console.WriteLine("Antras skaičius yra nelyginis");
            }

            if (c > 0)
            {
                Console.WriteLine("Trečias skaičius yra teigiamas");
            }

            if (c < 0)
            {
                Console.WriteLine("Trečias skaičius yra neigiamas");
            }
        }
    }
}
