using LeetCode.Lib.Common;

namespace LeetCode.Test.Problem0100
{
    public class SolutionUnitTests
    {
        [Fact]
        public void Test1()
        {
            bool result = new Lib.Problem0100.Solution().IsSameTree(TreeNode.Create(1,2,3), TreeNode.Create(1,2,3));

            Assert.True(result);
        }

        [Fact]
        public void Test2()
        {
            bool result = new Lib.Problem0100.Solution().IsSameTree(TreeNode.Create(1, 2), TreeNode.Create(1, null, 2));

            Assert.False(result);
        }

        [Fact]
        public void Test3()
        {
            bool result = new Lib.Problem0100.Solution().IsSameTree(TreeNode.Create(1, 2, 1), TreeNode.Create(1, 1, 2));

            Assert.False(result);
        }
    }
}