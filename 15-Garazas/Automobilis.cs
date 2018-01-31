using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Garazas
{
    class Automobilis
    {
        // modelis
        // marke
        // gamybos metai
        // rida
        // galia
        // darbinis turis
        // spalva
        // pilnas konstruktorius su propg
        // isvedimo metodas

        public string Marke { get; private set; }
        public string Modelis { get; private set; }
        public int Metai { get; private set; }
        public int Rida { get; private set; }
        public int GaliaKw { get; private set; }
        public double DarbinisTuris { get; private set; }
        public string Spalva { get; private set; }

        public Automobilis(string marke, string modelis, int metai, int rida, int galiaKw, double darbinisTuris, string spalva)
        {
            Marke = marke;
            Modelis = modelis;
            Metai = metai;
            Rida = rida;
            GaliaKw = galiaKw;
            DarbinisTuris = darbinisTuris;
            Spalva = spalva;
        }
       
        public void Isvedimas()
        {
            Console.WriteLine("Automobilis {0} {1} ({2} m.), {3} km, {4} kw, {5} l, {6}", Marke, Modelis, Metai, Rida, GaliaKw, DarbinisTuris, Spalva);
        }
        // nauji metodai: atsukti ridą, perdazyti, pakelti galia

        public void RidosAtsukimas()
        {
            Console.WriteLine("Dabartinė rida: " + Rida);
            Console.Write("Įveskite norimą ridą: ");
            var naujaRida = Convert.ToInt32(Console.ReadLine());
            Rida = naujaRida;
            Console.WriteLine("Ridą pakeisti į: " + Rida);
        }

        public void Perdazymas()
        {
            Console.WriteLine("Dabartinė spalva: " + Spalva);
            Console.Write("Įveskite norimą spalvą: ");
            var naujaSpalva = Console.ReadLine();
            Spalva = naujaSpalva;
            Console.WriteLine("Spalvą pakeisti į: " + Spalva);
        }

        public void GaliosKelimas()
        {
            Console.WriteLine("Dabartinė galia: " + GaliaKw);
            Console.Write("Įveskite norimą automobilio galią: ");
            var naujaGalia = Convert.ToInt32(Console.ReadLine());
            GaliaKw = naujaGalia;
            Console.WriteLine("Spalvą automobilio galią į: " + GaliaKw);
        }
    }
}
