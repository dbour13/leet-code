using System.ComponentModel;
using System.Data.SqlTypes;
using System.Security.Cryptography;

namespace LeetCode.Lib.Problem0058
{
    /// <summary>
    /// Level: Easy
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Given a string <paramref name="s"/> consisting of words and spaces, return the length of the last word in the string.
        /// 
        /// A word is a maximal substring consisting of non-space characters only.
        /// </summary>
        /// <param name="s">string to find length of last word</param>
        /// <returns>Length of last word in <paramref name="s"/></returns>
        public int LengthOfLastWord(string s)
        {
            // Stores the result
            int result = 0;
            // Whether or not we've hit a character other than a space yet
            bool hitNonSpaceCharacter = false;

            // Loop backwards through s
            for (int i = s.Length-1; i >= 0; i--)
            {
                // If it isn't a space
                if (s[i] != ' ')
                {
                    // Set the hitCharacter flag and increment
                    // the result
                    hitNonSpaceCharacter = true;
                    result++;
                }
                else if (hitNonSpaceCharacter) 
                {
                    // Otherwise break out if it was a space and
                    // we've already hit a non-space character before
                    break;
                }
            }

            return result;
        }
    }
}
