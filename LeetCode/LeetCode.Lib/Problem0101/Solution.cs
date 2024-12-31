using LeetCode.Lib.Common;

namespace LeetCode.Lib.Problem0101
{
    /// <summary>
    /// Level: Easy
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Given the root of a binary tree, check whether it is a mirror of itself (i.e., symmetric around its center).
        /// </summary>
        /// <param name="p">Tree to check whether it's symmetrical</param>
        /// <returns>True if <paramref name="root"/> is symmetrical</returns>
        public bool IsSymmetric(TreeNode root)
        {
            // Recursive solution

            // If root is null (it's an empty tree), then it's a mirror, otherwise check the left and right
            // nodes are mirrored.
            return (root == null) || IsSymmetric(root.left, root.right);
        }

        /// <summary>
        /// Checks if the <paramref name="left"/> node is a mirror of the <paramref name="right"/> node
        /// </summary>
        /// <param name="left">Left node</param>
        /// <param name="right">Right node</param>
        /// <returns>True if <paramref name="left"/> is a mirror of <paramref name="right"/></returns>
        public bool IsSymmetric(TreeNode left, TreeNode right)
        {
            // Return true if left and right are both null, or if the left value and right value are the same and
            // the left's right nodes match with right's left nodes, and left's left nodes match with right's right
            // nodes (i.e. a mirror)
            return (left == null && right == null) || ((left?.val == right?.val) && IsSymmetric(left.right, right.left) && IsSymmetric(left.left, right.right));
        }
    }
}
