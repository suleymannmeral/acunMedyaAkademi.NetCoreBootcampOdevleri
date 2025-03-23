using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acunMedyaAkademiErisimBelirliyiciler
{
    class User
    {
        private string? adSoyad;
        private int yas;
        public string GetAdSoyad()
        {
            return adSoyad;
        }

        public void SetAdSoyad(string value)
        {
            adSoyad = value;
        }

        public int GetYas()
        {
            return yas;
        }

        public void SetYas(int value)
        {
            if (value >= 0) 
            {
                yas = value;
            }
            else
            {
                Console.WriteLine("Yaş negatif olamaz!");
            }
        }
        public string? Mail { get; set; }
        public void BilgileriGoster()
        {
            Console.WriteLine($"Ad Soyad: {adSoyad}");
            Console.WriteLine($"Yaş: {yas}");
            Console.WriteLine($"E-posta: {Mail}");
        }
    }
}
