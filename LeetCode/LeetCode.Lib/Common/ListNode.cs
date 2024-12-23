namespace LeetCode.Lib.Common
{
    /// <summary>
    /// Definition for singly-linked list.
    /// </summary>
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public static ListNode Create(params int[] vals)
        {
            ListNode returnValue = new ListNode();
            ListNode head = returnValue;

            foreach (var v in vals)
            {
                returnValue.next = new ListNode();
                returnValue = returnValue.next;
                returnValue.val = v;
            }

            return head.next;
        }
    }
}
