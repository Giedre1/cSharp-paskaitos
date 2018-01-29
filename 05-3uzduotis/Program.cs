using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_3uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Liepkite vartotojui įvesti bet kokį teigiamą skaičių. Parašykite šias atskiras if sąlygas:
                patikrinti ar skaičius neigiamas, jei taip - aprėkti vartotoją :)
                patikrinti ar skaičius teigiamas, jei taip - pasveikinti vartotoją;
                patikrinti ar skaičius lyginis;
                patikrinti ar skaičius dalinasi iš 4;
                patikrinti ar skaičius yra didesnis nei 10.
             */

            Console.WriteLine("Įveskite bet kokį teigiamą skaičių");
            var skaicius = Convert.ToInt32(Console.ReadLine());

            if (skaicius < 0 )
            {
                Console.WriteLine("Ką čia rašaaaaai???");
            }

            if (skaicius > 0)
            {
                Console.WriteLine("Sveikinu");
            }

            if (skaicius % 2 == 0)
            {
                Console.WriteLine("Skaičius yra lyginis");
            }

            if (skaicius % 4 == 0)
            {
                Console.WriteLine("Skaičius dalinasi iš 4");
            }

            if (skaicius > 10)
            {
                Console.WriteLine("Skaičius yra didesnis už 10");
            }
        }
    }
}
