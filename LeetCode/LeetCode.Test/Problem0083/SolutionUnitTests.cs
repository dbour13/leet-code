using LeetCode.Lib;
using LeetCode.Lib.Common;
using System.Diagnostics.CodeAnalysis;

namespace LeetCode.Test.Problem0083
{
    public class SolutionUnitTests
    {
        [Fact]
        public void Test1()
        {
            ListNode result = new Lib.Problem0083.Solution().DeleteDuplicates(ListNode.Create(1,1,2));

            Assert.Equal(ListNode.Create(1,2), result, new ListNodeComparer());
        }

        [Fact]
        public void Test2()
        {
            ListNode result = new Lib.Problem0083.Solution().DeleteDuplicates(ListNode.Create(1, 1, 2, 3, 3));

            Assert.Equal(ListNode.Create(1, 2, 3), result, new ListNodeComparer());
        }

        [Fact]
        public void Test3()
        {
            ListNode result = new Lib.Problem0083.Solution().DeleteDuplicates(ListNode.Create(1, 1, 1, 2, 3, 3));

            Assert.Equal(ListNode.Create(1, 2, 3), result, new ListNodeComparer());
        }
    }
}