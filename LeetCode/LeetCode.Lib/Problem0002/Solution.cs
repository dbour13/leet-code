namespace LeetCode.Lib.Problem0002
{
    /// <summary>
    /// Level: Medium
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.
        ///
        /// You may assume the two numbers do not contain any leading zero, except the number 0 itself.
        /// </summary>
        /// <param name="l1">A linked list representing a number in reverse order</param>
        /// <param name="l2">A linked list representing a number in reverse order</param>
        /// <returns>A linked list representing a number in reverse order that's the sum of <paramref name="l1"/> and <paramref name="l2"/></returns>
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            // Holds the linked list to return
            ListNode retValue = new ListNode();

            // Holds the current nodes we're looking at
            ListNode curRetValue = retValue;
            ListNode curL1 = l1;
            ListNode curL2 = l2;

            // true if there was a remainder when adding the previous nodes
            bool remainder = false;

            // Continue until we've exhausted the nodes in both lists and any remainders
            while (curL1 != null || curL2 != null || remainder)
            {
                // Create new node for this digit
                curRetValue.next = new ListNode();
                curRetValue = curRetValue.next;

                // Add the numbers and remainder
                curRetValue.val = (curL1?.val ?? 0) + (curL2?.val ?? 0) + (remainder ? 1:0);

                // Reset remainder back to false after having added it
                remainder = false;

                // If the sum was 10 or over
                if (curRetValue.val >= 10)
                {
                    // Remove the extra digit and set the remainder flag
                    curRetValue.val %= 10;
                    remainder = true;
                }

                // get next item in the lists
                curL1 = curL1?.next;
                curL2 = curL2?.next;
            }

            // To get the while statement above to work without a special case
            // for the first node, we ignored the first node, so just return
            // the second node
            return retValue.next;
        }
    }
}
