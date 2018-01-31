using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_02_PVZ
{
    class Seima
    {
        public string Adresas { get; private set; }  // propg +tab
        public List<Zmogus> Zmones { get; private set; } = new List<Zmogus>();

        public Seima(string adresas, List<Zmogus> zmones)
        {
            Adresas = adresas;
            Zmones = zmones;
        }

       public Seima()
        {
            Ivedimas();
        }

        public void Isvedimas()
        {
            Console.WriteLine("Šeima gyvena {0} adresu.", Adresas);

            foreach (var zmogus in Zmones)
            {
                zmogus.Isvedimas();
            }
        }

        public void Ivedimas()
        {
            Console.Write("Įveskite adresą: ");
            Adresas = Console.ReadLine();

            Console.Write("Kiek žmonių suvesti? ");  //klausti kiek zmoniu suvesti
            var kiek = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < kiek; i++)   //sukurti for cikla tiek kartu kiek reikia
            {
                var zmogus = new Zmogus();  //kurti tuscia zmogaus aobjekta naudojant () - tuscia konstruktoriu. Jis kvies ivedimo metoda  

                Zmones.Add(zmogus);   //zmogaus objekta ikelti i zmoniu sarasa
            }  
        }
    }
}
