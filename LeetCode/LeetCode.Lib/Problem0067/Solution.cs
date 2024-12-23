namespace LeetCode.Lib.Problem0067
{
    /// <summary>
    /// Level: Easy
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Given two binary strings <paramref name="a"/> and <paramref name="b"/>, return their sum as a binary string.
        /// </summary>
        /// <param name="a">string containing the numbers 0 and 1</param>
        /// <param name="b">string containing the numbers 0 and 1</param>
        /// <returns>The sum of the binary strings <paramref name="a"/> and <paramref name="b"/></returns>
        public string AddBinary(string a, string b)
        {
            // Holds the result.  The result could be up to one character longer
            // than the longest string between a and b
            char[] result = new char[Math.Max(a.Length, b.Length)+1];
            // Flag true if there is a carry over after adding two digits
            bool carryOver = false;
            // current digit value we're looking at
            int thisDigit = 0;
            // value of a for current digit we're looking at as an int
            int aVal = 0;
            // value of b for current digit we're looking at as an int
            int bVal = 0;

            // i Loops forwards through both lists, up to the max length
            // between the two lists, but the arrays will work backwards
            // (length-i).  Has to be done this way as the lengths are different
            // so decrementing i instead wouldn't work for both lists.
            for (int i = 1; i <= a.Length || i <= b.Length; i++)
            {
                // If we're not past the end of the array, get value from
                // a and b and convert it from a character number to an int.  Otherwise
                // use 0 for the value
                aVal = a.Length >= i ? a[a.Length-i]-'0' : 0;
                bVal = b.Length >= i ? b[b.Length-i]-'0' : 0;

                // Get the sum of both values and the carry over
                thisDigit = aVal + bVal + (carryOver ? 1 : 0);
                // Set carry over back to false now we've used it up
                carryOver = false;

                // If we've gone over 1
                if (thisDigit > 1)
                {
                    // subtract 2 from the digit and set the carry over flag again
                    thisDigit -= 2;
                    carryOver = true;
                }

                // convert thisDigit to a character and update result
                result[result.Length-i] = (char) (thisDigit + '0');
            }

            // If there was a carry over after adding the two strings
            if (carryOver)
            {
                // set the first digit to '1' and return the whole char array
                // as a string
                result[0] = '1';
                return new string(result);
            }

            // otherwise skip the first char in the char array and return it as a string
            return new string(result[1..]);
        }
    }
}
