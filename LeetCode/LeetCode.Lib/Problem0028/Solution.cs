namespace LeetCode.Lib.Problem0028
{
    /// <summary>
    /// Level: Easy
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Given two strings <paramref name="needle"/> and <paramref name="haystack"/>, return the index of the first occurrence 
        /// of <paramref name="needle"/> in <paramref name="haystack"/>, or -1 if <paramref name="needle"/> is not part of <paramref name="haystack"/>.
        /// </summary>
        /// <param name="haystack">string to find index of substring <paramref name="needle"/></param>
        /// <param name="needle">substring to find in <paramref name="haystack"/></param>
        /// <returns>Index of <paramref name="needle"/> in <paramref name="haystack"/>, otherwise -1</returns>
        public int StrStr(string haystack, string needle)
        {
            // The return value, default to -1 to represent no match on substring needle
            int returnValue = -1;

            // Loop through each letter in haystack, up to needle.Length letters
            // less than haystack.Length (as it's impossible to match anymore without
            // at least needle.Length letters remaining in haystack)
            for (int i = 0; i+needle.Length <= haystack.Length; i++)
            {
                // Assume substring 'needle' matches until a character doesn't match
                bool same = true;

                // Go through each character in needle
                for (int j = 0; j < needle.Length; j++)
                {
                    // Check if the character in needle at index j matches
                    // the character in haystack at j, offset by i
                    if (haystack[i+j] != needle[j])
                    {
                        // If they don't match then they aren't the same
                        // and we can stop checking characters in this loop
                        same = false;
                        break;
                    }
                }

                // If it went through the above loop without any characters not
                // matching
                if (same)
                {
                    // Then we found the substring, set the returnValue
                    // to this index and break out of the main loop
                    returnValue = i;
                    break;
                }
            }

            return returnValue;
        }
    }
}
