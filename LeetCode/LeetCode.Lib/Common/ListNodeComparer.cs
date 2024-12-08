using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Lib.Common
{
    public class ListNodeComparer : IEqualityComparer<ListNode>
    {
        private string GetString(ListNode? x)
        {
            return x.val.ToString() + (x.next != null ? GetString(x.next) : "");
        }

        public bool Equals(ListNode? x, ListNode? y)
        {
            return GetString(x) == GetString(y);
        }

        public int GetHashCode([DisallowNull] ListNode obj)
        {
            return GetString(obj).GetHashCode();
        }
    }
}
