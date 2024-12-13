using LeetCode.Lib;

namespace LeetCode.Test.Problem0010
{
    public class SolutionUnitTests
    {
        [Fact]
        public void Test1()
        {
            bool result = new Lib.Problem0010.Solution().IsMatch("aa", "a");

            Assert.False(result);
        }

        [Fact]
        public void Test2()
        {
            bool result = new Lib.Problem0010.Solution().IsMatch("aa", "a*");

            Assert.True(result);
        }

        [Fact]
        public void Test3()
        {
            bool result = new Lib.Problem0010.Solution().IsMatch("ab", ".*");

            Assert.True(result);
        }

        [Fact]
        public void Test4()
        {
            bool result = new Lib.Problem0010.Solution().IsMatch("abc", "ab*c.*");

            Assert.True(result);
        }
    }
}