using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_10uzduotis
{
    class Program
    {
        // Raskite visų nelyginių skaičių nuo 30 iki 60 sumą.

        static void Main(string[] args)
        {
            var suma = 0;
            for (int i = 30; i <= 60; i++)
            {
                if (i % 2 != 0)
                {
                    suma += i;
                }
            }
            Console.WriteLine("Visų nelyginių skaičių intervale nuo 30 iki 60 suma yra: " + suma);
        }
    }
}
