using LeetCode.Lib;
using LeetCode.Lib.Common;
using System.Text.RegularExpressions;

namespace LeetCode.Test.Problem0021
{
    public class SolutionUnitTests
    {
        [Fact]
        public void Test1()
        {
            ListNode result = new Lib.Problem0021.Solution().MergeTwoLists(ListNode.Create(1,2,4), ListNode.Create(1,3,4));

            Assert.Equal(ListNode.Create(1,1,2,3,4,4), result, new ListNodeComparer());
        }

        [Fact]
        public void Test2()
        {
            ListNode result = new Lib.Problem0021.Solution().MergeTwoLists(ListNode.Create(), ListNode.Create());

            Assert.Equal(ListNode.Create(), result, new ListNodeComparer());
        }

        [Fact]
        public void Test3()
        {
            ListNode result = new Lib.Problem0021.Solution().MergeTwoLists(ListNode.Create(), ListNode.Create(0));

            Assert.Equal(ListNode.Create(0), result, new ListNodeComparer());
        }
    }
}