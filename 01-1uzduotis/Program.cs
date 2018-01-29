using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_1uzduotis
{
    class Program
    {
        static void Main(string[] args)

            /* Užduotis. Susikurkite C# programą, kurioje aprašykite praeitos užduoties kintamuosius kode.
                Vardas;
                Pavardė;
                Amžius;
                Ūgis;
                Svoris;
                Aukštoji mokykla;
                Akademinės grupės kodas;
                Kursas;
                Studijų programos pavadinimas;
                Atsiskaitytų kreditų skaičius;
            */
        {
            var vardas = "Giedrė";
            var pavarde = "Kniūkštienė";
            var amzius = 28;
            var ugis = 169;
            var svoris = 60;
            var aukstoji_mokykla = "ASU";
            var akademines_grupes_kodas = 7;
            var kursas = 4;
            var studiju_programos_pavadinimas = "Apskaita ir finansai";
            var atsiskaitytu_kreditu_skaicius = 100;

            Console.WriteLine(vardas + " " + pavarde);
            Console.WriteLine(amzius);
            Console.WriteLine(ugis);
            Console.WriteLine(svoris);
            Console.WriteLine(aukstoji_mokykla);
            Console.WriteLine(akademines_grupes_kodas);
            Console.WriteLine(kursas);
            Console.WriteLine(studiju_programos_pavadinimas);
            Console.WriteLine(atsiskaitytu_kreditu_skaicius);
        }
    }
}
