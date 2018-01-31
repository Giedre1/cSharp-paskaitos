using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_03_TELEFONAI
{
    public class Telefonas
    {
        public string Gamintojas { get; private set; }
        public string Modelis { get; private set; }
        public int  Metai { get; private set; }
        public string OS { get; private set; }

        public Telefonas(string gamintojas, string modelis, int metai, string os)
        {
            Gamintojas = gamintojas;
            Modelis = modelis;
            Metai = metai;
            OS = os;
        }

        public Telefonas(string eilute)
        {
           string[] isskaidyta = eilute.Split(';');
            Gamintojas = isskaidyta[0];
            Modelis = isskaidyta[1];
            Metai = Convert.ToInt32(isskaidyta[2]);
            OS = isskaidyta[3];
        }
    }
}
