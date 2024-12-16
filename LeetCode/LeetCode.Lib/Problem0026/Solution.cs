using LeetCode.Lib.Common;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode.Lib.Problem0026
{
    /// <summary>
    /// Level: Easy
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once. The relative order of the elements should be kept the same. Then return the number of unique elements in nums.
        /// 
        /// Consider the number of unique elements of nums to be k, to get accepted, you need to do the following things:
        /// 
        /// Change the array nums such that the first k elements of nums contain the unique elements in the order they were present in nums initially.The remaining elements of nums are not important as well as the size of nums.
        /// Return k.
        /// </summary>
        /// <param name="nums">Array of ints in ascending order</param>
        /// <returns>Number of unique ints in array <paramref name="nums"/></returns>
        public int RemoveDuplicates(int[] nums)
        {
            // Holds the index of one after the last unique number we read in the array
            int uniqueIndex = 1;
            // Holds the last unique number we read
            int last = nums[0];

            // Go through each element, skipping the first as it has to be unique
            for (int i = 1; i < nums.Length; i++)
            {
                // If the number is different from the last unique number
                if (nums[i] != last)
                {
                    // Set the number at index one after the last unique number we read to
                    // this number
                    nums[uniqueIndex] = nums[i];
                    // Increment the unique index 
                    uniqueIndex++;
                    // set the last unique number we've read to this number
                    last = nums[i];
                }
            }

            return uniqueIndex;
        }
    }
}
