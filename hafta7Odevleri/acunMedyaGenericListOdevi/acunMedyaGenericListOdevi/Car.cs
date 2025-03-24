using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace acunMedyaGenericListOdevi
{
    class Car
    {
        public string? Marka { get; set; }
        public string? Model { get; set; }
        public double? BenzinHarcamasi { get; set; }
        public double? ToplamMesafe { get; set; }

        public double YakitTuketimi(double BenzinHarcamasi,double ToplamMesafe)
        {
            return (ToplamMesafe / 100) * BenzinHarcamasi;
        }

       
    }
}
