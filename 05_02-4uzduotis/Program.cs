using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_02_4uzduotis
{
    class Program
    {
        /* Liepkite vartotojui įvesti gautą pažymį, atlikite šiuos veiksmus:
            jei 10 - išveskite “Puikiai”;
            jei 8-9 - išveskite “Labai gerai”;
            jei 5-7 - išveskite “Patenkinamai”;
            jei 3-4 - išveskite “Prastai”;
            jei 1-2 - išveskite “Labai blogai”;
        */ 

        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite gautą pažymį");
            var paz = Convert.ToInt32(Console.ReadLine());

            if (paz == 10)
            {
                Console.WriteLine("Puikiai");
            }
            else if (paz >= 8)
            {
                Console.WriteLine("Labai gerai");
            }
            else if (paz >= 5)
            {
                Console.WriteLine("Patenkinamai");
            }
            else if (paz >= 3)
            {
                Console.WriteLine("Prastai");
            }
            else
            {
                Console.WriteLine("Labai blogai");
            }
        }
    }
}
