using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_2uzduotis
{
    class Program
    {
        // Liepkite įvesti tris skaičius. Suraskite kuris iš šių skaičių yra mažiausias.

        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite tris skaičius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());

            if (a < b && a < c)
            {
                Console.WriteLine("Pirmas skaičius yra mažiausias");
            }
            else if (b < a && b < c)
            {
                Console.WriteLine("Antras skaičius yra mažiausias");
            }
            else if (c < b && c < a)
            {
                Console.WriteLine("Trečias skaičius yra mažiausias");
            }
            else
            {
                Console.WriteLine("Bent du skaičiai yra vienodi");
            }
        }
    }
}
