﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunmedyaAkademiHafta4Odev3
{
    public class Porsche : Car, IFuelCalculate
    {
        public int CalculateFuelConsumption()
        {
            return 60;
        }

        public override void Go()
        {
            throw new NotImplementedException();
        }

        public override void StartEngine()
        {
            throw new NotImplementedException();
        }

        public override void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
