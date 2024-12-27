using LeetCode.Lib.Common;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Linq;
using System;

namespace LeetCode.Lib.Problem0088
{
    /// <summary>
    /// Level: Easy
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// You are given two integer arrays <paramref name="nums1"/> and <paramref name="nums2"/>, sorted in non-decreasing order, 
        /// and two integers <paramref name="m"/> and <paramref name="n"/>, representing the number of elements in 
        /// <paramref name="nums1"/> and <paramref name="nums2"/> respectively.
        /// 
        /// Merge <paramref name="nums1"/> and <paramref name="nums2"/> into a single array sorted in non-decreasing order.
        /// The final sorted array should not be returned by the function, but instead be stored inside the array <paramref name="nums1"/>. 
        /// To accommodate this, <paramref name="nums1"/> has a length of <paramref name="m"/> + <paramref name="n"/>, where the first 
        /// <paramref name="m"/> elements denote the elements that should be merged, and the last <paramref name="n"/> elements are set to 
        /// 0 and should be ignored. <paramref name="nums2"/> has a length of n.
        /// </summary>
        /// <param name="nums1">First array to merge</param>
        /// <param name="m">length of <paramref name="nums1"/></param>
        /// <param name="nums2">Second array to merge</param>
        /// <param name="n">length of <paramref name="nums2"/></param>
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            // Represents element in nums1 we're checking next
            int index1 = m - 1;
            // Represents element in nums2 we're checking next
            int index2 = n - 1;

            // Loop backwards through both lists
            for (int i = m+n-1; i >= 0; i--)
            {
                // If nums1[index1] is greater than nums2[index2], or if we've already processed all of
                // nums2 (i.e. index2 < 0), and we've not already processed all of nums1 (i.e. index1 > 0)
                if (index2 < 0 || (index1 >= 0 && nums1[index1] > nums2[index2]))
                {
                    // Set the next element going backwards through the list to nums1[index1] and decrement index1
                    nums1[i] = nums1[index1];
                    index1--;
                }
                else
                {
                    // Otherwise if nums2[index1] was less or equal to nums2[index2], or if nums1 was already processed
                    // (i.e. index1 < 0), then set the element going backwards through the list to nums2[index2] and decrement
                    // index2
                    nums1[i] = nums2[index2];
                    index2--;
                }
            }
        }
    }
}
