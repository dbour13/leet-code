using LeetCode.Lib;

namespace LeetCode.Test.Problem0012
{
    public class SolutionUnitTests
    {
        [Fact]
        public void Test1()
        {
            string result = new Lib.Problem0012.Solution().IntToRoman(3749);


            Assert.Equal("MMMDCCXLIX", result);
        }

        [Fact]
        public void Test2()
        {
            string result = new Lib.Problem0012.Solution().IntToRoman(58);


            Assert.Equal("LVIII", result);
        }

        [Fact]
        public void Test3()
        {
            string result = new Lib.Problem0012.Solution().IntToRoman(1994);


            Assert.Equal("MCMXCIV", result);
        }

        [Fact]
        public void Test4()
        {
            string result = new Lib.Problem0012.Solution().IntToRoman(10);


            Assert.Equal("X", result);
        }
    }
}