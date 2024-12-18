using LeetCode.Lib;
using LeetCode.Lib.Common;
using System.Text.RegularExpressions;

namespace LeetCode.Test.Problem0027
{
    public class SolutionUnitTests
    {
        [Fact]
        public void Test1()
        {
            int[] input = [3, 2, 2, 3];

            int result = new Lib.Problem0027.Solution().RemoveElement(input, 3);

            Assert.Equal(2, result);

            Assert.Equal([2, 2], input.Take(2).ToArray());
        }

        [Fact]
        public void Test2()
        {
            int[] input = [0, 1, 2, 2, 3, 0, 4, 2];

            int result = new Lib.Problem0027.Solution().RemoveElement(input, 2);

            Assert.Equal(5, result);

            Assert.Equal([0, 1, 3, 0, 4], input.Take(5).ToArray());
        }
    }
}