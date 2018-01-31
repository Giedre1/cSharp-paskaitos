using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_01_PVZ
{
    class Studentas
    {
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public int UgisCM { get; set; }
        public int Amzius { get; set; }
        public char Lytis { get; set; }

        
        public int MyProperty { get; private set; }

        public Studentas()
        {

        }

        public Studentas(string vardas, string pavarde, int ugisCM, int amzius, char lytis)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            UgisCM = ugisCM;
            Amzius = amzius;
            Lytis = lytis;
        }
        // isvedimo metodas

        public void Isvedimas()
        {
            Console.WriteLine("Studentas/-ė {0} {1} ({2} m.) yra {3} cm ūgio, jo/jos lytis - {4}", Vardas, Pavarde, Amzius, UgisCM, Lytis);

        }
    }
}
