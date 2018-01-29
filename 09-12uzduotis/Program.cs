using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_12uzduotis
{
    class Program
    {
        // The "Fizz-Buzz test" is an interview question designed to help filter out the 99.5% of programming job candidates who can't seem to program their way out of a wet paper bag. 
        // The text of the programming assignment is as follows:
        // "Write a program that prints the numbers from 1 to 100. But for multiples of three print “Fizz” instead of the number and for the multiples of five print “Buzz”. 
        // For numbers which are multiples of both three and five print “FizzBuzz”."

        /* 
         1
         2
         Fizz
         4
         Buzz
         Fizz
         7
         8
         Fizz
         Buzz
         11
         Fizz
         13
         14 
         FizzBuzz
         ...
         */

        static void Main(string[] args)
        {
            var a = "Fizz";
            var b = "Buzz";
            var c = "FizzBuzz";

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(a);
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(b);
                }
                else if (i % 3 == 0 && i % 5 == 0)   // kelti į viršų (if)
                    // else if (i % 15 == 0)
                {
                    Console.WriteLine(c);
                }
                else
                    Console.WriteLine(i);
            }
        }
    }
}
