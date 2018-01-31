using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static public void Main(string[] args)
        {

            Program programa = new Program(); // metodo iškvietimas per objektą
            programa.pasisveikinti();

        }

        public void pasisveikinti()
        {
            Console.WriteLine("Labas");
            Console.WriteLine("Jūsų vardas?");
            Console.WriteLine("Labas, " + Console.ReadLine());
        }
    }

    class Program2
    {
        static public void Main(string[] args)
        {
            Program programa = new Program();
            programa.pasisveikinti();
        }
    }
}
