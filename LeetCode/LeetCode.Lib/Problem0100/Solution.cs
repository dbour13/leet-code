using LeetCode.Lib.Common;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Linq;
using System;

namespace LeetCode.Lib.Problem0100
{
    /// <summary>
    /// Level: Easy
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Given the roots of two binary trees <paramref name="p"/> and <paramref name="q"/>, write a function to check if 
        /// they are the same or not.
        ///
        /// Two binary trees are considered the same if they are structurally identical, and the nodes have the same value.
        /// </summary>
        /// <param name="p">First tree</param>
        /// <param name="q">Second tree to compare against first</param>
        /// <returns>True if <paramref name="p"/> and <paramref name="q"/> are the same tree structure and values</returns>
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            // Recursive solution

            // Break condition is when both p and q are null, or p?.val doesn't equal q.val, otherwise it'll recursively
            // go down the left and right branches to check they are the same
            return (p == null && q == null) || ((p?.val == q?.val) && IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right));
        }
    }
}
