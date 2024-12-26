using LeetCode.Lib.Common;

namespace LeetCode.Lib.Problem0083
{
    /// <summary>
    /// Level: Easy
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Given the <paramref name="head"/> of a sorted linked list, delete all duplicates such that each element appears only once. 
        /// Return the linked list sorted as well.
        /// </summary>
        /// <param name="head">The head node</param>
        /// <returns>The same head node that was passed in</returns>
        public ListNode DeleteDuplicates(ListNode head)
        {
            // Keep track of the current node we're looking at
            ListNode current = head;

            // Loop through the ListNodes until we've reached the last node
            while (current?.next != null)
            {
                // If the next node's val is the same as this node's val
                if (current.next.val == current.val)
                {
                    // then remove the next node by setting this node's next node to be the next node's
                    // next node.
                    current.next = current.next.next;
                }
                else
                {
                    // Go to the next node
                    current = current.next;
                }
            }

            // Return the head node
            return head;
        }
    }
}
