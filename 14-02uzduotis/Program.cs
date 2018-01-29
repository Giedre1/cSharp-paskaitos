using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

            /* TEMA: dienų temperatūros
                kuriant sąrašą sukurti metodus:
                - įvedimui
                - išvedimui
                - visų skaičiavimų išvedimui
                - atrinkimui į naują sarašą
            */

namespace _14_02uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var temp = new List<int>();
            Program programa = new Program();

            // duomenu suvedimui
            programa.ivedimas(temp);

            // duomenu isvedimui
            programa.isvedimas(temp, "PRADINIAI DUOMENYS");

            // suma
            programa.suma(temp);

            // min
            programa.maziausias(temp);

            // max
            programa.didziausias(temp);

            // vidurkis (vidurkis kviecia sumos metoda)
            programa.skaiciavimai(temp);

            // atrinkimui i kita sarasa tinkamu duomenu
            List<int> atrinkti = programa.atrinkimas(temp);
            programa.isvedimas(atrinkti, "ATRINKTI DUOMENYS");
        }
        public void ivedimas(List<int> sarasas)
        {
            var dar = true;

            while (dar)
            {
                Console.WriteLine("Įveskite temperatūras: ");      // duomenu suvedimui
                var t = Convert.ToInt32(Console.ReadLine());
                sarasas.Add(t);

                Console.WriteLine("Ar norite kartoti? jo/ne");     // ciklo kartojimui - taip,ne?
                var kartoti = Console.ReadLine();

                if (kartoti != "jo")
                {
                    dar = false;
                }
            }
        }
        public void isvedimas(List<int> sarasas, string komentaras)
        {
            Console.WriteLine(komentaras);
            foreach (var t in sarasas)
            {
                Console.WriteLine("[{0}]", t);
            }
        }
        public int suma(List<int> sarasas)
        {
            return sarasas.Sum();
        }
        public int maziausias(List<int> sarasas)
        {
            return sarasas.Min();
        }
        public int didziausias(List<int> sarasas)
        {
            return sarasas.Max();
        }
        public double vidurkis(List<int> sarasas)
        {
            var vidurkis = (double)suma(sarasas) / sarasas.Count;
            return vidurkis;
        }
        public void skaiciavimai(List<int> sarasas)
        {
            Console.WriteLine("Suma: " + suma(sarasas));
            Console.WriteLine("Min: " + maziausias(sarasas));
            Console.WriteLine("Max: " + didziausias(sarasas));
            Console.WriteLine("Vidurkis: " + vidurkis(sarasas));
        }
        public List<int> atrinkimas(List<int> pradiniai)
        {
            var atrinkti = new List<int>();

            foreach (var t in pradiniai)
            {
                if (t > 20)
                {
                    atrinkti.Add(t);
                }
            }
            return atrinkti;
        }
    }
}
