using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_01uzduotis
{
    class Program
    {

        /*Susikurkite šiuos kintamuosius iškart su reikšmėmis:
            Vardas;
            Pavardė;
            Amžius.
            Pasirašykite metodą kuris leistų vartotojui pakeisti šių kintamųjų reikšmes ir tai sugebėtų atnaujinti main’e.
            Išveskite kintamųjų reikšmes main metode prieš kviečiant papildomą metodą ir po papildomo metodo kvietimo.
        */

        static void Main(string[] args)
        {
            var vardas = "aaa";
            var pavarde = "bbb";
            var amzius = 28;

            Isvedimas(vardas, pavarde, amzius);
            Ivedimas(ref vardas, ref pavarde, ref amzius);
            Isvedimas(vardas, pavarde, amzius);

        } // main pabaiga

        public static void Ivedimas(ref string vardas, ref string pavarde, ref int amzius)
        {
            Console.WriteLine("Programoje įvestas vardas: " + vardas);
            Console.Write("Įveskite naują: ");
            vardas = Console.ReadLine();

            Console.WriteLine("Programoje įvesta pavardė: " + pavarde);
            Console.Write("Įveskite naują: ");
            pavarde = Console.ReadLine();

            Console.WriteLine("Programoje įvestas amžius: " + amzius);
            Console.Write("Įveskite naują: ");
            amzius = Convert.ToInt32(Console.ReadLine());
        }

        public static void Isvedimas(string vardas, string pavarde, int amzius)
        {
            Console.WriteLine("{0} {1} ({2} m.) ", vardas, pavarde, amzius);
        }
    } // class pabaiga
}
