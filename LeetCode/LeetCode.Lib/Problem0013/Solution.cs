namespace LeetCode.Lib.Problem0013
{
    /// <summary>
    /// Level: Easy
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Map roman numerals to their integer values
        /// </summary>
        private static readonly Dictionary<char, int> RomanNumeralValues = new([
                new KeyValuePair<char,int>('I',1),
                new KeyValuePair<char,int>('V',5),
                new KeyValuePair<char,int>('X',10),
                new KeyValuePair<char,int>('L',50),
                new KeyValuePair<char,int>('C',100),
                new KeyValuePair<char,int>('D',500),
                new KeyValuePair<char,int>('M',1000),
            ]);

        /// <summary>
        /// Given a roman numeral, convert it to an integer.
        /// </summary>
        /// <param name="s">Roman numeral to convert to an integer</param>
        /// <returns>Integer equivalent of Roman Numeral <paramref name="s"/></returns>
        public int RomanToInt(string s)
        {
            // Holds the return value
            int retValue = 0;
            // Holds the largest value we've seen so far while going backwards through the string of Roman Numerals
            int largestValue = 0;

            // Go backwards through the string of Roman Numerals, so we process the smallest
            // numerals first and the largest last
            for (int i = s.Length-1; i >= 0; i --)
            {
                // Get the value of the current numeral using the dictionary mapping
                int curNumeralValue = RomanNumeralValues[s[i]];

                // If the largest Roman Numeral  we've seen so far isn't any bigger than the current Roman Numeral
                if (largestValue <= curNumeralValue)
                {
                    // Then we just add the Roman Numeral value to our return value
                    retValue += curNumeralValue;
                    // And update the largest value to the current value, since current value is at least as big
                    // as largest value.
                    largestValue = curNumeralValue;
                }
                else
                {
                    // Otherwise if the current numeral is smaller than the largest one we've seen so far, subtract
                    // it from the return value instead
                    retValue -= curNumeralValue;
                }
            }

            return retValue;
        }
    }
}
