using System.Text.RegularExpressions;
using System;
using static System.Formats.Asn1.AsnWriter;
using System.ComponentModel;
using System.Numerics;

namespace LeetCode.Lib.Problem0011
{
    /// <summary>
    /// Level: Medium
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// You are given an integer array <paramref name="height"/> of length n. There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, <paramref name="height[i]"/>).
        ///
        /// Find two lines that together with the x-axis form a container, such that the container contains the most water.
        /// Return the maximum amount of water a container can store.
        ///
        /// Notice that you may not slant the container.
        /// </summary>
        /// <param name="height">list of line heights</param>
        /// <returns>Max area of containers that can be made from <paramref name="height"/></returns>
        public int MaxArea2(int[] height)
        {
            // Keep track of the largest area
            int largestArea = 0;

            // Loop through each item in height
            for (int i = 0; i < height.Length; i++)
            {
                // Loop through the rest of the items in height
                // from position i (i.e. don't duplicate calculations such as area of height[10],height[0]
                // when we've already calculated height[0],height[10])
                for (int j = i+1; j< height.Length; j++)
                {
                    // Area will be the distance between the indexes (j-i) multiplied by the smallest
                    // height
                    largestArea = Math.Max(largestArea, Math.Min(height[i], height[j])*(j-i));
                }
            }

            // Return the largest area
            return largestArea;
        }

        /// <summary>
        /// This can be done in O(x) time, instead of O(x(x+1)/2) time
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public int MaxArea(int[] height)
        {
            // The left index of height
            int i = 0;
            // The right index of height
            int j = height.Length - 1;
            // Keep track of the largest area
            int largestArea = 0;

            // Loop until the left and right indexes meet
            while (i != j)
            {
                // Area will be the distance between the indexes (j-i) multiplied by the smallest
                // height
                largestArea = Math.Max(largestArea, Math.Min(height[i], height[j]) * (j - i));

                // If left height is lower than right height
                if (height[i] < height[j])
                {
                    // Increase the left index
                    i++;
                }
                else
                {
                    // otherwise, decrease the right index
                    j--;
                }
            }

            // Return the largest area
            return largestArea;
        }
    }
}
