using LeetCode.Lib.Common;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Xml.Linq;

namespace LeetCode.Lib.Problem0021
{
    /// <summary>
    /// Level: Easy
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// You are given the heads of two sorted linked lists <paramref name="list1"/> and <paramref name="list2"/>.
        ///
        /// Merge the two lists into one sorted list.The list should be made by splicing together the nodes of the first two lists.
        ///
        /// Return the head of the merged linked list.
        /// </summary>
        /// <param name="list1">Linked list containing integers</param>
        /// <param name="list2">Linked list containing integers</param>
        /// <returns>Merged, ordered linked list of <paramref name="list1"/> and <paramref name="list2"/></returns>
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            // ListNode to return
            ListNode returnNode = new ListNode();

            // Keep track of current nodes
            ListNode currentReturnNode = returnNode;
            ListNode currentList1 = list1;
            ListNode currentList2 = list2;

            // Loop through both lists until you're reached the end of both
            while (currentList1 != null || currentList2 != null)
            {
                // Create a new node at the start of the loop so we don't have an extra
                // node at the end
                currentReturnNode.next = new ListNode();
                currentReturnNode = currentReturnNode.next;

                // If the currentList1 node is greater than the currentlist2 node
                if ((currentList1?.val ?? int.MaxValue) > (currentList2?.val ?? int.MaxValue))
                {
                    // Then add the currentList2 node, as it's the smaller of the two
                    currentReturnNode.val = currentList2.val;
                    currentList2 = currentList2.next;
                }
                else
                {
                    // Otherwise add the currentList1 node
                    currentReturnNode.val = currentList1.val;
                    currentList1 = currentList1.next;
                }
            }

            // We ignored the first node in the while loop so return from the second node
            return returnNode.next;
        }
    }
}
