using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_01_PVZ
{
    class Grupe
    {
        public List<Studentas> Studentai { get; set; } = new List<Studentas>();    // norėsim sudėti daug to paties objektų 
        /*public Grupe()
         {
            Studentas stud;
            Studentai = new List<Studentas>();
         }
         */
         public Grupe()
        {
            Studentai.Add(new Studentas("Jonas", "Jonaitis", 180, 22, 'V')); // čia iškart yra konstruktrius
            Studentai.Add(new Studentas("Petras", "Petraitis", 200, 29, 'V'));
            Studentai.Add(new Studentas("Ona", "Onaitė", 168, 25, 'M'));
            Studentai.Add(new Studentas("Liza", "Lizaitė", 170, 24, 'M'));

            //var studentas = new Studentas("aaa", "bbb", 30, 40, 'V');
           // Studentai.Add(studentas);  ?????
        }

        public void Isvedimas()
        {
            Console.WriteLine("Studentai");

            foreach (var studentas in Studentai)
            {
                studentas.Isvedimas();
            }
            Console.WriteLine();
            Console.WriteLine("Skaičiavimai");
            Console.WriteLine();

            Console.WriteLine("Žemiausias studentas");
            var zemiausias = ZemiausiasStudentas();
            zemiausias.Isvedimas();
            Console.WriteLine();

            Console.WriteLine("Vyriausias studentas");
            var vyriausias = VyriausiasStudentas();
            vyriausias.Isvedimas();
            Console.WriteLine();

            Console.WriteLine("Kiek moterų");
            var moterys = KiekMoteru();
            foreach (var moteris in moterys)
            {
                moteris.Isvedimas();
            }
            Console.WriteLine();

            Console.WriteLine("Kiek vyrų");
            var vyrai = KiekVyru();
            foreach (var vyras in vyrai)
            {
                vyras.Isvedimas();
            }
            Console.WriteLine();

            Console.WriteLine("Studentų amžiaus vidurkis: " + AmziuVidurkis());
            Console.WriteLine();
        }

        // grupes klaseje nauji metodai:
        // zemiausias studentas
        public Studentas ZemiausiasStudentas()
        {
            var zemiausias = Studentai.First();
            // var zemiausias = Studentai[0];

            foreach (var studentas in Studentai)
            {
                if (studentas.UgisCM < zemiausias.UgisCM)
                {
                    zemiausias = studentas;
                }
            }
            return zemiausias;
        }

        // vyriausias studentas
        public Studentas VyriausiasStudentas()
        {
            var vyriausias = Studentai.First();

            foreach (var studentas in Studentai)
            {
                if (studentas.Amzius > vyriausias.Amzius)
                {
                    vyriausias = studentas;
                }
            }
            return vyriausias;
        }

        // kiek moteru
        public List<Studentas> KiekMoteru()
        {
            List<Studentas> moterys = new List<Studentas>();

            foreach (var studentas in Studentai)
            {
                if (studentas.Lytis == 'M')
                {
                    moterys.Add(studentas);
                }
            }
            return moterys;
        }

        // kiek vyru
        public List<Studentas> KiekVyru()
        {
            List<Studentas> vyrai = new List<Studentas>();

            foreach (var studentas in Studentai)
            {
                if (studentas.Lytis == 'V')
                {
                    vyrai.Add(studentas);
                }
            }
            return vyrai;
        }


        // amziu vidurkis
        public double AmziuVidurkis()
        {
            double amziuSuma = 0;
            int studentuSk = 0;
            foreach (var studentas in Studentai)
            {
                amziuSuma += studentas.Amzius;
                studentuSk++;
            }
            return amziuSuma / studentuSk;
        }
    }
}
