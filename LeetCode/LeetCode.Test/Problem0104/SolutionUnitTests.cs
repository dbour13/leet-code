using LeetCode.Lib.Common;

namespace LeetCode.Test.Problem0104
{
    public class SolutionUnitTests
    {
        [Fact]
        public void Test1()
        {
            int result = new Lib.Problem0104.Solution().MaxDepth(TreeNode.Create(3, 9, 20, null, null, 15, 7));

            Assert.Equal(3, result);
        }

        [Fact]
        public void Test2()
        {
            int result = new Lib.Problem0104.Solution().MaxDepth(TreeNode.Create(1, null, 2));

            Assert.Equal(2, result);
        }

        [Fact]
        public void Test3()
        {
            int result = new Lib.Problem0104.Solution().MaxDepth(TreeNode.Create(1));

            Assert.Equal(1, result);
        }

        [Fact]
        public void Test4()
        {
            int result = new Lib.Problem0104.Solution().MaxDepth(null);

            Assert.Equal(0, result);
        }
    }
}