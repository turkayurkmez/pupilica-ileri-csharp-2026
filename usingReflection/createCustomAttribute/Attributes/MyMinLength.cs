using System;
using System.Collections.Generic;
using System.Text;

namespace createCustomAttribute.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class MyMinLengthAttribute : Attribute
    {

        public int Min { get; set; }
        public string Message { get; set; }

        public MyMinLengthAttribute(int min, string message ="")
        {
            Min = min;
            Message = string.IsNullOrEmpty(message) ? $"Bu alan en az {min} karakter olmalı" : message;
        }

    }
}
