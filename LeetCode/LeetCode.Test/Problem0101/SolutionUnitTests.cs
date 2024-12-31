using LeetCode.Lib.Common;

namespace LeetCode.Test.Problem0101
{
    public class SolutionUnitTests
    {
        [Fact]
        public void Test1()
        {
            bool result = new Lib.Problem0101.Solution().IsSymmetric(TreeNode.Create(1, 2, 2, 3, 4, 4, 3));

            Assert.True(result);
        }

        [Fact]
        public void Test2()
        {
            bool result = new Lib.Problem0101.Solution().IsSymmetric(TreeNode.Create(1, 2, 2, null, 3, null, 3));

            Assert.False(result);
        }
    }
}