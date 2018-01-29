using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_7uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // (Pažengusiems) Sukurkite skaičių spėliojimo žaidimą.
            // 1. random klases objektas
            // 2. sugeneruoti random skaiciu
            // 3. susikurti kintamaji zmogaus atsakymui saugoti
            // 4. sukti cikla kol zmogaus atsakymas nesutampa su sugeneruotu random skaiciumi
            //   4.1. pasakykite, kad spetu skaiciu
            //   4.2. leiskite vartotojui ivesti skaiciu
            //   4.3. lyginti vartotojo ivedima su random skaiciumi, isvesti ar spaltas yra azesnis ar didesnis uz spejima, o jeigu lygus - pasveiktini vartotoja

            var atsitiktinis = new Random();
 
            var slaptas = atsitiktinis.Next(1, 11);

            Console.WriteLine("Bandykite atspėti slaptą skaičių nuo 1 iki 10");
            var spejimas = Convert.ToInt32(Console.ReadLine());

           while (slaptas != spejimas)
            {
                if (slaptas > spejimas)
                {
                    Console.WriteLine("Atsitiktinis skaičius yra didesnis");
                    spejimas = Convert.ToInt32(Console.ReadLine());
                }
                else if (slaptas < spejimas)
                {
                    Console.WriteLine("Atsitiktinis skaičius yra mažesnis");
                    spejimas = Convert.ToInt32(Console.ReadLine());
                }
            }
             Console.WriteLine("ATSPĖJOTE, atsitiktinis skaičius yra " + spejimas);
        }
    }
}
