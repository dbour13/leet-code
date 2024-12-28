namespace LeetCode.Lib.Common
{
    /// <summary>
    /// Definition for singly-linked list.
    /// </summary>
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public static TreeNode Create(params int?[] val)
        {
            if (val == null || val.Length == 0 || val[0] == null)
            {
                return null;
            }

            TreeNode returnValue = new TreeNode(val[0].Value);
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(returnValue);

            for (int i = 1; i < val.Length; i++)
            {
                TreeNode current = queue.Peek();

                if (val[i] != null)
                {
                    if (i%2==0)
                    {
                        current.right = new TreeNode(val[i].Value);
                        queue.Enqueue(current.right);
                    }
                    else
                    {
                        current.left = new TreeNode(val[i].Value);
                        queue.Enqueue(current.left);
                    }
                }

                if (i%2 == 0)
                {
                    queue.Dequeue();
                }
            }

            return returnValue;
        }
    }
}
