using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta5Odev5
{
    class Araba
    {
        public Araba(string? marka, int benzin)
        {
            Marka = marka;
            Benzin = benzin;
        }

        public string? Marka { get; set; }
        public int Benzin { get; set; }
    }
}
