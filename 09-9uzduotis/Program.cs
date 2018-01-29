using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_9uzduotis
{
    class Program
    {
        // Raskite visų lyginių skaičių nuo 20 iki 50 sumą.

        static void Main(string[] args)
        {
            var suma = 0;
            for (int i = 20; i <= 50; i++)
            {
                suma += i;
            }
            Console.WriteLine("Skaičių nuo 20 iki 50 suma yra: " + suma);
        }
    }
}
