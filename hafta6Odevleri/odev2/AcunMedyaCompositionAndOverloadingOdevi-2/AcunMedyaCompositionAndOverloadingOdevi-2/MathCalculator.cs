using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunMedyaCompositionAndOverloadingOdevi_2
{
    class MathCalculator
    {
        public int Sum(int a,int b)
        {
            return a + b;
        }

        public double Sum(double a, double b)
        {
            return a + b;
        }

        public int Sum(int a , int b , int c)
        {
            return a + b + c;
        }

        public int Carp(int a, int b)
        {
            return a * b;
        }

        public double Carp(double a, double b)
        {
            return a * b;
        }

        public int Carp(int a, int b, int c)
        {
            return a * b *c;
        }
    }
}
