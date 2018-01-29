using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_5uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Išveskite į ekraną norimo dydžio tuščiavidurį kvadratą iš žvaigždučių.
             ****
             *  *  
             *  *
             ****
             */

            var simbolis = "*";
            Console.WriteLine(simbolis + simbolis + simbolis + simbolis);
            Console.WriteLine(simbolis+ " " + " " + simbolis);
            Console.WriteLine(simbolis + " " + " " + simbolis);
            Console.WriteLine(simbolis + simbolis + simbolis + simbolis);
        }
    }
}
