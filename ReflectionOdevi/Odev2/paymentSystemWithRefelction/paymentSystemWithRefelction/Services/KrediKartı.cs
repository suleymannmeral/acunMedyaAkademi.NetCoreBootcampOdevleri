using paymentSystemWithRefelction.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paymentSystemWithRefelction.Services
{
    public class KrediKartı : IOdemeYontemi
    {
        public string Ode(decimal tutar)
        {
            return "Kredi kartı ile ödeme işlemi başarılı bir şekilde gerçekleştirildi. Tutar: "+tutar;

        }
    }
}
