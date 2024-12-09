using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Text;

namespace LeetCode.Lib.Problem0006
{
    /// <summary>
    /// Level: Medium
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// The string "PAYPALISHIRING" is written in a zigzag pattern on a given 
        /// number of rows like this: (you may want to display this pattern in a fixed font for better legibility)
        /// 
        /// P   A   H   N
        /// A P L S I I G
        /// Y   I R
        /// And then read line by line: "PAHNAPLSIIGYIR"
        /// Write the code that will take a string and make this conversion given a number of rows
        /// </summary>
        /// <param name="s">String to convert to a zigzag pattern</param>
        /// <returns>string from zigzag pattern of <paramref name="s"/></returns>
        public string Convert(string s, int numRows)
        {
            // If there's only one row, return the string as is
            if (numRows == 1)
            {
                return s;
            }

            // Build the string
            StringBuilder result = new StringBuilder();

            // For each row in the ZigZag
            for (int i = 0; i < numRows; i++)
            {
                // Find the Left/Right letters for each peak
                // The right letter of each peak will be every (rows*2)-2 from the current row number
                for (int j = i; j - (i * 2) < s.Length; j += (numRows * 2) - 2)
                {
                    // The left letter will be 2 times the row number less than the right letter
                    int left = j - (i * 2);

                    if (i != 0 && i != numRows - 1 && left >= 0)
                    {
                        // Add the left letter (if any for this peak)
                        result.Append(s[left]);
                    }

                    if (j < s.Length)
                    {
                        // Add the right letter (if any for this peak)
                        result.Append(s[j]);
                    }
                }
            }

            return result.ToString();
        }

        /// <summary>
        /// Alternate solution
        /// </summary>
        /// <param name="s"></param>
        /// <param name="numRows"></param>
        /// <returns></returns>
        public string Convert2(string s, int numRows)
        {
            if (numRows == 1)
            {
                return s;
            }

            // Create a string builder for each row in the ZigZag
            StringBuilder[] builder = new StringBuilder[numRows];
            StringBuilder result = new StringBuilder();

            // Initialize the builders
            for (int i = 0; i < numRows; i++)
            {
                builder[i] = new StringBuilder();
            }

            // True = go down the zipzag, false = go up the zigzag
            bool direction = true;
            // The row in the zigzag we're looking at
            int row = 0;

            // For each character in string s
            for (int i = 0; i < s.Length; i++)
            {
                // Add the character to the current row in the ZigZag we're looking at
                builder[row].Append(s[i]);

                // If we're going down the zigzag
                if (direction)
                {
                    // Increase the row we're looking at
                    row++;

                    // If we've reached the last row
                    if (row >= numRows)
                    {
                        // Change direction
                        direction = false;
                        row -= 2;
                    }
                }
                else
                {
                    // Otherwise decrement the row we're looking at
                    row--;

                    // If we've reached the first row
                    if (row < 0)
                    {
                        // Change direction
                        direction = true;
                        row += 2;
                    }
                }
            }

            // Combine the string builders together into a single string
            foreach (var b in builder)
            {
                result.Append(b);
            }

            return result.ToString();
        }
    }
}
