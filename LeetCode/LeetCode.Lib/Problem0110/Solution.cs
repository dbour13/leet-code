using LeetCode.Lib.Common;
using System.Security.AccessControl;

namespace LeetCode.Lib.Problem0110
{
    /// <summary>
    /// Level: Easy
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Given a binary tree <paramref name="root"/>, determine if it is height-balanced.
        /// 
        /// A height-balanced binary tree is a binary tree in which the depth of the two subtrees 
        /// of every node never differs by more than one.
        /// </summary>
        /// <param name="root">a binary tree</param>
        /// <returns>True if <paramref name="root"> is balanced, false otherwise</returns>
        public bool IsBalanced(TreeNode root)
        {
            // Recursive, slow as it needs to get height recursively for each node, so roughly O(n^2)
            if (root == null) return true;

            int leftHeight = GetHeight(root.left);
            int rightHeight = GetHeight(root.right);

            return Math.Abs(rightHeight-leftHeight) < 2 && IsBalanced(root.left) && IsBalanced(root.right);
        }

        /// <summary>
        /// Same as IsBalanced, but does it iteratively and returns early if any node isn't balanced
        /// </summary>
        /// <param name="root">a binary tree</param>
        /// <returns>True if <paramref name="root"> is balanced, false otherwise</returns>
        public bool IsBalanced2(TreeNode root)
        {
            if (root == null) return true;

            Stack<TreeNode> ints = new Stack<TreeNode>();
            TreeNode currentNode = root;

            while (currentNode != null)
            {

            }

            throw new NotImplementedException();
        }

        public int GetHeight(TreeNode node)
        {
            if (node == null) return 0;

            return Math.Max(GetHeight(node.left) + 1, GetHeight(node.right) + 1);
        }
    }
}
