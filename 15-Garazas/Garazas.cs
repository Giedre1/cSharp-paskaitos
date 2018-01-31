using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Garazas
{
    class Garazas
    {
        // pavadinimas, adresas, meistru skaicius, automobiliu sarasas
        // pilnas konstruktorius ctor
        // isvedimo metodas

        public string Pavadinimas { get; private set; }
        public string Adresas { get; private set; }
        public int MeistruSk { get; private set; }
        public List<Automobilis> Automobiliai { get; private set; }

        public Garazas (string pavadinimas, string adresas, int meistruSk, List<Automobilis> automobiliai)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            MeistruSk = meistruSk;
            Automobiliai = automobiliai;
        }

        public void Isvedimas()
        {
            Console.Write("Garažo pavadinimu {0} adresas yra {1}, jame dirba {2} meistrai.", Pavadinimas, Adresas, MeistruSk);

            Console.WriteLine("Remontuojami automobiliai: ");

            for (int i = 0; i < Automobiliai.Count; i++)
            {
                Console.Write(i+1 + " automobilis: ");
                Automobiliai[i].Isvedimas();
            } 
            
        }
        public void AtnaujintiPasirinkta()
        {
            Console.WriteLine("Kurį automobilį keisti? ");
            var kuris = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pasirinktas automobilis:");
            Automobiliai[kuris - 1].Isvedimas();

            Console.WriteLine("Pasirinkite, ką norite daryti?");
            Console.WriteLine("1 - atsukti ridą");
            Console.WriteLine("2 - perdažyti");
            Console.WriteLine("3 - padidinti galią");

            var pasirinkimas = Convert.ToInt32(Console.ReadLine());

            switch (pasirinkimas)
            {
                case 1:
                    Automobiliai[kuris - 1].RidosAtsukimas();
                    break;
                case 2:
                    Automobiliai[kuris - 1].Perdazymas();
                    break;
                case 3:
                    Automobiliai[kuris - 1].GaliosKelimas();
                    break;
            }

            Console.WriteLine("Atnaujintas automibilis:");
            Automobiliai[kuris - 1].Isvedimas();
        }
        public void Skaiciavimai()
        {
            Console.WriteLine("Total Rida: " + TotalRida());// isvesi visus skaicivimus
        }
        public int TotalRida()
        {
            var suma = 0;

            foreach (var automobilis in Automobiliai)
            {
                suma += automobilis.Rida;

            }
            return suma;
        }

    }
}
