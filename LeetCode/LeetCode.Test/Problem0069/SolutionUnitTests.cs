using LeetCode.Lib;
using LeetCode.Lib.Common;
using System.Text.RegularExpressions;

namespace LeetCode.Test.Problem0069
{
    public class SolutionUnitTests
    {
        [Fact]
        public void Test1()
        {
            int result = new Lib.Problem0069.Solution().MySqrt(4);

            Assert.Equal(2, result);
        }

        [Fact]
        public void Test2()
        {
            int result = new Lib.Problem0069.Solution().MySqrt(8);

            Assert.Equal(2, result);
        }

        [Fact]
        public void Test3()
        {
            int result = new Lib.Problem0069.Solution().MySqrt(2147483647);

            Assert.Equal(46340, result);
        }

        [Fact]
        public void Test4()
        {
            int result = new Lib.Problem0069.Solution().MySqrt(3);

            Assert.Equal(1, result);
        }
    }
}