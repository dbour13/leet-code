using LeetCode.Lib;

namespace LeetCode.Test.Problem0009
{
    public class SolutionUnitTests
    {
        [Fact]
        public void Test1()
        {
            bool result = new Lib.Problem0009.Solution().IsPalindrome(121);

            Assert.True(result);
        }

        [Fact]
        public void Test2()
        {
            bool result = new Lib.Problem0009.Solution().IsPalindrome(-121);

            Assert.False(result);
        }

        [Fact]
        public void Test3()
        {
            bool result = new Lib.Problem0009.Solution().IsPalindrome(10);

            Assert.False(result);
        }

        [Fact]
        public void Test4()
        {
            bool result = new Lib.Problem0009.Solution().IsPalindrome2(121);

            Assert.True(result);
        }

        [Fact]
        public void Test5()
        {
            bool result = new Lib.Problem0009.Solution().IsPalindrome2(-121);

            Assert.False(result);
        }

        [Fact]
        public void Test6()
        {
            bool result = new Lib.Problem0009.Solution().IsPalindrome2(10);

            Assert.False(result);
        }
    }
}