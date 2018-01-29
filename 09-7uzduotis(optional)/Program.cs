using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_7uzduotis_optional_
{
    class Program
    {
        // (Optional task) Be daugybos veiksmo programoje sudauginti du skaičius.
        // 2*3
        // 2+2+2

        static void Main(string[] args)
        {
            var a = 2;
            var b = 3;
            var atsakymas = 0;

            for (int i = 0; i < b; i++)
            {
                // atsakymas += a;
                atsakymas = atsakymas + a;
            }

            Console.WriteLine("Daugyba: " + atsakymas);
        }
    }
}
