using LeetCode.Lib;
using LeetCode.Lib.Common;
using System.Text.RegularExpressions;

namespace LeetCode.Test.Problem0026
{
    public class SolutionUnitTests
    {
        [Fact]
        public void Test1()
        {
            int[] input = [1, 1, 2];

            int result = new Lib.Problem0026.Solution().RemoveDuplicates(input);

            Assert.Equal(2, result);

            Assert.Equal([1, 2], input.Take(2).ToArray());
        }

        [Fact]
        public void Test2()
        {
            int[] input = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];

            int result = new Lib.Problem0026.Solution().RemoveDuplicates(input);

            Assert.Equal(5, result);

            Assert.Equal([0, 1, 2, 3, 4], input.Take(5).ToArray());
        }
    }
}