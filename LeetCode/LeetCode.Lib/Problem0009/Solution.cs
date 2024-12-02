namespace LeetCode.Lib.Problem0009
{
    /// <summary>
    /// Level: Easy
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Given an integer x, return true if x is a palindrome, and false otherwise.
        /// </summary>
        /// <param name="x">Integer to check if it's a palindrome</param>
        /// <returns>True if <paramref name="x"/> is a palindrome, False otherwise</returns>
        public bool IsPalindrome(int x)
        {
            // Negative numbers can't be palindromes as they only have a single '-' sign and one or more numbers
            if (x < 0) return false;

            // Convert the number to a string
            string s = x.ToString();

            // Go half way through the list, comparing mirrored indexes (i.e. the first element to the last,
            // the second to the second last, etc)
            for (int i = 0; i < s.Length/2; i++)
            {
                // Return false if any of the mirrored indexes values don't match
                if (s[i] != s[s.Length-1-i])
                {
                    return false;
                }
            }

            // Return true as there were no non-matching mirrored indexes above
            return true;
        }

        /// <summary>
        /// Given an integer x, return true if x is a palindrome, and false otherwise.
        /// </summary>
        /// <remarks>
        /// This should be slightly faster than IsPalindome as it doesn't need to convert the number
        /// to a string first, which would require its own loop and more memory to store the string.
        /// </remarks>
        /// <param name="x">Integer to check if it's a palindrome</param>
        /// <returns>True if <paramref name="x"/> is a palindrome, False otherwise</returns>
        public bool IsPalindrome2(int x)
        {
            // Negative numbers can't be palindromes as they only have a single '-' sign and one or more numbers
            if (x < 0) return false;

            // Copy x into x2, as we dont want to update x directly
            int x2 = x;
            // Reverse will hold the reversed number to compare with the original
            int reverse = 0;

            // Keep dividing x2 by 10 until it reaches 0
            while (x2 != 0)
            {
                // Move all the digits to the left of the reversed number by one digit (i.e. multiple by 10)
                reverse *= 10;
                // Get the right most digit of x2 by using mod 10
                int digit = x2 % 10;
                // Move all the digits to the right of x2 by one digit (i.e. divide by 10)
                x2 = x2 / 10;
                // Add the right most digit from x2 to the reversed number
                reverse += digit;
            }

            // If the reversed number is the same as the original, it's a plaindrome
            return reverse == x; 
        }
    }
}
