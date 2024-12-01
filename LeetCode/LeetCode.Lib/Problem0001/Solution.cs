using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;

namespace LeetCode.Lib.Problem0001
{
    public static class Solution
    {
        /// <summary>
        /// Given an array of integers <paramref name="nums"> and an integer <paramref name="target">, return indices of the two numbers such that they add up to <paramref name="target">.
        /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// You can return the answer in any order.
        /// </summary>
        /// <param name="nums">Array of integers containing two numbers that add up to <paramref name="target"></param>
        /// <param name="target">The target number to add up to using two numbers from <paramref name="nums"></param>
        /// <returns>An array containing the two indicites of <paramref name="nums"></returns>
        /// <exception cref="Exception">No solution exception if no two numbers add up to <paramref name="target"></exception>
        public static int[] TwoSum(int[] nums, int target)
        {
            if (nums.Length > 1)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            return [i, j];
                        }
                    }
                }
            }

            throw new NoSolutionException();
        }
    }
}
