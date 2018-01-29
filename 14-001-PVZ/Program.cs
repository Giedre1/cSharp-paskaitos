
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_001_PVZ
{
    class Program
    {
        static void Main(string[] args)
        {
            //TEMA MAŠINOS

            var nuvaziuotikm = new List<int>();
            Program programa = new Program();

            // duomenu suvedimui
            programa.ivedimas(nuvaziuotikm);

            // duomenu isvedimui
            programa.isvedimas(nuvaziuotikm, "PRADINIAI DUOMENYS");

            // skaiciavimu iskvietimui, kuris kvies siuos atskirus metodus

            // suma
            programa.suma(nuvaziuotikm);

            // min
            programa.maziausias(nuvaziuotikm);

            // max
            programa.didziausias(nuvaziuotikm);

            // vidurkis (vidurkis kviecia sumos metoda)
            programa.skaiciavimai(nuvaziuotikm);

            // atrinkimui i kita sarasa tinkamu duomenu
            List<int> atrinkti = programa.atrinkimas(nuvaziuotikm);
            programa.isvedimas(atrinkti, "ATRINKTI DUOMENYS");
        }

        // metodai:

        public void ivedimas(List<int> sarasas)
        {
            var dar = true;

            while (dar)
            {
                Console.WriteLine("Įveskite km: ");              // duomenu suvedimui
                var km = Convert.ToInt32(Console.ReadLine());
                sarasas.Add(km);

                Console.WriteLine("Ar norite kartoti? t/n");     // ciklo kartojimui - taip,ne?
                var kartoti = Console.ReadLine();

                if (kartoti != "t")
                {
                    dar = false;
                }
            }
        }
        public void isvedimas(List<int> sarasas, string komentaras)
        {
            Console.WriteLine(komentaras);
            foreach (var km in sarasas)
            {
                Console.WriteLine("[{0}]", km);
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
            // daugiau nei 300k, laikysim jau kaip grabą
            var atrinkti = new List<int>();

            foreach (var km in pradiniai)
            {
                if (km > 300000)
                {
                    atrinkti.Add(km);
                }
            }
            return atrinkti;
        }
    }
}
