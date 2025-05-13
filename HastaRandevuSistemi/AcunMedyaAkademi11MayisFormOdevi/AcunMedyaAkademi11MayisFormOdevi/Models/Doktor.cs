using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunMedyaAkademi11MayisFormOdevi.Models
{
    public class Doktor
    {
        public int ID { get; set; }
      
        public string? Name  { get; set; }
     
        public string? Surname  { get; set; }
        public int BransID  { get; set; }
     
        public string FullName => $"{Name} {Surname}";

    }
}
