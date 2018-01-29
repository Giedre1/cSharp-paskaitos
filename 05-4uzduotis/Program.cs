using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_4uzduotis
{
    class Program
    {
        // Liepkite vartotojui įvesti penkis savo pažymius, raskite šių pažymių vidurkį, patikrinkite ar vidurkis yra lygus arba didesnis už 5.

        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite 5 savo pažymius");

            var paz1 = Convert.ToInt32(Console.ReadLine());
            var paz2 = Convert.ToInt32(Console.ReadLine());
            var paz3 = Convert.ToInt32(Console.ReadLine());
            var paz4 = Convert.ToInt32(Console.ReadLine());
            var paz5 = Convert.ToInt32(Console.ReadLine());
            var vidurkis = (paz1 + paz2 + paz3 + paz4 + paz5) / 5;

            Console.WriteLine("Pažymių vidurkis yra:" + vidurkis);

            {
                if (vidurkis >= 5)
                    Console.WriteLine("Vidurkis yra daugiau arba lygu už 5");
            }
        }
    }
}
