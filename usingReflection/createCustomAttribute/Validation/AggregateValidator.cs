using System;
using System.Collections.Generic;
using System.Text;

namespace createCustomAttribute.Validation
{
    public static class AggregateValidator
    {
        public static Dictionary<string,ValidationResult> ValidateAll(params ReadOnlySpan<object> objects)
        {
            var results = new Dictionary<string,ValidationResult>();
            int x = 0;
            foreach (var obj in objects)
            {
               
                var type = obj.GetType();
                //reflection ile, Validate<> metodunu run-time'da çağır:
                var methodInfo = typeof(Validator).GetMethod(nameof(Validator.Validate))!
                                                  .MakeGenericMethod(type);

                var result = (ValidationResult)methodInfo.Invoke(null, [obj]);
                results.Add(type.Name + $"{x++}", result);
                


            }

            return results;
        }
    }
}
