using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_3uzduotis
{
    class Program
    {
        /* Liepkite įvesti trijų egzaminų rezultatus. Suraskite pažymių vidurkį. Atlikite šiuos patikrinimus:
            ar gautas vidurkis yra [8-10];
            ar gautas vidurkis yra [5-8);
            ar gautas vidurkis yra < 5.
        */ 

        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite trijų egzaminų rezultatus");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());
            var vidurkis = (a + b + c) / 3;

            Console.WriteLine("Egzaminų vidurkis yra:" + vidurkis);

            if (vidurkis >= 8 && vidurkis <= 10)
            {
                Console.WriteLine("Egzaminų vidurkis yra daugiau arba lygu 8, bet mažiau arba lygu 10");
            }
            else if (vidurkis >= 5 && vidurkis <8)
            {
                Console.WriteLine("Egzaminų vidurkis yra daugiau kaip 5, bet mažiau kaip 8");
            }
            else
            {
                Console.WriteLine("Egzaminų vidurkis yra mažiau kaip 5");
            }
        }
    }
}
