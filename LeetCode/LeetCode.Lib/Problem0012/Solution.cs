using System.Text.RegularExpressions;
using System;
using static System.Formats.Asn1.AsnWriter;
using System.ComponentModel;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace LeetCode.Lib.Problem0012
{
    /// <summary>
    /// Level: Medium
    /// </summary>
    public class Solution
    {
        // All possible values for 1-9, 10-100, 100-1000, 1000-3000
        private static string[][] romanNumerals = [["I","II","III","IV","V","VI","VII","VIII","IX"],
                                                   ["X","XX","XXX","XL","L","LX","LXX","LXXX","XC"],
                                                   ["C","CC","CCC","CD","D","DC","DCC","DCCC","CM"],
                                                   ["M","MM","MMM"]];

        /// <summary>
        /// Seven different symbols represent Roman numerals with the following values:
        ///
        /// Symbol Value
        /// I	1
        /// V	5
        /// X	10
        /// L	50
        /// C	100
        /// D	500
        /// M	1000
        /// Roman numerals are formed by appending the conversions of decimal place values from highest to lowest.Converting a decimal place value into a Roman numeral has the following rules:
        /// 
        /// If the value does not start with 4 or 9, select the symbol of the maximal value that can be subtracted from the input, append that symbol to the result, subtract its value, and convert the remainder to a Roman numeral.
        /// If the value starts with 4 or 9 use the subtractive form representing one symbol subtracted from the following symbol, for example, 4 is 1 (I) less than 5 (V): IV and 9 is 1 (I) less than 10 (X): IX.Only the following subtractive forms are used: 4 (IV), 9 (IX), 40 (XL), 90 (XC), 400 (CD) and 900 (CM).
        /// Only powers of 10 (I, X, C, M) can be appended consecutively at most 3 times to represent multiples of 10. You cannot append 5 (V), 50 (L), or 500 (D) multiple times.If you need to append a symbol 4 times use the subtractive form.
        /// Given an integer, convert it to a Roman numeral.
        /// </summary>
        /// <param name="height">list of line heights</param>
        /// <returns>Max area of containers that can be made from <paramref name="height"/></returns>
        public string IntToRoman(int num)
        {
            // Build the string since we don't know how long it will be
            StringBuilder sb = new StringBuilder();
            // Keeps track of the current digits left to process
            int current = num;
            // Keeps track of the right most digits
            int remainder = 0;

            // Keeps track of the first index in romanNumerals we're
            // using
            int index = 0;
            while (current > 0)
            {
                // Divide current by 10, and keep the remainder (the right most digit)
                current = Math.DivRem(current, 10, out remainder);
                // Get the roman numeral for this digit position and value
                if (remainder > 0)
                {
                    sb.Insert(0, romanNumerals[index][remainder - 1]);
                }
                // Increase the digit position index
                index++;
            }

            return sb.ToString();
        }
    }
}
