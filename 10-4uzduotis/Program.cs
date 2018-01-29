using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_4uzduotis
{
    class Program
    {
        // Sukurkite string tipo kintamąjį. Prie jo vis pridėkite vartotojo įrašomus skirtingus žodžius. 
        // Tačiau jei vartotojas įrašytų “exit” - baigti ciklą. 
        //Baigus vykdyti ciklą turi būti išvestas string kintamasis prie kurio vis buvo pridedami skirtingi žodžiai.

        static void Main(string[] args)
        {
           
            var sakinys = "";
            var zodis = "";

            while (zodis != "exit")
            {
               Console.Write("Įveskite pasirinktą žodį arba exit: ");
                zodis = Console.ReadLine();

                if (zodis != "exit")
                {
                    sakinys += zodis + " ";
                }
            }
            Console.WriteLine(sakinys);
        }
    }
}
