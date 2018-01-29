using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_6uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Liepkite vartotojui įvesti tris skaičius. Į ekraną išveskite šiuos skaičius ir jų vidurkį. Pvz.:Įvestų skaičių 4, 5, 8 vidurkis: 5,6.

            Console.WriteLine("Įveskite tris skaičius");
            var a = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());
            var c = Convert.ToDouble(Console.ReadLine());

            var vidurkis = (a+b+c)/3;
            Console.WriteLine("Įvestų skaičių vidurkis:" + vidurkis);
        }
    }
}
