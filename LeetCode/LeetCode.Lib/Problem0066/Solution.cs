using System;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Security.Cryptography;

namespace LeetCode.Lib.Problem0066
{
    /// <summary>
    /// Level: Easy
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// You are given a large integer represented as an integer array <paramref name="digits"/>, where each <paramref name="digits[i]"/>
        /// is the ith digit of the integer. The digits are ordered from most significant to least significant in left-to-right order. 
        /// The large integer does not contain any leading 0's.
        /// 
        /// Increment the large integer by one and return the resulting array of digits.
        /// </summary>
        /// <param name="digits">string to find length of last word</param>
        /// <returns>Length of last word in <paramref name="s"/></returns>
        public int[] PlusOne(int[] digits)
        {
            // The result to return.  Make it one longer than digits as the carry over
            // may increase the digits by one.
            int[] result = new int[digits.Length + 1];
            // Whether to carry over into the next digit.  We want to increment by one
            // so set it to true.
            bool carryOver = true;

            // Loop backwards through the list of digits
            for (int i = digits.Length-1; i >= 0; i--)
            {
                // Set the result at this index (+1 as it's one longer than digits) to
                // the digit at this index + the carryOver if any
                result[i+1] = digits[i] + (carryOver ? 1 : 0);
                // Set carry over back to false since we've accounted for it
                carryOver = false;

                // If we went over 9 for this digit
                if (result[i+1] > 9)
                {
                    // Set it back to zero and set the carryOver flag to true
                    result[i+1] = 0;
                    carryOver = true;
                }
            }

            // If there was a carryOver after looping through above
            if (carryOver)
            {
                // Set the first digit to 1 and return the result
                result[0] = 1;
                return result;
            }

            // Otherwise return a slice of the result, skipping the first digit
            // as it's 0
            return result.AsSpan().Slice(1).ToArray();
        }
    }
}
