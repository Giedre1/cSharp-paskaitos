using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1uzduotis
{
    class Program
    {
        // Pritaikyti praeitoje skaidrėje parodytą pavyzdį. Susigalvoti kitą temą, kurioje išeitų panaudoti tris pasirinkimus (pvz.: 1 - šuo, 2 - katė, 3 - žiurkėnas). 
        // Kol vartotojas nesuves tinkamų duomenų tol vykdyti ciklą.

        static void Main(string[] args)
        {
            int pasirinkimas;

            do
            {
                Console.WriteLine("1 - šuo, 2 - katė, 3 - žiurkėnas");
                pasirinkimas = Convert.ToInt32(Console.ReadLine());

                if (pasirinkimas < 1 || pasirinkimas > 2)
                {
                    Console.WriteLine("Gyvūno, įvestu numeriu nėra");
                }
            } while (pasirinkimas < 1 || pasirinkimas > 2);
         Console.WriteLine("Pasirinkto gyvūno numeris yra: " + pasirinkimas);
        }
    }
}
