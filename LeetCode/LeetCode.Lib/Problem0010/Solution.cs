using System.Text.RegularExpressions;
using System;

namespace LeetCode.Lib.Problem0010
{
    /// <summary>
    /// Level: Hard
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Given an input string s and a pattern p, implement regular expression matching with support for '.' and '*' where:
        /// '.' Matches any single character.​​​​
        /// '*' Matches zero or more of the preceding element.
        /// The matching should cover the entire input string (not partial).
        /// </summary>
        /// <param name="s">String to match on</param>
        /// <param name="p">Pattern to match with</param>
        /// <returns>True if <paramref name="s"/> matches regex pattern <paramref name="p"/></returns>
        public bool IsMatch(ReadOnlySpan<char> s, ReadOnlySpan<char> p)
        {
            // If there is no pattern
            if (p.Length == 0)
                return false;

            // Keeps track of the pattern index
            int pIndex = 0;
            // Keeps track of whether we're repeating or not (i.e. character at pIndex+1 is '*')
            bool isRepating = false;

            // i represents the index in 's'
            // Loop until both the string and pattern has complete
            // (it's possible for hte pattern to have heaps of .*.* at the end
            // matching on 0 characters which is hwy we need to wait for both
            // conditions)
            for (int i = 0; i < s.Length || pIndex < p.Length; i++)
            {
                // Determine if it's a repeating character by checking if the next character
                // is a '*'
                isRepating = pIndex + 1 < p.Length ? (p[pIndex + 1] == '*' ? true : false) : false;

                // If we've gone past the end of the pattern
                if (pIndex >= p.Length)
                {
                    // Return false, it didn't match
                    return false;
                }

                // if we're repeating
                if (isRepating && pIndex+1 < p.Length)
                {
                    // Do a recusrive RegexMatch on the remainder of s and p
                    // (pIndex+2 because we're skipping over the '*')
                    //
                    // We need to do it to implmeent a greedt match while ensuring
                    // the end of hte pattern also matches
                    if (IsMatch(s.Slice(i), p.Slice(pIndex+2)))
                    {
                        return true;
                    }
                }

                // If we've gone past hte last index of s
                if (i >= s.Length)
                {
                    break;
                }

                // if the character doesn't match the pattern (directly or the pattern is '.')
                if (!(s[i] == p[pIndex] || p[pIndex] == '.'))
                {
                    // Didn't match, return false
                    return false;
                }

                // If we're not repeating, increment the pattern index
                if (!isRepating)
                {
                    pIndex++;
                }
            }

            // If we were repeating, increase the pattern by 2 to jump over
            // the '*'
            if (isRepating)
            {
                pIndex += 2;
            }

            // If the pattern index is greater or equal to the string index, after
            // matching everything above, we know the whole pattern matched the string
            return pIndex >= p.Length;
        }
    }
}
