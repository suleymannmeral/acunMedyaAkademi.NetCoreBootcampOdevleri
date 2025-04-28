using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributeOdevi
{
    public class Ogrenci
    {
        [RequiredField("İsim boş olamaz.")]
        public string? Name { get; set; }


        [RequiredField("Soyisim boş olamaz.")]
        public string? Surname { get; set; }


        [RequiredField("Bölüm boş olamaz.")]
        public string? Department { get; set; }

    }
}

