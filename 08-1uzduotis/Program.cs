
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_1uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Darbo diena trunka 8 valandas");

            Console.WriteLine("Kiek darbuotojas gali iškepti kepalų per valandą?");
            var a = Convert.ToInt16(Console.ReadLine()); //kepalu skaicius per valanda

            Console.WriteLine("Kiek darbuotojų turi kepykla?");
            var b = Convert.ToInt16(Console.ReadLine()); //darbuotoju skaicius

            Console.WriteLine("Kokia vieno kepalo savikaina?");
            var c = Convert.ToInt16(Console.ReadLine()); //kepalo savikaina

            Console.WriteLine("Kiek kainuoja vienas kepalas?");
            var d = Convert.ToInt16(Console.ReadLine()); //kepalo pardavimo kaina

            Console.WriteLine("Kiek kepykla turi užsakymų?");
            var e = Convert.ToInt16(Console.ReadLine()); //uzsakymu skaicius per diena

            double rezultatas;
            rezultatas = a * b * 8;

            Console.WriteLine("Kepykla per vieną darbo dieną iškeps " + rezultatas + "duonos kepalų");

            double savikaina;
            savikaina = rezultatas * c;

            Console.WriteLine("Visų kepalų savikaina yra " + savikaina);

            double pajamos;
            pajamos = rezultatas * d;

            Console.WriteLine("Gautos pajamos yra " + pajamos);

            double pelnas;
            pelnas = pajamos - savikaina;

            Console.WriteLine("Gautas pelnas yra " + pelnas);

            if (rezultatas>=e)
            {
                Console.WriteLine("Suspės");
            }
            else
            {
                Console.WriteLine("Nespėjo");
            }
        }
        }
    }
}
