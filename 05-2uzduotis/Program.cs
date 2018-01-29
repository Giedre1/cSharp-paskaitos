using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_2uzduotis
{
    class Program
    {
        // Liepkite vartotojui įvesti savo amžių. Jei amžius yra 18 arba daugiau, tuomet į ekraną išveskite, kad “jūs galite balsuoti”.

        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite savo amžių");

            var amzius = Convert.ToInt32(Console.ReadLine());

            if (amzius >= 18)
            {
                Console.WriteLine("Jūs galite balsuoti");
            }

            if (amzius < 18)
            {
                Console.WriteLine("Jūs negalite balsuoti");
            }
        }
    }
}
