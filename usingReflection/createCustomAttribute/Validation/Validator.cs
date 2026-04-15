using createCustomAttribute.Attributes;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace createCustomAttribute.Validation
{
    public static class Validator
    {
        /// <summary>
        /// Belirtilen T nesnesinin özelliklerini attribute'lere göre denetler.
        /// </summary>
        /// <typeparam name="T">Denetlenecek nesnenin tipi</typeparam>
        /// <param name="obj">instance</param>
        /// <returns></returns>
        public static ValidationResult Validate<T> (T obj) where T : class
        {
            var result = new ValidationResult ();
            var type = typeof (T);
            foreach (var property in type.GetProperties())
            {
                var value = property.GetValue(obj);

                //1. [MyRequired] var mı?
                if (property.GetCustomAttribute<MyRequiredAttribute>() is { } required)
                {
                    //varsa ve değer boşsa ya da "" ise:
                    if (value is null || (value is string s && string.IsNullOrWhiteSpace(s)))
                    {
                        result.Errors.Add($"{property.Name}: {required.Message}");
                        continue;
                    }

                }

                //2. [MyMinLength] var mı?
                if (property.GetCustomAttribute<MyMinLengthAttribute>() is { } minLength)
                {

                    if (value is string str && str.Length < minLength.Min)
                    {
                        result.Errors.Add($"{property.Name}: {minLength.Message}");
                    }

                }

                if (property.GetCustomAttribute<MyRangeAttribute>() is { } myRange)
                {
                    var number = Convert.ToDouble(value);
                    if (number < myRange.Min || number>myRange.Max)
                    {
                        result.Errors.Add($"{property.Name}: {myRange.Message}");
                    }
                }
            }

            return result;
        }
    }
}
