using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_02_3uzduotis
{
    class Program
    {
        /* Liepkite vartotojui įvesti šios dienos oro temperatūrą, atlikite šiuos patikrinimus:
            ar temperatūra < 0 - išvesti “žiauriai šalta”;
            ar temperatūra < 10 - išvesti “labai šalta”;
            ar temperatūra < 20 - išvesti “šalta”;
            ar temperatūra < 30 - išvesti “normali temperatūra”;
            ar temperatūra < 40 - išvesti “karšta”;
            ar temperatūra > 40 - išvesti “visiškai degina”;
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite šios dienos temperatūrą");
            var t = Convert.ToInt32(Console.ReadLine());

            if (t < 0)
            {
                Console.WriteLine("Žiauriai šalta");
            }
            else if (t < 10)
            {
                Console.WriteLine("Labai šalta");
            }
            else if (t < 20)
            {
                Console.WriteLine("Šalta");
            }
            else if (t < 30)
            {
                Console.WriteLine("Normali temperatūra");
            }
            else if (t < 40)
            {
                Console.WriteLine("Karšta");
            }
            else if (t > 40)
            {
                Console.WriteLine("Visiškai degina");
            }
        }
    }
}
