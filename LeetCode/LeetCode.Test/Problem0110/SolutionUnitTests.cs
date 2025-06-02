using LeetCode.Lib.Common;

namespace LeetCode.Test.Problem0110
{
    public class SolutionUnitTests
    {
        [Fact]
        public void Test1()
        {
            bool result = new Lib.Problem0110.Solution().IsBalanced(TreeNode.Create(3, 9, 20, null, null, 15, 7));

            Assert.True(result);
        }

        [Fact]
        public void Test2()
        {
            bool result = new Lib.Problem0110.Solution().IsBalanced(TreeNode.Create(1, 2, 2, 3, 3, null, null, 4, 4));

            Assert.False(result);
        }

        [Fact]
        public void Test3()
        {
            bool result = new Lib.Problem0110.Solution().IsBalanced(null);

            Assert.True(result);
        }

        [Fact]
        public void Test4()
        {
            var root = TreeNode.Create(1, 2, 2, 3, null, null, 3, 4, null, null, 4);

            bool result = new Lib.Problem0110.Solution().IsBalanced(root);

            Assert.False(result);
        }        
    }
}