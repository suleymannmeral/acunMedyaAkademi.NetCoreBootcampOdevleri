using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributeOdevi
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true, Inherited = true)]

    public class RequiredFieldAttribute:Attribute
    {
        public string ErrorMessage { get; set; }

        public RequiredFieldAttribute(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }
    }
}
