using System;
using System.Collections.Generic;
using System.Text;

namespace CustomAttributeOdevi
{
    public class ValidationControl
    {
        public static string Validate(object obj)
        {
            StringBuilder errorMessages = new StringBuilder();
            Type type = obj.GetType();

            foreach (var property in type.GetProperties())
            {
                var attribute = (RequiredFieldAttribute)Attribute.GetCustomAttribute(property, typeof(RequiredFieldAttribute));
                if (attribute != null)
                {
                    var value = property.GetValue(obj);
                    if (value == null || (value is string str && string.IsNullOrWhiteSpace(str)))
                    {
                        string errorMessage = attribute.ErrorMessage ?? $"{property.Name} alanı boş bırakılamaz.";
                        errorMessages.AppendLine(errorMessage);
                    }
                }
            }

            return errorMessages.ToString();
        }
    }
}
