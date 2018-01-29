
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1uzduotis
{
    class Program
    {
        // Liepkite vartotojui įvesti teigiamą skaičių. Ciklo pagalba šį skaičių išvesti mažėjimo tvarka iki kol jis pasieks 0. Pvz.: 5 4 3 2 1. Kiekvieną kartą išvesti skirtingose eilutėse.


        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite teigiamą skaičių");
            var skaicius = Convert.ToInt32(Console.ReadLine());

            while (skaicius > 0)
                {
              //  Console.WriteLine(skaicius);
              //  skaicius--;
              //  skaicius = skaicius - 1;
                    Console.WriteLine(skaicius--);
                }
        }
    }
}
