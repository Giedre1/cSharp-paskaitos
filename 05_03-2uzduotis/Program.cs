using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_03_2uzduotis
{
    class Program
    {
        /* Liepkite vartotojui įvesti vieną norimą skaičių. Su viena if sąlyga (ir visomis jos dalimis), patikrinkite šiuos dalykus:
            ar skaičius neigiamas;
            ar skaičius teigiamas;
            ar skaičius lygus 0.
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite norimą skaičių");
            var a = Convert.ToInt32(Console.ReadLine());

            if (a < 0)
                Console.WriteLine("Įvestas skaičius yra neigiamas");

            else if (a > 0)
                Console.WriteLine("Įvestas skaičius yra teigiamas");

            else
                     Console.WriteLine("Įvestas skaičius yra 0");
        }
    }
}
