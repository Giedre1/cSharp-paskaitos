using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_01_PVZ

{
    class Program
    {
        static void Main(string[] args)
        {
            var stud1 = new Studentas("Jonas", "Jonaitis", 180, 27, 'V');
            var stud2 = new Studentas("Ona", "Onaitė", 165, 25, 'M');

            stud1.Isvedimas();
            stud2.Isvedimas();
            Console.WriteLine();

            var grupe = new Grupe();
            grupe.Isvedimas();
        }
    }
}
