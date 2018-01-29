using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_03_1uzduotis
{
    class Program
    {
        /* Liepkite vartotojui įvesti du skaičius. Raskite kuris skaičius yra didesnis. Su viena if sąlyga (bei visomis jos dalimis) atlikite šiuos patikrinimus:
            ar pirmas skaičius didesnis už antrą skaičių;
            ar antras skaičius didesnis už pirmą;
            jei niekas neatitinka - tuomet skaičiai lygūs.
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite du skaičius");
            var a = Convert.ToInt16(Console.ReadLine());
            var b = Convert.ToInt16(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Pirmas skaičius didesnis už antrą");
            }
            else if (b > a)
            {
                Console.WriteLine("Antras skaičius didesnis už pirmą");
            }
            else
                Console.WriteLine("Skaičiai yra lygūs");
        }
    }
}
