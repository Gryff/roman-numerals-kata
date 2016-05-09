using System.Collections.Generic;
using System.Linq;

namespace RomanNumeralsKata
{
    public class RomanNumeralsGenerator
    {
        private static readonly Dictionary<int, string> NumeralLookup = new Dictionary<int, string>
        {
            [1000] = "M",
            [900] = "CM",
            [500] = "D",
            [400] = "CD",
            [100] = "C",
            [90] = "XC",
            [50] = "L",
            [40] = "XL",
            [10] = "X",
            [9] = "IX",
            [5] = "V",
            [4] = "IV",
            [1] = "I",
        };

        public static string ToNumeral(int integer)
        {
            var numeral = "";

            foreach(var romanValue in GetRomanValues())
            {
                while (integer >= romanValue)
                {
                    numeral += NumeralLookup[romanValue];
                    integer -= romanValue;
                }
            }
            
            return numeral;
        }

        private static int[] GetRomanValues()
        {
            return NumeralLookup.Keys.ToArray();
        }
    }
}