using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunMedyaAkademi11MayisFormOdevi.Models
{
    public class Randevu
    {
        public int ID { get; set; }
        [Required]
        public string? HastaAdi { get; set; }
        [Required]
        public string? HastaSoyadi { get; set; }
        [Required]
        [Range(1, 200, ErrorMessage = "Branş  Seçiniz")]

        public int BransID { get; set; }
      
        [Range(1,200,ErrorMessage ="Doktor  Seçiniz")]
        public int DoktorID { get; set; }
        [Required]
        public DateTime Tarih { get; set; }
    }
}
