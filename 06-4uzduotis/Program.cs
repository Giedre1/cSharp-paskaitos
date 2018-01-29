using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_4uzduotis
{
    class Program
    {
        /* Liepkite įvesti du skaičius. Patikrinkite (naudojant 4 atskirus if’us):
            ar pirmas skaičius yra didesnis už antrąjį, arba yra lygus 0;
            ar antras skaičius yra didesnis už pirmąjį, arba yra lygus 5;
            ar pirmas skaičius yra didesnis už antrąjį ir yra lygus 20;
            ar antras skaičius yra didesnis už pirmąjį ir yra mažesnis už 100;
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite du skaičius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());

            if (a > b || a ==0)
            {
                Console.WriteLine("Pirmas skaičius yra didesnis už antrąjį, arba yra lygus 0.");
            }
            else if (b > a || b == 5)
            {
                Console.WriteLine("Antras skaičius yra didesnis už pirmąjį, arba yra lygus 0.");
            }
            else if (a > b && a == 20)
            {
                Console.WriteLine("Pirmas skaičius yra didesnis už antrąjį ir yra lygus 20.");
            }
            else if (b > a || b == 100)
            {
                Console.WriteLine("Antras skaičius yra didesnis už pirmąjį ir yra lygus 100.");
            }
        }
    }
}
