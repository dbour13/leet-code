using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Lib.Common
{
    public class TreeNodeComparer : IEqualityComparer<TreeNode>
    {
        private string GetString(TreeNode? x)
        {
            return (x == null) ? "(null)" : $"({x.val} [{GetString(x.left)}] [{GetString(x.right)}])";
        }

        public bool Equals(TreeNode? x, TreeNode? y)
        {
            return GetString(x) == GetString(y);
        }

        public int GetHashCode([DisallowNull] TreeNode obj)
        {
            return GetString(obj).GetHashCode();
        }
    }
}
