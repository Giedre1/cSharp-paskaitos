using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_5uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Liepkite vartotojui įvesti bet kokį sveikąjį skaičių. 
             Išveskite šio skaičiaus daugybos lentelę nuo 1 iki 5. 
             Pvz.:2 * 1 = 2
                    …
                   2 * 5 = 10
            */

            Console.WriteLine("Įveskite bet kokį sveikąjį skaičių");
            var skaicius = Convert.ToInt32(Console.ReadLine());
            var skaicius1 = 1;

            Console.WriteLine("{0}*{1}={2}", skaicius, skaicius1, skaicius * skaicius1);
            Console.WriteLine("{0}*{1}={2}", skaicius, (skaicius1 + 1), skaicius * (skaicius1 + 1));
            Console.WriteLine("{0}*{1}={2}", skaicius, (skaicius1 + 2), skaicius * (skaicius1 + 2));
            Console.WriteLine("{0}*{1}={2}", skaicius, (skaicius1 + 3), skaicius * (skaicius1 + 3));
            Console.WriteLine("{0}*{1}={2}", skaicius, (skaicius1 + 4), skaicius * (skaicius1 + 4));
        }
    }
}
