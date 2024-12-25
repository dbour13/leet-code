using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode.Lib.Problem0070
{
    /// <summary>
    /// Level: Easy
    /// </summary>
    public class Solution
    {
        /// <summary>
        ///You are climbing a staircase. It takes <paramref name="n"/> steps to reach the top.
        // 
        // Each time you can either climb 1 or 2 steps.In how many distinct ways can you climb to the top?
        /// </summary>
        /// <param name="n">Number of stairs to climb</param>
        /// <returns>Number of distinct ways to climb n stairs</returns>
        public int ClimbStairs2(int n)
        {
            // This is the same as f(n) = f(n-1)+f(n-2), where f(n) = n when n <=2 

            // Actually doing that though is not a good solution as as O(n) goes up sharply
            // even for small values of n.
            return n <= 2 ? n : ClimbStairs(n - 1) + ClimbStairs(n - 2);
        }


        /// <summary>
        /// Solution using memoization
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int ClimbStairs(int n)
        {
            // This is the same as f(n) = f(n-1)+f(n-2), where f(n) = n when n <=2 

            // Return n for values of n <= 2
            if (n <= 2)
            {
                return n;
            }

            // Use memoization to work our way up to n, starting at n = 3
            int nCurrent = 3;
            int nMinusOne = 2;
            int temp = 0;

            for (int i = 3; i < n; i++)
            {
                // Hold the old nCurrent value
                temp = nCurrent;
                // Calculate the nCurrent value
                nCurrent = nCurrent + nMinusOne;
                // Set the new n-1 value
                nMinusOne = temp;
            }

            // Return the nCurrent value 
            return nCurrent;
        }

    }
}
