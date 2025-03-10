using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta5Odev1
{
    class AgeControl
    {
        public string CheckAge(int age)
        {
            if (age > 0 && age < 18)
                return "Küçüksünüz";

            else if (age >= 18 && age < 35)
                return "Gençsiniz";

            else if (age >= 35 && age < 55)

                return "Yetişkinsiniz";
            else if (age >= 55 && age < 75)
                return "Yaşlısınız";

            else if (age >= 75 && age < 99)
                return "Çok Yaşlısınız";

            else if (age < 0 || age > 99)
                return "Ya hiç doğmadınız ya da çoktan öldünüz";

            else
                return null;


        }
    }
}
