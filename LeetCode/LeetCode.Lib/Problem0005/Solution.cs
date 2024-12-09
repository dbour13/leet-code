using System.Data.SqlTypes;

namespace LeetCode.Lib.Problem0005
{
    /// <summary>
    /// Level: Medium
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Given a string <paramref name="s"/>, return the longest palindromic substring in <paramref name="s"/>.
        /// </summary>
        /// <param name="s">String to search longest palindormic substring</param>
        /// <returns>longest palindromic substring</returns>
        public string LongestPalindrome(string s)
        {
            // If the string is only one character, return the string as is
            // as it's a single character palindrome
            if (s.Length <= 1)
            {
                return s;
            }

            // Keep track of the starting Index and length of hte longest
            // palindrome we've found so far
            int longestStartIndex = 0;
            int longestLength = 1;

            // Check each character in s to see if it's a palindrome
            for (int i = 1; i < s.Length; i++)
            {
                // CHeck both odd and even mirroed characters (e.g. aba vs aa)
                // k = 1 cehcks even, k = 2 checks odd
                for (int k = 1; k <= 2; k++)
                {
                    int cnt = k;
                    // Check left and right side from position i at the same time.
                    // 'j' represents the left index
                    // 'j+cnt' represents the right index.
                    // Goes until the left (j) or right (j+cnt) are below 0 or greater or equal to the string length,
                    // or breaks if it's determined not to be a palindrome anymore
                    for (int j = i - 1; (j >= 0) && (j + cnt < s.Length); j--)
                    {
                        // If the left side is the same as the rigtht
                        if (s[j] == s[j + cnt])
                        {
                            // If this palindrome is the longest we've seen so far
                            if ((cnt + 1) > longestLength)
                            {
                                // Update the start index/length of hte longest palindrome we've found
                                longestStartIndex = j;
                                longestLength = cnt + 1;
                            }
                        }
                        else
                        {
                            // Break out if it's no longer a palindrome
                            break;
                        }

                        // Update the right counter by 2
                        cnt += 2;
                    }
                }
            }

            return s.Substring(longestStartIndex, longestLength);
        }
    }
}
