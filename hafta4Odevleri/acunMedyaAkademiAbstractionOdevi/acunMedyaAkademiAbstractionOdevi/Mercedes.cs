using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acunMedyaAkademiAbstractionOdevi
{
    public class Mercedes : ICarAbility
    {
        public void Fly(string name)
        {
            Console.WriteLine($"{name} flies in the air");
        }

        public void Go(string name)
        {
            throw new NotImplementedException();
        }

        public void Swim(string name)
        {
            Console.WriteLine($"{name} floats in the sea");
        }
    }
}
