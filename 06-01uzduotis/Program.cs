using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_01uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Liepkite įvesti tris skaičius. Suraskite kuris iš šių skaičių yra didžiausias.

            Console.WriteLine("Įveskite tris skaičius");
            var a = Convert.ToInt16(Console.ReadLine());
            var b = Convert.ToInt16(Console.ReadLine());
            var c = Convert.ToInt16(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("Pirmas skaičius yra didžiausias");
            }
            else if (b > c && b < a)
            {
                Console.WriteLine("Antras skaičius yra didžiausias");
            }
            else if (c > a && c > b)
            {
                Console.WriteLine("Trečias skaičius yra didžiausias");
            }
              else
                Console.WriteLine("Bent du skaičiai vienodi");
        }
    }
}
