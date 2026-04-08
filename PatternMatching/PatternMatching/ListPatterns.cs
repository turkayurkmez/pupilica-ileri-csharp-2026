using System;
using System.Collections.Generic;
using System.Text;

namespace PatternMatching
{
    public static class ListPatterns
    {

        public static string analyseIntArrayModernWay(int[] numbers) =>
            numbers switch
            {
                [] => "Boş Array",
                [8] => "Tek elemanlı ve o da 8 değeri",
                [1,2,..]=> "Array 1 ve 2 ile başlıyor....",
                [..,999]=>"999 ile bitiyor!",
                [1,..,9]=>"1 ile başlayıp 9 ile bitiyor",
                [var first,.., var last] => $"bu array, {first} ile başlıyor, {last} ile bitiyor",
                //[1,..var middle,9] => ""
            };
    }
}
