using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_kontroline_uzd_20170201
{
    public class Pasaulis
    {
        public List<Salis> SaliuSarasas { get; private set; } = new List<Salis>();

        public Miestas DaugiausiaiGyventoju()
        {
            var gyv = SaliuSarasas.First().MiestuSarasas.First();

            foreach (var salis in SaliuSarasas)
            {
                foreach (var miestas in salis.MiestuSarasas)
                {
                    if (miestas.GyventojuSkaicius > gyv.GyventojuSkaicius)
                    {
                        gyv = miestas;
                    }
                }
            }

            return gyv;
        }
            public Miestas MaziausiaiGyventoju()
            {
                var gyv1 = SaliuSarasas.First().MiestuSarasas.First();

                foreach (var salis in SaliuSarasas)
                {
                    foreach (var miestas in salis.MiestuSarasas)
                    {
                        if (miestas.GyventojuSkaicius < gyv1.GyventojuSkaicius)
                        {
                            gyv1 = miestas;
                        }
                    }
                }

                return gyv1;
            }

        public Miestas DidziausiasPlotas()
        {
            var plotas = SaliuSarasas.First().MiestuSarasas.First();

            foreach (var salis in SaliuSarasas)
            {
                foreach (var miestas in salis.MiestuSarasas)
                {
                    if (miestas.PlotasKvKm > plotas.PlotasKvKm)
                    {
                        plotas = miestas;
                    }
                }
            }

            return plotas;
        }

        public Miestas MaziausiasPlotas()
        {
            var plotas1 = SaliuSarasas.First().MiestuSarasas.First();

            foreach (var salis in SaliuSarasas)
            {
                foreach (var miestas in salis.MiestuSarasas)
                {
                    if (miestas.PlotasKvKm < plotas1.PlotasKvKm)
                    {
                        plotas1 = miestas;
                    }
                }
            }

            return plotas1;
        }
    }
}

