using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_2uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Išveskite į ekraną pasirinką skaičių, jo kvadratą ir jį pakeltą trečiuoju laipsniu.

            var skaicius = 8;
            Console.WriteLine(skaicius);  // skaičius 
            Console.WriteLine(skaicius * skaicius);  // kvadratas
            Console.WriteLine(Math.Pow(8, 2));  // kvadratas kitu būdu
            Console.WriteLine(skaicius * skaicius * skaicius);  // trečiuoju laipsniu
            Console.WriteLine(Math.Pow(8, 3));  // trečiuoju laipsniu kitu būdu
        }
    }
}
