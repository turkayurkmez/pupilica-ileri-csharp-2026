using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public static class FilterProcess
    {
        //bu bir ilan:
        //public delegate bool Criteria(int number);
       public static  int[] FilteredNumbers(int[] orijinal, Func<int,bool> criteria)
        {
            List<int> filteredArray = new List<int>();

            foreach (var n in orijinal)
            {
                if (criteria(n))
                {
                    filteredArray.Add(n);
                }
            }

            return filteredArray.ToArray();
        }
    }
}
