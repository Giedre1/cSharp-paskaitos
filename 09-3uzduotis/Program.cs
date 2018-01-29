using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_3uzduotis
{
    class Program
    {
        // Parašyti for, kuris išvestų kas trečią skaičių, pradedant 1 ir baigiant 20. Kiekvieną skaičių išvesti toje pačioje eilutėje tačiau apskliaudžiant laužtiniais skliaustais. Pvz.: [1][3][5]...

        static void Main(string[] args)
        {
            for (int i = 1; i < 20; i+=3)
            {
                Console.Write("[{0}]", i);
            }
        }
    }
}
