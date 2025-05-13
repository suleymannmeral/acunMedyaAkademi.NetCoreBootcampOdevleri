using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunMedyaAkademi11MayisFormOdevi.Validation
{
    public class ValidateAppointment
    {
       
            public bool Validate<T>(T model)
            {
                var context = new ValidationContext(model, serviceProvider: null, items: null);
                var results = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(model, context, results, true);

                if (!isValid)
                {
                    foreach (var error in results)
                    {
                      MessageBox.Show("Validation Error: " + error.ErrorMessage);
                    }
                }

                return isValid;
            }
        
    }
}
