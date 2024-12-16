using System.Text;

namespace LeetCode.Lib.Problem0015
{
    /// <summary>
    /// Level: Medium
    /// 
    /// TODO: NOT FINISHED
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.
        /// 
        /// Notice that the solution set must not contain duplicate triplets.
        /// </summary>
        /// <param name="nums">List of numbers</param>
        /// <returns>A list of triplet numbers that add together to equal 0 from nums</returns>
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            List<IList<int>> results = new List<IList<int>>();

            for (int i = 0; i < nums.Length - 2; i++)
            {
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        if (nums[i] + nums[j] + nums[k] == 0)
                        {
                            

                            results.Add(new List<int>() { nums[i], nums[j], nums[k] });
                        }
                    }
                }
            }

            return results;
        }
    }
}
