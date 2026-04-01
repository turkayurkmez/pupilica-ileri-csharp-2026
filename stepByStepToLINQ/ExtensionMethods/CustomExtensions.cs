using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods
{
    public static class CustomExtensions
    {
        public static int GetSquare(this int value)
        {
            return (int)Math.Pow(value, 2);
        }

        public static bool IsEmail(this string value)
        {
            if (!value.Contains("@"))
            {
                return false;
            }

            int wordPartsLength = value.Split('@').Length;
            if (wordPartsLength != 2)
            {
                return false;
            }

            if (!value.Split('@')[1].Contains("."))
            {
                return false;
            }

            return true;

        }

        public static char NextChar(this Random random, bool isLower = true)
        {
            
            int asciiValue = isLower ? random.Next(97,123) : random.Next(65,91);

            char value = (char)asciiValue;

            return value;

        }
    }
}
