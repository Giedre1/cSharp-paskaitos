using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_2uzduotis
{
    class Program
    {
        // Parašyti for, kuris išvestų kas antrą skaičių pradedant 0 ir baigiant 15. Kiekvieną skaičių išvesti toje pačioje eilutėje, po kiekvieno skaičiaus dedant tarpą.

        static void Main(string[] args)
        {
            for (int i = 0; i < 15; i+=2)
            {
                Console.Write(i + " ");
            }
        }
    }
}
