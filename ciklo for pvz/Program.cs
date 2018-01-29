using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciklo_for_pvz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.Write(i);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + ", ");
            }

            Console.WriteLine();

            for (int i = 1; i < 10; i += 2) // 2 - koks intervalas
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            for (int i = 5; i < 10; i++)
            {
                Console.Write("[{0}] ", i);
            }

            Console.WriteLine();

            // 4 7 10 13 16 19 

            for (int i = 4; i < 20; i += 3)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            var pradzia = 10;
            var pabaiga = 15;

            for (int i = pradzia; i <= pabaiga; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            // for (;;) begalinis ciklas
            // {
            // Console.Write(aaaaaaaaaa);
            // }
        }
    }
}
