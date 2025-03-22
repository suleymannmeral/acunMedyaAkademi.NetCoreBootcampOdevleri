using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunMedyaCompositionAndOverloadingOdevi_1
{
    class Araba
    {
        public Araba(Marka? marka, Kapi? kapiSayisi, Kasa? kasaType, Pencere? pencereSayisi, string? model, decimal fiyat)
        {
            Marka = marka;
            KapiSayisi = kapiSayisi;
            KasaType = kasaType;
            PencereSayisi = pencereSayisi;
            Model = model;
            Fiyat = fiyat;
        }

        public Marka? Marka { get; set; }
        public Kapi? KapiSayisi { get; set; }
        public Kasa? KasaType { get; set; }
        public Pencere? PencereSayisi { get; set; }
        public string? Model { get; set; }
        public decimal Fiyat { get; set; }
        public void BilgileriYazdır()
        {
            Console.WriteLine($"Arabanın markası {Marka?.Ad}, modeli {Model}, kapı sayısı {KapiSayisi?.KapiSayisi}, pencere sayısı {PencereSayisi?.PencereSayisi}, kasası {KasaType?.Type}, fiyatı {Fiyat} TL’dir.");
        }
    }
}
