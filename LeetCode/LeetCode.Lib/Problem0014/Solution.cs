using System.Text;

namespace LeetCode.Lib.Problem0014
{
    /// <summary>
    /// Level: Easy
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Write a function to find the longest common prefix string amongst an array of strings.
        /// If there is no common prefix, return an empty string ""
        /// </summary>
        /// <example>
        /// Example 1:
        /// Input: strs = ["flower", "flow", "flight"]
        /// Output: "fl"
        /// </example>
        /// <param name="strs"></param>
        /// <returns>Longest common prefex between strings in <paramref name="strs"/></returns>
        public string LongestCommonPrefix(string[] strs)
        {
            // Build the prefix string
            StringBuilder prefixBuilder = new StringBuilder();
            // We don't know the shortest string, so take the first string as the shortest
            // string to start with.  We can update it later
            int shortestStringLength = (strs.Length > 0) ? strs[0].Length : 0;

            // We want the outer loop to loop for each character in the shortest string.
            // We don't know what the shortest string is for sure, so we take the first
            // string as the shortest string to start with
            for (int i = 0; i < shortestStringLength; i++)
            {
                // will store the current character we're comparing in each
                // string.
                char currentChar = default;

                // Go through each string in strs
                for (int j = 0; j < strs.Length; j++)
                {
                    // Check if the outer loop i has gone past the length of this string (i.e. this
                    // string was shorter)
                    if (i < strs[j].Length)
                    {
                        // If we haven't gone past the string length

                        // This is the first element in strs, set currentChar
                        if (currentChar == default)
                        {
                            currentChar = strs[j][i];
                        }
                        // Otherwise this is the second or greater element in strs, check
                        // the character value is the same
                        else if (currentChar != strs[j][i])
                        {
                            // if it isn't, set current char back to default so the outer loop knows
                            // to break, and break out of the inner loop.
                            currentChar = default;
                            break;
                        }
                    }
                    else
                    {
                        // Otherwise if we have gone past the string length, break out
                        // since the prefix can't be any longer than it already is
                        currentChar = default;
                        break;
                    }
                }

                // If currentChar isn't default (i.e was the same character for the same position
                // for all strings)
                if (currentChar != default)
                {
                    // Then add it to our prefix builder
                    prefixBuilder.Append(currentChar);
                }
                else
                {
                    // Otherwise break out as the characters were different between strings
                    // or we reached the end of one of the strings
                    break;
                }
            }

            return prefixBuilder.ToString();
        }
    }
}
