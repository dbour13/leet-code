using LeetCode.Lib.Common;

namespace LeetCode.Test.Problem0019
{
    public class SolutionUnitTests
    {
        [Fact]
        public void Test1()
        {
            ListNode result = new Lib.Problem0019.Solution().RemoveNthFromEnd(ListNode.Create(1,2,3,4,5), 2);

            Assert.Equal(ListNode.Create(1,2,3,5), result, new ListNodeComparer());
        }

        [Fact]
        public void Test2()
        {
            ListNode result = new Lib.Problem0019.Solution().RemoveNthFromEnd(ListNode.Create(1), 1);

            Assert.Equal(ListNode.Create(), result, new ListNodeComparer());
        }

        [Fact]
        public void Test3()
        {
            ListNode result = new Lib.Problem0019.Solution().RemoveNthFromEnd(ListNode.Create(1,2), 1);

            Assert.Equal(ListNode.Create(1), result, new ListNodeComparer());
        }
    }
}