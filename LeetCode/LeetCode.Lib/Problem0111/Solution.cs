using LeetCode.Lib.Common;
using System.Security.AccessControl;
using System.Xml.Linq;

namespace LeetCode.Lib.Problem0111
{
    /// <summary>
    /// Level: Easy
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Given a binary tree <paramref name="root"/>, find its minimum depth.
        ///
        /// The minimum depth is the number of nodes along the shortest path from the root node down to the nearest leaf node.
        ///
        /// Note: A leaf is a node with no children.
        /// </summary>
        /// <param name="root">a binary tree</param>
        /// <returns>Minimum depth of <paramref name="root"/></returns>
        public int MinDepth(TreeNode root)
        {
            // If root is null, there are no nodes, so depth is 0
            if (root == null) return 0;

            // Create a queue so we can process the first row, then the second row, then the third row, etc.
            // Doing it recursively would process all the left or right nodes down to the bottom first.
            Queue<Tuple<TreeNode, int>> queue = new Queue<Tuple<TreeNode, int>>();

            queue.Enqueue(new Tuple<TreeNode, int>(root, 1));

            // Process queue until empty or we reach a node without any child nodes (i.e. minimum depth)
            while (queue.Count > 0)
            {
                var node = queue.Dequeue();

                // If this node doesn't have any child nodes
                if (node.Item1.left == null && node.Item1.right == null)
                {
                    // we've reached the minimum depth, return
                    return node.Item2;
                }

                // Otherwise enqueue the left and right nodes to be processed after everything else
                // in the queue has been processed
                if (node.Item1.left != null)
                {
                    queue.Enqueue(new Tuple<TreeNode, int>(node.Item1.left, node.Item2+1));
                }
                if (node.Item1.right != null)
                {
                    queue.Enqueue(new Tuple<TreeNode, int>(node.Item1.right, node.Item2 + 1));
                }
            }

            throw new Exception("Shouldn't be possible to get here as there'll eventually be a node with no child nodes");
        }
    }
}
