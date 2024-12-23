using LeetCode.Lib;
using LeetCode.Lib.Common;
using System.Text.RegularExpressions;

namespace LeetCode.Test.Problem0067
{
    public class SolutionUnitTests
    {
        [Fact]
        public void Test1()
        {
            string result = new Lib.Problem0067.Solution().AddBinary("11", "1");

            Assert.Equal("100", result);
        }

        [Fact]
        public void Test2()
        {
            string result = new Lib.Problem0067.Solution().AddBinary("1010", "1011");

            Assert.Equal("10101", result);
        }

        [Fact]
        public void Test3()
        {
            string result = new Lib.Problem0067.Solution().AddBinary("100", "1");

            Assert.Equal("101", result);
        }
    }
}