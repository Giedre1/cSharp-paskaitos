using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_02_2uzduotis
{
    class Program
    {
        /* Liepkite vartotojui įvesti egzamino rezultatą (0-100), su viena sąlyga, per atskiras else if dalis, patikrinti šias ribas:
            ar gautas rezultatas yra lygus 100;
            ar gautas rezultatas yra lygus arba didesnis nei 80;
            ar gautas rezultatas yra lygus arba didesnis nei 50;
            ar gautas rezultatas yra lygus arba didesnis nei 20;
            ar gautas rezultatas yra mažesnis nei 20;
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite egzamino rezultatą");
            var rezultatas = Convert.ToInt32(Console.ReadLine());

            if (rezultatas == 100)
            {
                Console.WriteLine("Egzamino rezultatas yra 100");
            }
            else if (rezultatas >= 80)
            {
                Console.WriteLine("Egzamino rezultatas yra 80 arba daugiau");
            }
            else if (rezultatas >= 50)
            {
                Console.WriteLine("Egzamino rezultatas yra 50 arba daugiau");
            }
            else if (rezultatas >= 20)
            {
                Console.WriteLine("Egzamino rezultatas yra 20 arba daugiau");
            }
            else if (rezultatas < 20)
            {
                Console.WriteLine("Egzamino rezultatas yra mažiau nei 20");
            }
        }
    }
}
