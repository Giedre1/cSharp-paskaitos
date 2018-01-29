using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_7uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parašykite programą, kuri laipsnius paverstų į kelvinus ir fahrenheitus.

            Console.WriteLine("Įveskite laipsnius:");
            int celcius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kelvin = {0}", celcius + 273);
            Console.WriteLine("Farenheit = {0}", celcius * 18 / 10 + 32);
        }
    }
}
