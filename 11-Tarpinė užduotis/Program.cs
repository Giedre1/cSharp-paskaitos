using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Tarpinė_užduotis
{
    class Program
    {
        /*  The sum of the squares of the first ten natural numbers is, 12 + 22 + ... + 102 = 385
            The square of the sum of the first ten natural numbers is, (1 + 2 + ... + 10)2 = 552 = 3025
            Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
            Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
            Answer: 25164150
         */
        static void Main(string[] args)
        {
            var skaicius = 0; 
            for (int i = 1; i <= 10; i++)
            {
                skaicius += i * i;
            }
            Console.WriteLine("Skaičių nuo 1 iki 10 kvadratų suma yra lygi: " + skaicius);

            var suma = 0;
            for (int i = 1; i <= 10; i++)
            {
                suma += i;
            }
            Console.WriteLine("Skaičių nuo 1 iki 10 sumos kvadratas lygus: " + suma*suma);
            Console.WriteLine("Skaičių nuo 1 iki 10 sumų kvadrato ir kvadratų sumos kirtumas lygus: " + ((suma*suma) - skaicius));

            Console.WriteLine();
            Console.WriteLine("Ta pati užduotis, tik intervalas nuo 1 iki 100");

            var skaicius1 = 0;
            for (int i = 1; i <= 100; i++)
            {
                skaicius1 += i * i;
            }
            Console.WriteLine("Skaičių nuo 1 iki 100 kvadratų suma yra lygi: " + skaicius1);

            var suma1 = 0;
            for (int i = 1; i <= 100; i++)
            {
                suma1 += i;
            }
            Console.WriteLine("Skaičių nuo 1 iki 100 sumos kvadratas lygus: " + suma1 * suma1);
            Console.WriteLine("Skaičių nuo 1 iki 100 sumų kvadrato ir kvadratų sumos kirtumas lygus: " + ((suma1 * suma1) - skaicius1));
        }
    }
}
