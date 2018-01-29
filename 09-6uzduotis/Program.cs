
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_6uzduotis
{
    class Program
    {
        // Liepkite vartotojui įvesti rėžių pradžią ir pabaigą. Patikrinkite, kad tai būtų validu (pradžia turi būti mažesnė nei pabaiga). 
        // Jei rėžiai tinkami, tuomet vykdyti for, kuris iš duotų skaičių išvestų visus nelyginius skaičius arba tuos, kurie dalinasi iš 8.

        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite rėžių pradžią");
            var pradzia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Įveskite rėžių pabaigą");
            var pabaiga = Convert.ToInt32(Console.ReadLine());

            if (pradzia < pabaiga)
            {
                Console.WriteLine("Rėžiai tinkami");
            }

            for (int i = pradzia; i < pabaiga; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
                else if (i % 8 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
