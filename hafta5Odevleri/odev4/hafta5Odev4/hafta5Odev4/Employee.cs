using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta5Odev4
{
    class Employee
    {
        public Employee(int maas, string? ad, string? soyad, string? meslek, string? departman)
        {
            Maas = maas;
            Ad = ad;
            Soyad = soyad;
            Meslek = meslek;
            Departman = departman;
        }

        public int Maas { get; set; }
        public string? Ad { get; set; }
        public string? Soyad  { get; set; }
        public string? Meslek  { get; set; }
        public string? Departman  { get; set; }
    }
}
