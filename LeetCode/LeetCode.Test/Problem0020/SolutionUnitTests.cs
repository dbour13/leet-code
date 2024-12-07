using LeetCode.Lib;

namespace LeetCode.Test.Problem0020
{
    public class SolutionUnitTests
    {
        [Fact]
        public void Test1()
        {
            bool result = new Lib.Problem0020.Solution().IsValid("()");

            Assert.True(result);
        }

        [Fact]
        public void Test2()
        {
            bool result = new Lib.Problem0020.Solution().IsValid("()[]{}");

            Assert.True(result);
        }

        [Fact]
        public void Test3()
        {
            bool result = new Lib.Problem0020.Solution().IsValid("(]");

            Assert.False(result);
        }

        [Fact]
        public void Test4()
        {
            bool result = new Lib.Problem0020.Solution().IsValid("([])");

            Assert.True(result);
        }

        [Fact]
        public void Test5()
        {
            bool result = new Lib.Problem0020.Solution().IsValid("(");

            Assert.False(result);
        }
    }
}