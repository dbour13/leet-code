using LeetCode.Lib.Common;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Linq;
using System;

namespace LeetCode.Lib.Problem0094
{
    /// <summary>
    /// Level: Easy
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Given the root of a binary tree, return the inorder traversal of its nodes' values.
        /// </summary>
        /// <param name="nums1">First array to merge</param>
        /// <param name="m">length of <paramref name="nums1"/></param>
        /// <returns></returns>
        public IList<int> InorderTraversal2(TreeNode root)
        {
            // Recusive solution

            // If root is null, return an empty list
            if (root == null)
            {
                return new List<int>();
            }

            // Otherwise hold return value in a list
            List<int> returnValue = new List<int>();

            // Recusrively add the left nodes, then add the current node, then recursively add the right nodes
            returnValue.AddRange(InorderTraversal2(root.left));
            returnValue.Add(root.val);
            returnValue.AddRange(InorderTraversal2(root.right));

            return returnValue;
        }

        public IList<int> InorderTraversal(TreeNode root)
        {
            // Iterative solution

            // If root is null, return an empty list
            if (root == null)
            {
                return new List<int>();
            }

            // Use stack to keep track of which nodes to process next
            Stack<TreeNode> stack = new Stack<TreeNode>();
            // Holds the return value
            List<int> returnValue = new List<int>();
            // Push the root node to the top of the stack
            stack.Push(root);

            // While there are items in the stack to process
            while (stack.Count > 0)
            {
                // Pop the last item from the stack
                TreeNode current = stack.Pop();

                // Push the right node of the current node if it isn't null
                if (current.right != null)
                {
                    stack.Push(current.right);
                }

                // Push the middle node without any children unless this node has no children, so when we process it
                // it will be added in the correct order (left nodes and decendents, then current node, then right nodes and descendents)
                //
                // If this node has no children, just add the value to the returnValue list and don't add it to the stack
                if (current.left == null && current.right == null)
                {
                    returnValue.Add(current.val);
                }
                else
                {
                    stack.Push(new TreeNode(current.val));
                }

                // Push the left node of the current node if it isn't null
                if (current.left != null)
                {
                    stack.Push(current.left);
                }
            }

            return returnValue;
        }
    }
}
