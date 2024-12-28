using LeetCode.Lib;
using LeetCode.Lib.Common;
using System.Diagnostics.CodeAnalysis;

namespace LeetCode.Test.Problem0094
{
    public class SolutionUnitTests
    {
        [Fact]
        public void Test1()
        {
            IList<int> result = new Lib.Problem0094.Solution().InorderTraversal(new TreeNode(1, 
                                                                                             null, new TreeNode(2, 
                                                                                                                new TreeNode(3))));

            Assert.Equal([1, 3, 2], result);
        }

        [Fact]
        public void Test2()
        {
            TreeNode input = TreeNode.Create(1, 2, 3, 4, 5, null, 8, null, null, 6, 7, 9);
            IList<int> result = new Lib.Problem0094.Solution().InorderTraversal(input);

            Assert.Equal([4, 2, 6, 5, 7, 1, 3, 9, 8], result);
        }
    }
}