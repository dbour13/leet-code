using LeetCode.Lib.Common;

namespace LeetCode.Test.Problem0108
{
    public class SolutionUnitTests
    {
        [Fact]
        public void Test1()
        {
            TreeNode result = new Lib.Problem0108.Solution().SortedArrayToBST([-10, -3, 0, 5, 9]);

            Assert.Equal(TreeNode.Create(0, -3, 9, -10, null, 5), result, new TreeNodeComparer());
        }

        [Fact]
        public void Test2()
        {
            TreeNode result = new Lib.Problem0108.Solution().SortedArrayToBST([1, 3]);

            Assert.Equal(TreeNode.Create(3, 1), result, new TreeNodeComparer());
        }
    }
}