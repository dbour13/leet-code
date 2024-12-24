using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode.Lib.Problem0069
{
    /// <summary>
    /// Level: Easy
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Given a non-negative integer <paramref name="x"/>, return the square root of <paramref name="x"/> rounded down to the nearest integer. 
        /// The returned integer should be non-negative as well.
        /// 
        /// You must not use any built-in exponent function or operator.
        /// 
        /// For example, do not use pow(x, 0.5) in c++ or x ** 0.5 in python.
        /// </summary>
        /// <param name="x">Integer to find the square root of</param>
        /// <returns>The square root of <paramref name="x"/>, rounded down</returns>
        public int MySqrt(int x)
        {
            if (x <= 1)
            {
                return x;
            }

            // Square all numbers from 1 up to x until it creates a number
            // greater than x
            for (uint i = 1; i <= x; i++)
            {
                if (i*i > x)
                {
                    // Return i-1 (round down)
                    return (int)i - 1;
                }
            }

            // It should never reach here
            throw new Exception();
        }
    }
}
