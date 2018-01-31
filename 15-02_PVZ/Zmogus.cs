using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_02_PVZ
{
    class Zmogus
    {
        public string Vardas { get; private set; }
        public string Pavarde { get; private set; }
        public int UgisCm { get; private set; }
        public int Amzius { get; private set; }
        public char Lytis { get; private set; }

        public Zmogus(string vardas, string pavarde, int ugisCm, int amzius, char lytis)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            UgisCm = ugisCm;
            Amzius = amzius;
            Lytis = lytis;
        }
            public Zmogus()
        {
            Ivedimas();
        }
       
        // isvedimas 
        public void Isvedimas()
        {
            Console.WriteLine("{0} {1} ({2} m.), kurio ūgis {3} yra lyties {4}", Vardas, Pavarde, Amzius, UgisCm, Lytis);
        }

        public void Ivedimas()
        {
            Console.Write("Įveskite vardą: ");
            Vardas = Console.ReadLine();

            Console.Write("Įveskite pavardę: ");
            Pavarde = Console.ReadLine();

            Console.Write("Įveskite amžių: ");
            Amzius = Convert.ToInt32(Console.ReadLine());

            Console.Write("Įveskite ūgį: ");
            UgisCm = Convert.ToInt32(Console.ReadLine());

            Console.Write("Įveskite lytį: ");
            Lytis = Convert.ToChar(Console.ReadLine());
        }
    }
}
