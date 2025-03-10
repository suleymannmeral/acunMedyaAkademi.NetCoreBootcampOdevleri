using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta5Odev2
{
    class Car
    {
        public string CarAgeControl(int age)
        {
            if (age > 0 && age < 10)
                return "Arabanız Yeni";
            else if (age >= 10 && age < 20)
                return "Servise Götürmeniz Gerekebilir";
            else if (age >= 20 && age < 30)
                return "Arabanız Hurdaya Çıkabilir";
            else if (age < 0 || age > 30)
                return "Ya hiç üretilmedi ya da trafikten men edilmiştir";

            else
                return null;
        }
    }
}
