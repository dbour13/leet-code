using LeetCode.Lib.Common;

namespace LeetCode.Lib.Problem0104
{
    /// <summary>
    /// Level: Easy
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Given the <paramref name="root"/> of a binary tree, return its maximum depth.
        ///
        /// A binary tree's maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.
        /// </summary>
        /// <param name="root">Tree to get maximum depth</param>
        /// <returns>Max depth of <paramref name="root"/></returns>
        public int MaxDepth(TreeNode root)
        {
            // Recursive solution           
            if (root == null) return 0;

            return Math.Max(MaxDepth(root.left)+1, MaxDepth(root.right)+1);
        }
    }
}
