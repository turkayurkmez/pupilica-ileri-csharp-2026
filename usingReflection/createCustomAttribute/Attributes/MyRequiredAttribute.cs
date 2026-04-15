using System;
using System.Collections.Generic;
using System.Text;

namespace createCustomAttribute.Attributes
{
    /// <summary>
    /// Amaç, bir özelliğin zorunlu olmasını sağlamak.
    /// </summary>

    [AttributeUsage(AttributeTargets.Property)]
    public class MyRequiredAttribute : Attribute
    {
        /// <summary>
        /// Hata mesajı
        /// </summary>
        public string Message { get; set; }
        public MyRequiredAttribute(string message = "Bu alan zorunludur")
        {
            Message = message;
        }
    }
}
