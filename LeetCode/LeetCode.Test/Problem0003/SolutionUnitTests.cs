using LeetCode.Lib;
using LeetCode.Lib.Problem0002;
using System.Diagnostics.CodeAnalysis;

namespace LeetCode.Test.Problem0003
{
    public class SolutionUnitTests
    {
        [Fact]
        public void Test1()
        {
            int result = new Lib.Problem0003.Solution().LengthOfLongestSubstring("abcabcbb");

            Assert.Equal(3, result);
        }

        [Fact]
        public void Test2()
        {
            int result = new Lib.Problem0003.Solution().LengthOfLongestSubstring("bbbbb");

            Assert.Equal(1, result);
        }

        [Fact]
        public void Test3()
        {
            int result = new Lib.Problem0003.Solution().LengthOfLongestSubstring("pwwkew");

            Assert.Equal(3, result);
        }

        [Fact]
        public void Test4()
        {
            int result = new Lib.Problem0003.Solution().LengthOfLongestSubstring("a");

            Assert.Equal(1, result);
        }

        [Fact]
        public void Test5()
        {
            int result = new Lib.Problem0003.Solution().LengthOfLongestSubstring("");

            Assert.Equal(0, result);
        }

        [Fact]
        public void Test6()
        {
            int result = new Lib.Problem0003.Solution().LengthOfLongestSubstring("au");

            Assert.Equal(2, result);
        }

        [Fact]
        public void Test7()
        {
            int result = new Lib.Problem0003.Solution().LengthOfLongestSubstring("aab");

            Assert.Equal(2, result);
        }
    }
}