using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_0_pvz
{
    class Program
    {
        static void Main(string[] args)
        {
            // studentu pavymiai

            int[] pazymiai = { 10, 8, 3, 5, 8, 7, 9 };

            Console.WriteLine(pazymiai[1]);  // 8
            Console.WriteLine(pazymiai[3]);  // 5
            Console.WriteLine(pazymiai[5]);  // 7
            Console.WriteLine(pazymiai[6]);  // 9
            Console.WriteLine(pazymiai[2]);  // 3
            Console.WriteLine(pazymiai[0]);  // 10

            // noriu pakeisti 3 i 4
            pazymiai[2] = 4;

            // 7 -> 1
            pazymiai[5] = 1;

            // 10 -> 9

            pazymiai[0] = 9;

            Console.WriteLine();

            foreach (var pazymys in pazymiai)
            {
                Console.Write(pazymys + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < pazymiai.Length; i++)
            {
                Console.Write(pazymiai[i] + " ");
            }

            Console.WriteLine();

            // vardai

            var vardai = new string[7];

            for (int i = 0; i < vardai.Length; i++)
            {
                Console.Write("Įveskite vardą");
                vardai[i] = Console.ReadLine();
            }
            Console.WriteLine();

            // bandom viska is masyvo

            foreach (var vardas in vardai)
            {
                Console.Write(vardas + ", ");
            }

            Console.WriteLine();

            // pazymiai

            Console.WriteLine("Kiek pažymių norite suvesti?");
            var kiek = Convert.ToInt32(Console.ReadLine());

            var pazymiai2 = new int[kiek];

            for (int i = 0; i < pazymiai2.Length; i++)
            {
                Console.WriteLine("Įveskite {0}-ąjį pažymį: ", i+1);
                pazymiai2[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var pazymys in pazymiai2)
            {
                Console.WriteLine("[{0}]", pazymys);
            }

            Console.WriteLine();

            // algoritmas suma

            var suma = 0;

            foreach (var pazymys in pazymiai2)
            {
                suma += pazymys;
                // sum = suma + pazymys
            }

            Console.WriteLine("Suma " + suma);

            Console.WriteLine();

            // algoritmas - min pazymys

            var maziausias = pazymiai2[0]; // 0 arba maziausias is masyvo

            foreach (var pazymys in pazymiai2)
            {
                if (pazymys < maziausias)
                {
                    maziausias = pazymys;
                }
            }
            Console.WriteLine("Mažiausias pažymys " + maziausias);
            // Console.WriteLine("Mažiausias pažymys " + pazymiai2.Min()); // galima tik su basic info naudoti

            Console.WriteLine();

            // algoritmas - max pazymyms

            var didziausias = pazymiai2[0]; //arba var didziausias = 0;

            foreach (var pazymys in pazymiai2)
            {
                if (pazymys > didziausias)
                {
                    didziausias = pazymys;
                }
            }
            Console.WriteLine("Didžiausias pažymys " + didziausias);
            // Console.WriteLine("Didžiausias pažymys " + pazymiai2.Max()); // galima tik su basic info naudoti

            Console.WriteLine();

            // vidurkis

            // sumos algoritmas

            var vidurkis = (double)suma / pazymiai2.Length;           
        }
    }
}
