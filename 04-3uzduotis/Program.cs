using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_3uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Liepkite vartotojui įvesti bet kokį skaičių. Išveskite į ekraną šio skaičiaus kvadratą.

            Console.WriteLine("Įveskite skaičių:");
            var skaicius = Console.ReadLine();

            Console.WriteLine("{0}*{0}", skaicius);
        }
    }
}
