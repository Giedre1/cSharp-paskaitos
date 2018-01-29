using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_1uzduotis
{

    class Matematika
    {
        public static int suma(int a, int b)
        {
            return a + b;
        }

        public static int skirtumas(int a, int b)
        {
            return a - b;
        }

        public static int sandauga(int a, int b)
        {
            return a * b;
        }

        public static double dalmuo(int a, int b)
        {
            return (double) a / b;
        }
    }

    class Program
    {
        static public void Main(string[] args)
        {
            pasisveikinti();
            atsisveikinti();

            Program programa = new Program(); // metodo iškvietimas per objektą
            programa.pinigai();
            programa.Automobilis();

            var suma = Matematika.suma(8, 6);
            Console.WriteLine(suma);

            Console.WriteLine(Matematika.suma(8, 6)); // išvedimo alternatyvus variantas
        }

        static void pasisveikinti()
        {
            Console.WriteLine("Labas");
            Console.WriteLine("Jūsų vardas?");
            Console.WriteLine("Labas, " + Console.ReadLine());
        }

        static public void atsisveikinti() // static ant klasės, public ant objekto - todėl kitaip kviečiamas
        {
            Console.WriteLine("Čiau");
        }

        public void pinigai()
        {
            Console.WriteLine("Pasakykite, ką daro pinigai?");
            var pinigai = Console.ReadLine();
            Console.WriteLine("Ačiū, Jūsų atsakymas priimtas, jis yra:");
            Console.WriteLine(pinigai);
        }

        public void Automobilis()
        {
            Console.WriteLine("Ką vairuojate?");
            var auto = Console.ReadLine();
            if (auto == "kamaz")
            {
                Console.WriteLine("Nice");
            }
        }

    }
}
