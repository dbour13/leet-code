using System.Data.SqlTypes;

namespace LeetCode.Lib.Problem0003
{
    /// <summary>
    /// Level: Medium
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Given a string <paramref name="s"/>, find the length of the longest substring without repeating characters.
        /// </summary>
        /// <param name="s">String to search longest substring</param>
        /// <returns>length of the longest substring without repeating characters</returns>
        public int LengthOfLongestSubstring2(string s)
        {
            // Loops below only work if there is at least 2 characters, so just return
            // s.Length if less or equal to 1 character.
            if (s.Length <= 1)
            {
                return s.Length;
            }

            // Holds the length of the longest substring
            int longestSubstring = 0;

            // For each character in s
            int i = 0, j = 0, k = 0;
            bool breakOut = false;
            for (i = 0; i < s.Length;i++)
            {
                // For each remaining character after i in s
                for (j = i+1; j < s.Length;j++)
                {
                    // For each character between i (inclusive) and j
                    for (k = i; k < j; k++)
                    {
                        // If any of the characters were the same
                        if (s[j] == s[k])
                        {
                            // Update the longest Substring
                            if (j-i > longestSubstring)
                            {
                                longestSubstring = j - i;
                            }

                            // Set i to be the character that matched so we
                            // can start looking for a new longest substring
                            i = k;
                            
                            // Breakout back to the top for loop
                            breakOut = true;
                            break;
                        }
                    }

                    if (breakOut)
                    {
                        break;
                    }
                }

                // If second loop (j) finishes without breakout out we've
                // reached the end of the string, so break out of the
                // outter most loop (i)
                if (!breakOut)
                {
                    break;
                }

                breakOut = false;
            }

            return (j-i > longestSubstring) ? j-i : longestSubstring;
        }

        /// <summary>
        /// Looked into how to solve in O(x)
        /// </summary>
        /// <param name="s">String to search longest substring</param>
        /// <returns>length of the longest substring without repeating characters</returns>
        public int LengthOfLongestSubstring(string s)
        {
            int returnValue = 0;
            // Holds the right most position a character has appeared
            // as we go through the string
            int[] ascii = new int[128];

            int j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                // Get the right most value this character has appeared,
                // otherwise don't change the index
                j = Math.Max(ascii[s[i]], j);
                // Update max length
                returnValue = Math.Max(i-j+1, returnValue);
                ascii[s[i]] = i+1;
            }

            return returnValue;
        }
    }
}
