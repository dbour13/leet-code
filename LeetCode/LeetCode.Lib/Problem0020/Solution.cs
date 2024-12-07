using System.Text;

namespace LeetCode.Lib.Problem0020
{
    /// <summary>
    /// Level: Easy
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Given a string <paramref name="s"/> containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
        ///
        /// An input string is valid if:
        ///
        /// Open brackets must be closed by the same type of brackets.
        /// Open brackets must be closed in the correct order.
        /// Every close bracket has a corresponding open bracket of the same type.
        /// </summary>
        /// <param name="s">string to validate</param>
        /// <returns>true if brackets are valid, false otherwise</returns>
        public bool IsValid(string s)
        {
            // Push/Pop stack of open brackets as they are opened/closed
            Stack<char> brackets = new Stack<char>();

            // Loop over each character
            foreach (char c in s)
            {
                switch (c)
                {
                    case '(':
                    case '{':
                    case '[':
                        // Just push the bracket to the stack if it's an opening bracket
                        brackets.Push(c);
                        break;
                    case ')':
                    case '}':
                    case ']':
                        // Otherwise pop the bracket from the stack and make sure it matches
                        // with the closing bracket if it's a closing bracket
                        char prevBracket = default;
                        brackets.TryPop(out prevBracket);
                        if (!((prevBracket == '(' && c == ')')
                            || (prevBracket == '{' && c == '}')
                            || (prevBracket == '[' && c == ']')))
                        {
                            // If it doesn't match return false as it's invalid
                            return false;
                        }
                        break;
                    default:
                        // If an unexpected character comes up return false as it's invalid
                        return false;
                }
            }

            // Return true if we don't have any open brackets left that aren't closed
            return brackets.Count == 0;
        }
    }
}
