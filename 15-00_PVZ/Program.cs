using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_00_PVZ
{
    // NEPAVYKUSI UŽDUOTIS - TAISYTI

    class Automobilis
    {
        // prop -> tab x 2

            //kintamieji:
        public string Spalva { get; set; }
        public string Marke { get; set; }
        public string Modelis { get; set; }
        public int Rida { get; set; }
        public int Pavaros { get; set; }
        public double DarbinisTuris { get; set; }
        public int GaliaKw { get; set; }

        // ctor -> tab x 2 - konstruktorius

        public Automobilis() // nebera return tipo
        {

        }

        public Automobilis(string spalva, string marke, string modelis, int rida, int pavaros, double darbinisTuris, int galiaKw)
        {

        }
        
        public void Isvedimas()
        {
            Console.WriteLine("Automobilio {0} {1} duomenys", Marke, Modelis);
            Console.WriteLine("Spalva: " + Spalva);
            Console.WriteLine("Rida: " + Rida);
            Console.WriteLine("Pavarų skaičius: " + Pavaros);
            Console.WriteLine("Darbinis tūris: " + DarbinisTuris);
            Console.WriteLine("Galia, KW:" + GaliaKw);
            Console.WriteLine();

        }

        public void Ivedimas()
        {
            Console.Write("Įveskite automobilio markę: ");
            Marke = Console.ReadLine();

            Console.Write("Įveskite automobilio modelį: ");
            Modelis = Console.ReadLine();

            Console.Write("Įveskite automobilio spalvą: ");
            Spalva = Console.ReadLine();

            Console.Write("Įveskite automobilio ridą: ");
            Rida = Convert.ToInt32(Console.ReadLine());

            Console.Write("Įveskite pavarų skaičių: ");
            Pavaros = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Įveskite darbinį turį: ");
            //DarbinisTuris = Convert.ToDouble(Console.ReadLine());

            string darbTuris = Console.ReadLine();
            double darbTurisSk;
            bool pavyko = double.TryParse(darbTuris, out darbTurisSk);

            if (pavyko)
            {
                DarbinisTuris = darbTurisSk; // jei pavyko
            }
            else // jei nepavyko 
            {
                DarbinisTuris = 0; // priskiriame default reikšmę
            }

            Console.WriteLine("Įveskite automobilio galią: ");
            GaliaKw = Convert.ToInt32(Console.ReadLine());


            // ....
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Automobilis auto = new Automobilis();
            //var auto = new Automobilis();
            auto.Marke = "Audi";
            auto.Modelis = "A6";
            auto.Pavaros = 6;
            auto.GaliaKw = 120;
            auto.Rida = 60000;
            auto.Spalva = "Juoda";
            auto.DarbinisTuris = 2.0;

            Console.WriteLine(auto.Marke);
            Console.WriteLine(auto.Modelis);
            Console.WriteLine(auto.Pavaros);
            Console.WriteLine(auto.GaliaKw);
            Console.WriteLine(auto.Rida);
            Console.WriteLine(auto.Spalva);
            Console.WriteLine(auto.DarbinisTuris);
            Console.WriteLine();

            var auto2 = new Automobilis // objekto inicializavimas
            {
                Marke = "Audi",
                Modelis = "A6",
                Pavaros = 6,
                GaliaKw = 120,
                Rida = 60000,
                Spalva = "Juoda",
                DarbinisTuris = 2.0
            };
                Console.WriteLine(auto2.Marke);
                Console.WriteLine(auto2.Modelis);
                Console.WriteLine(auto2.Pavaros);
                Console.WriteLine(auto2.GaliaKw);
                Console.WriteLine(auto2.Rida);
                Console.WriteLine(auto2.Spalva);
                Console.WriteLine(auto2.DarbinisTuris);
                Console.WriteLine();

            var auto3 = new Automobilis("Audi", "A6", "Juoda", 120, 6, 2.0, 120);
            
            Console.WriteLine(auto3.Marke);
            Console.WriteLine(auto3.Modelis);
            Console.WriteLine(auto3.Spalva);
            Console.WriteLine(auto3.GaliaKw);
            Console.WriteLine(auto3.Pavaros);
            Console.WriteLine(auto3.DarbinisTuris);
            Console.WriteLine(auto3.Rida);
            
            auto3.Isvedimas();

            var auto4 = new Automobilis();
            auto4.Ivedimas();
            auto4.Isvedimas();

        }
    }
}
