using System.ComponentModel;
using System.Security.Cryptography;

namespace LeetCode.Lib.Problem0035
{
    /// <summary>
    /// Level: Easy
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Given a sorted array of distinct integers and a <paramref name="target"/> value, return the index if the <paramref name="target"/> is found. 
        /// If not, return the index where it would be if it were inserted in order.
        /// 
        /// You must write an algorithm with O(log n) runtime complexity.
        /// </summary>
        /// <param name="nums">distinct array of integers in ascending order</param>
        /// <param name="target">number to match on <paramref name="nums"/> and find the index</param>
        /// <returns>Index of <paramref name="target"/> in <paramref name="nums"/>, or the index it would have been if it were in the array</returns>
        public int SearchInsert2(int[] nums, int target)
        {
            // Trying a Loop solution instead of recursive

            // Holds the left most index we're looking at
            int leftIndex = 0;
            // Holds the right most index we're looking at
            int rightIndex = nums.Length - 1;
            // Holds the current index we're looking at.  Doing a binary
            // search, so look half way between left and right index
            int index = rightIndex / 2;

            // Loop until left index is equal to right index (we didn't find
            // a match with the target)
            while (leftIndex != rightIndex)
            {
                // Break out if we do find a match with the target
                if (nums[index] == target)
                {
                    break;
                }
                // Update leftIndex band up to one more than the current index if
                // current index value is less than the target
                else if (nums[index] < target)
                {
                    leftIndex = index+1;
                }
                // Otherwise update the right index band down to the current index if
                // the current index value is more than the target
                else if (nums[index] > target)
                {
                    rightIndex = index;
                }

                // Set the index to half way between leftIndex and rightIndex
                index = leftIndex + (rightIndex - leftIndex) / 2;
            }

            // Return the index, but add 1 if it's at the end of the array
            // and still lower than the target.
            return nums[index] < target ? index+1 : index;
        }

        /// <summary>
        /// Recusive solution
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int SearchInsert(int[] nums, int target)
        {
            return SearchIndexHelper(nums, target);
        }

        private int SearchIndexHelper(Span<int> nums, int target, int offset = 0)
        {
            // Need this to account for target being below/above the ends of the
            // array
            if (nums.Length == 0)
            {
                return offset;
            }
            if (nums.Length == 1)
            {
                return nums[0] < target ? offset + 1 : offset;
            }

            // Check index at middle of nums
            int index = nums.Length / 2;
            // Return offset + index if index value matches target
            // Otherwise recusively call SearchIndexHelper between
            // new ranges depending on whether index value is lesser/greater
            // than target value (and add to offset if lesser)
            return nums[index] == target ? offset + index
                                         : nums[index] < target ? SearchIndexHelper(nums.Slice(index + 1), target, offset + index + 1)
                                                                : SearchIndexHelper(nums.Slice(0, index), target, offset);
        }
    }
}
