using LeetCode.Lib;
using LeetCode.Lib.Common;
using System.Text.RegularExpressions;

namespace LeetCode.Test.Problem0058
{
    public class SolutionUnitTests
    {
        [Fact]
        public void Test1()
        {
            int result = new Lib.Problem0058.Solution().LengthOfLastWord("Hello World");

            Assert.Equal(5, result);
        }

        [Fact]
        public void Test2()
        {
            int result = new Lib.Problem0058.Solution().LengthOfLastWord("   fly me   to   the moon  ");

            Assert.Equal(4, result);
        }

        [Fact]
        public void Test3()
        {
            int result = new Lib.Problem0058.Solution().LengthOfLastWord("luffy is still joyboy");

            Assert.Equal(6, result);
        }
    }
}