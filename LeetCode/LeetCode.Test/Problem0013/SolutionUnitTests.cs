using LeetCode.Lib;

namespace LeetCode.Test.Problem0013
{
    public class SolutionUnitTests
    {
        [Fact]
        public void Test1()
        {
            int result = new Lib.Problem0013.Solution().RomanToInt("III");

            Assert.Equal(3, result);
        }

        [Fact]
        public void Test2()
        {
            int result = new Lib.Problem0013.Solution().RomanToInt("LVIII");

            Assert.Equal(58, result);
        }

        [Fact]
        public void Test3()
        {
            int result = new Lib.Problem0013.Solution().RomanToInt("MCMXCIV");

            Assert.Equal(1994, result);
        }
    }
}