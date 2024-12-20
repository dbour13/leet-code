using LeetCode.Lib;
using LeetCode.Lib.Common;
using System.Text.RegularExpressions;

namespace LeetCode.Test.Problem0066
{
    public class SolutionUnitTests
    {
        [Fact]
        public void Test1()
        {
            int[] result = new Lib.Problem0066.Solution().PlusOne([1, 2, 3]);

            Assert.Equal([1,2,4], result);
        }

        [Fact]
        public void Test2()
        {
            int[] result = new Lib.Problem0066.Solution().PlusOne([4, 3, 2, 1]);

            Assert.Equal([4, 3, 2, 2], result);
        }

        [Fact]
        public void Test3()
        {
            int[] result = new Lib.Problem0066.Solution().PlusOne([9]);

            Assert.Equal([1, 0], result);
        }
    }
}