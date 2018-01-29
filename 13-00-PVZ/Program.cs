using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_00_PVZ
{
    class Program
    {
        static void Main(string[] args)
        {
            // pazymiu sarasas

            var pazymiai = new List<int>(); // tuščias sąrašas

            Console.WriteLine("Įveskite pažymius, o norėdami sustabdyti, parašykite -1");
            int paz;

            do
            {
                paz = Convert.ToInt32(Console.ReadLine());
                if (paz != -1)
                {
                    pazymiai.Add(paz);
                }
            } while (paz != -1);

            Console.WriteLine();

            foreach (var rezultatas in pazymiai)
            {
                Console.WriteLine(rezultatas);
            }
        }
    }
}
