using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_8uzduotis
{
    class Program
    {
        //Raskite visų skaičių nuo 1 iki 100 sumą.

        static void Main(string[] args)
        {
            var suma = 0;
            for (int i = 1; i <= 100; i++)
            {
                suma += i;
            }
            Console.WriteLine("Skaičių nuo 1 iki 100 suma yra: " + suma);
        }
    }
}
