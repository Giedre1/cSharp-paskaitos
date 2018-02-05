using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_kontroline_uzd_20170201
{
    public class Miestas
    {
        public string Pavadinimas { get; private set; }
        public int GyventojuSkaicius { get; private set; }
        public double PlotasKvKm { get; private set; }
        public double GyvTankis { get; private set; }

        public Miestas(string pavadinimas, int gyventojuSkaicius, double plotasKvKm)
        {
            Pavadinimas = pavadinimas;
            GyventojuSkaicius = gyventojuSkaicius;
            PlotasKvKm = plotasKvKm;
            GyvTankis = showTankis();
        }
        
        private double showTankis()
        {
            throw new NotImplementedException();
        }

        public Miestas(string eilute)
        {
            string[] isskaidyta = eilute.Split(';');
            Pavadinimas = isskaidyta[0];
            GyventojuSkaicius = Convert.ToInt32(isskaidyta[1]);
            PlotasKvKm = Convert.ToDouble(isskaidyta[2]);
            GyvTankis = Math.Round((GyventojuSkaicius / PlotasKvKm), 2);
        }
    }
}
