using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_5uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Išveskite pasirinkto skaičiaus daugybos lentelę. Pvz.:
             5 * 0 = 0
             5 * 1 = 5
             …
             5 * 10 = 50
            */

            var sk0 = 0;
            var sk5 = 5;

            Console.WriteLine("{0}*{1}={2}", sk5, sk0, sk5*sk0);
            Console.WriteLine("{0}*{1}={2}", sk5, sk0 + 1, sk5 * (sk0 + 1));
            Console.WriteLine("{0}*{1}={2}", sk5, sk0 + 2, sk5 * (sk0 + 2));
            Console.WriteLine("{0}*{1}={2}", sk5, sk0 + 3, sk5 * (sk0 + 3));
            Console.WriteLine("{0}*{1}={2}", sk5, sk0 + 4, sk5 * (sk0 + 4));
            Console.WriteLine("{0}*{1}={2}", sk5, sk0 + 5, sk5 * (sk0 + 5));
            Console.WriteLine("{0}*{1}={2}", sk5, sk0 + 6, sk5 * (sk0 + 6));
            Console.WriteLine("{0}*{1}={2}", sk5, sk0 + 7, sk5 * (sk0 + 7));
            Console.WriteLine("{0}*{1}={2}", sk5, sk0 + 8, sk5 * (sk0 + 8));
            Console.WriteLine("{0}*{1}={2}", sk5, sk0 + 9, sk5 * (sk0 + 9));
            Console.WriteLine("{0}*{1}={2}", sk5, sk0 + 10, sk5 * (sk0 + 10));
        }
    }
}
