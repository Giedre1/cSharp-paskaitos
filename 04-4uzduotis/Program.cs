using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_4uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Liepkite vartotojui įvesti tris skaičius. 
               Išveskite visų šių skaičių sumą, skirtumą, sandaugą ir dalmenį, nurodant atliekamus veiksmus ir šių skaičių reikšmes ekrane. 
               Pvz.:5 + 3 + 8 = 16
                     5 - 3 - 8 = -6
                     ...
            */

            Console.WriteLine("Įveskite tris skaičius");
            var skaicius1 = Convert.ToInt32(Console.ReadLine());
            var skaicius2 = Convert.ToInt32(Console.ReadLine());
            var skaicius3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}+{1}+{2}={3}", skaicius1, skaicius2, skaicius3, skaicius1 + skaicius2 + skaicius3);
            Console.WriteLine("{0}-{1}-{2}={3}", skaicius1, skaicius2, skaicius3, skaicius1 - skaicius2 - skaicius3);
            Console.WriteLine("{0}*{1}*{2}={3}", skaicius1, skaicius2, skaicius3, skaicius1 * skaicius2 * skaicius3);
            Console.WriteLine("{0}/{1}/{2}={3}", skaicius1, skaicius2, skaicius3, skaicius1 / skaicius2 / skaicius3);

        }
    }
}
