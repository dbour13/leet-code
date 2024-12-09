using LeetCode.Lib;
using LeetCode.Lib.Problem0002;
using System.Diagnostics.CodeAnalysis;

namespace LeetCode.Test.Problem0005
{
    public class SolutionUnitTests
    {
        [Fact]
        public void Test1()
        {
            string result = new Lib.Problem0005.Solution().LongestPalindrome("babad");

            Assert.Equal("bab", result);
        }

        [Fact]
        public void Test2()
        {
            string result = new Lib.Problem0005.Solution().LongestPalindrome("cbbd");

            Assert.Equal("bb", result);
        }
    }
}