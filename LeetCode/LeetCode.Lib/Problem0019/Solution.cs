using LeetCode.Lib.Common;

namespace LeetCode.Lib.Problem0019
{
    /// <summary>
    /// Level: Medium
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Given the <paramref name="head"/> of a linked list, remove the <paramref name="n"/>th node from the end of the 
        /// list and return its head.
        /// </summary>
        /// <param name="head">Head node of a linked list</param>
        /// <param name="n">element from the end of the list to remove</param>
        /// <returns>The head of the linked list after having removed <paramref name="n"/>th node</returns>
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            // Get the node before the nth node, so we can update it's 
            // next value to the node after the nth node
            var nthNode = GetLastNthNode(head, n+1);

            // If the nth node is the head node, or beyond the length of the list
            // (i.e. nthNode.Item1 is null)
            if (nthNode.Item1 == null)
            {
                // just return the next node in the list, same as removing the first
                // item
                return head.next;
            }

            // Set the n-1's next node to the node after the next node to remove the nth node
            nthNode.Item1.next = nthNode.Item1.next?.next;

            // Return the head
            return head;
        }

        /// <summary>
        /// Helper function to get the nth node in a linked list, going from the back
        /// </summary>
        /// <param name="node"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public (ListNode?, int) GetLastNthNode(ListNode node, int n)
        {
            // If we're at the end of the list (node.next == null)
            if (node.next == null)
            {
                // Return 1, and null for the node unless we are trying to get
                // the last index (i.e n == 1)
                return (n == 1 ? node : null, 1);
            }
            else
            {
                // Otherwise recursively call GetLastNthNode to find out what
                // index this node is
                var returnValue = GetLastNthNode(node.next, n);
                // Increment the index from the previous call of GetLastNthNode
                returnValue.Item2++;

                // If this node is the nth node
                if (returnValue.Item2 == n)
                {
                    // Set Item1 to this node so we can return it all the way up
                    returnValue.Item1 = node;
                }

                return returnValue;
            }
        }
    }
}
