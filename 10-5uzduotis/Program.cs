using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_5uzduotis
{
    class Program
    {
        //Liepkite vartotojui įvedinėti atsitiktinius skaičius. Šį ciklą vykdyti tol, kol įvestas skaičius nesidalins iš 9.

        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite atsitiktinį skaičių");
            var skaicius = Convert.ToInt32(Console.ReadLine());

            while (skaicius % 9 != 0)
            {
                skaicius = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Jūs įvedėte skaičių, kuris dalinasi iš 9");
        }
    }
}
