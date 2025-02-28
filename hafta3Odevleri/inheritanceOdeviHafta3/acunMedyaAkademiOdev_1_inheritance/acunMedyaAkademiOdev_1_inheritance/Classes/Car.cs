using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acunMedyaAkademiOdev_1_inheritance.Classes
{
    public class Car
    {
        public string? Brand;  // Brand isimli araç markasını tutacak olan bir string değişken tanımladık. Buradaki ? Brand değişkeninin nullable olacağını gösterir
        public string? Transmission; //Transmission  isimli araç vites türünü tutacak olan bir string değişken tanımladık. Buradaki ? Transmission değişkeninin nullable olacağını gösterir


        public void Print(string Brand, string Transmission)  // string türünde 2 parametre alan ve geri dönüş değeri olmayan(void) türünde bir fonksiyon yazdık.
                                                              // Bu fonksiyon car classından miras alan tüm classlarda kullanılabilir.
        {
            Console.WriteLine($"{Brand} has {Transmission} transmission");
        }
    }
}
