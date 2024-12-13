using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode.Lib.Problem0008
{
    /// <summary>
    /// Level: Medium
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Implement the myAtoi(string <paramref name="s"/>) function, which converts a string to a 32-bit signed integer.
        ///
        /// The algorithm for myAtoi(string <paramref name="s"/>) is as follows:
        /// 
        /// Whitespace: Ignore any leading whitespace(" ").
        /// Signedness: Determine the sign by checking if the next character is '-' or '+', assuming positivity if neither present.
        /// Conversion: Read the integer by skipping leading zeros until a non-digit character is encountered or the end of the string is reached.If no digits were read, then the result is 0.
        /// Rounding: If the integer is out of the 32-bit signed integer range [-231, 231 - 1], then round the integer to remain in the range. Specifically, integers less than -231 should be rounded to -231, and integers greater than 231 - 1 should be rounded to 231 - 1.
        /// Return the integer as the final result.
        /// </summary>
        /// <param name="s">String to convert to int</param>
        /// <returns><paramref name="s"/> converted to string</returns>
        public int MyAtoi(string s)
        {
            // Holds the return value
            int returnValue = 0;
            // True if we've hit a number or +,- symbol (i.e. we're starting to convert the number,
            // and aren't allowed any more spaces, '+'s or '-'s.
            bool hitNumber = false;
            // Whether the number is negative or not
            bool isNegative = false;

            // Loop through each character 'c' in 's'
            foreach (char c in s)
            {
                // If it's a number (between 0 and 9)
                if (c >= '0' && c <= '9')
                {
                    // Set hitNumber = true if not already
                    hitNumber = true;

                    try
                    {
                        // Move returnValue digits once to the left, and add the
                        // current character as a number.
                        returnValue = checked(returnValue * 10);
                        if (isNegative)
                        {
                            returnValue = checked(returnValue - (c - '0'));
                        }
                        else
                        {
                            returnValue = checked(returnValue + (c - '0'));
                        }
                    }
                    catch (OverflowException)
                    {
                        // Overflow, if it's a negative number return minimum possible int value,
                        // otherwise return maximum possible int value
                        returnValue = isNegative ? int.MinValue : int.MaxValue;
                    }
                }
                else if (c == '+')
                {
                    // If we've already started converting numbers, break
                    // as this is an unexpected character
                    if (hitNumber)
                    {
                        break;
                    }
                    // Otherwise set hitNumber to true and continue to the next
                    // character
                    hitNumber = true;
                    continue;
                }
                else if (c == '-')
                {
                    // If we've already started converting numbers, break
                    // as this is an unexpected character
                    if (hitNumber)
                    {
                        break;
                    }
                    isNegative = true;
                    hitNumber = true;
                    continue;
                }
                else if (c == ' ')
                {
                    // If we've already started converting numbers, break
                    // as this is an unexpected character
                    if (hitNumber)
                    {
                        break;
                    }
                    // Otherwise continue to the next character (ignore leading spaces)
                    continue;
                }
                else
                {
                    // Unexpected Character
                    break;
                }
            }

            return returnValue;
        }
    }
}
