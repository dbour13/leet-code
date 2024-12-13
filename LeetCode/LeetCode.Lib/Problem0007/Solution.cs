using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Text;

namespace LeetCode.Lib.Problem0007
{
    /// <summary>
    /// Level: Medium
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Given a signed 32-bit integer <paramref name="x"/>, return x with its digits reversed. If reversing <paramref name="x"/> 
        /// causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.
        ///
        ///Assume the environment does not allow you to store 64-bit integers(signed or unsigned).
        /// </summary>
        /// <param name="x">Interger to reverse</param>
        /// <returns><paramref name="x"/> reversed</returns>
        public int Reverse(int x)
        {
            // Holds the return value
            int returnValue = 0;
            // Holds the current value as we extrat the digits
            int currentValue = x;
            // Holds the remainder after dividing by 10
            int remainder = 0;

            while (currentValue != 0)
            {
                // If it goes over Int.MaxValue, return 0
                try
                {
                    // Shift returnValue to the left one digit by multiplying by 10
                    returnValue = checked(returnValue * 10);

                    // Processer may be able to do division and get  remainder in one operation
                    currentValue = Math.DivRem(currentValue, 10, out remainder);
                    returnValue = checked(returnValue + remainder);
                }
                catch (OverflowException)
                {
                    returnValue = 0;
                    break;
                }
            }

            return returnValue;
        }
    }
}
