using LeetCode.Lib.Common;

namespace LeetCode.Lib.Problem0108
{
    /// <summary>
    /// Level: Easy
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Given an integer array <paramref name="nums"></paramref> where the elements are sorted in ascending order, 
        /// convert it to a height-balanced binary search tree.
        /// </summary>
        /// <param name="root">array to convert to height balanced binary tree</param>
        /// <returns>Binary tree</returns>
        public TreeNode SortedArrayToBST(Span<int> nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return null;
            }

            return new TreeNode()
            {
                val = nums[nums.Length / 2],
                left = SortedArrayToBST(nums.Slice(0, nums.Length / 2)),
                right = SortedArrayToBST(nums.Slice((nums.Length / 2)+1))
            };
        }
    }
}
