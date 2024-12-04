using LeetCode.Lib;

namespace LeetCode.Test.Problem0014
{
    public class SolutionUnitTests
    {
        [Fact]
        public void Test1()
        {
            string result = new Lib.Problem0014.Solution().LongestCommonPrefix(["flower", "flow", "flight"]);

            Assert.Equal("fl", result);
        }

        [Fact]
        public void Test2()
        {
            string result = new Lib.Problem0014.Solution().LongestCommonPrefix(["dog", "racecar", "car"]);

            Assert.Equal("", result);
        }

        [Fact]
        public void Test3()
        {
            string result = new Lib.Problem0014.Solution().LongestCommonPrefix(["ratatat", "", ""]);

            Assert.Equal("", result);
        }
    }
}