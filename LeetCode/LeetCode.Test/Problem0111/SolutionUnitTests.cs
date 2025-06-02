using LeetCode.Lib.Common;

namespace LeetCode.Test.Problem0111
{
    public class SolutionUnitTests
    {
        [Fact]
        public void Test1()
        {
            int result = new Lib.Problem0111.Solution().MinDepth(TreeNode.Create(3, 9, 20, null, null, 15, 7));

            Assert.Equal(2, result);
        }

        [Fact]
        public void Test2()
        {
            int result = new Lib.Problem0111.Solution().MinDepth(TreeNode.Create(2, null, 3, null, 4, null, 5, null, 6));

            Assert.Equal(5, result);
        }
    }
}