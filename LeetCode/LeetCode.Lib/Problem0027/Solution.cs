using LeetCode.Lib.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode.Lib.Problem0027
{
    /// <summary>
    /// Level: Easy
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Given an integer array <paramref name="nums"/> and an integer <paramref name="val"/>, remove all occurrences of 
        /// <paramref name="val"/> in <paramref name="nums"/> in-place. The order of the elements may be changed. Then return 
        /// the number of elements in <paramref name="nums"/> which are not equal to <paramref name="val"/>.
        /// 
        /// Consider the number of elements in <paramref name="nums"/> which are not equal to val be k, to get accepted, you 
        /// need to do the following things:
        /// 
        /// Change the array <paramref name="nums"/> such that the first k elements of <paramref name="nums"/> contain the 
        /// elements which are not equal to <paramref name="val"/>. 
        /// The remaining elements of <paramref name="nums"/> are not important as well as the size of <paramref name="nums"/>.
        /// 
        /// Return k.
        /// </summary>
        /// <param name="nums">Array of ints in any order</param>
        /// <returns>Number of elements remaining in <paramref name="nums"/> after removing elemnents equal to <paramref name="val"/></returns>
        public int RemoveElement(int[] nums, int val)
        {
            // The return value (the number of elements in the array after removing
            // elements equal to 'val'
            int k = 0;

            // Loop through each element in nums
            for (int i = 0; i < nums.Length; i++)
            {
                // If this element doesn't match val
                if (nums[i] != val)
                {
                    // Set the last element that was equal to val to this element's value.
                    // We could do a check for if k != i (i.e. no elements removed yet),
                    // but it's just setting the value to be the same anyway in that case.
                    nums[k] = nums[i];
                    // Increment the number of elements in the list that haven't been removed
                    k++;
                }
            }

            return k;
        }
    }
}
