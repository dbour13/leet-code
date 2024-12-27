using LeetCode.Lib;
using LeetCode.Lib.Common;
using System.Diagnostics.CodeAnalysis;

namespace LeetCode.Test.Problem0088
{
    public class SolutionUnitTests
    {
        [Fact]
        public void Test1()
        {
            int[] result = [1, 2, 3, 0, 0, 0];
            new Lib.Problem0088.Solution().Merge(result, 3, [2, 5, 6], 3);

            Assert.Equal([1, 2, 2, 3, 5, 6], result);
        }

        [Fact]
        public void Test2()
        {
            int[] result = [1];
            new Lib.Problem0088.Solution().Merge(result, 1, [], 0);

            Assert.Equal([1], result);
        }

        [Fact]
        public void Test3()
        {
            int[] result = [0];
            new Lib.Problem0088.Solution().Merge(result, 0, [1], 1);

            Assert.Equal([1], result);
        }

        [Fact]
        public void Test4()
        {
            int[] result = [2,0];
            new Lib.Problem0088.Solution().Merge(result, 1, [1], 1);

            Assert.Equal([1, 2], result);
        }
    }
}