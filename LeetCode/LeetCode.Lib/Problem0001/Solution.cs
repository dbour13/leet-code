namespace LeetCode.Lib.Problem0001
{
    /// <summary>
    /// Level: Easy
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Given an array of integers <paramref name="nums"> and an integer <paramref name="target">, return indices of the two numbers such that they add up to <paramref name="target">.
        /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// You can return the answer in any order.
        /// </summary>
        /// <param name="nums">Array of integers containing two numbers that add up to <paramref name="target"></param>
        /// <param name="target">The target number to add up to using two numbers from <paramref name="nums"></param>
        /// <returns>An array containing the two indicites of <paramref name="nums"></returns>
        /// <exception cref="NoSolutionException">No solution exception if no two numbers add up to <paramref name="target"></exception>
        public int[] TwoSum(int[] nums, int target)
        {
            // If there aren't at least two items in nums, there is no solution
            if (nums.Length > 1)
            {
                // For each element 'i' in nums
                for (int i = 0; i < nums.Length-1; i++)
                {
                    // For each element 'j' that comes after 'i' in nums, 
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        // Add 'i' and 'j' together and return true if they match the target number
                        if (nums[i] + nums[j] == target)
                        {
                            return [i, j];
                        }
                    }
                }
            }

            // Throw no solution error if a solution couldn't be found above
            throw new NoSolutionException();
        }
    }
}
