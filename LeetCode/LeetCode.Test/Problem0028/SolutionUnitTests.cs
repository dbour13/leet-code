using LeetCode.Lib;
using LeetCode.Lib.Common;
using System.Text.RegularExpressions;

namespace LeetCode.Test.Problem0028
{
    public class SolutionUnitTests
    {
        [Fact]
        public void Test1()
        {
            int result = new Lib.Problem0028.Solution().StrStr("sadbutsad", "sad");

            Assert.Equal(0, result);
        }

        [Fact]
        public void Test2()
        {
            int result = new Lib.Problem0028.Solution().StrStr("leetcode", "leeto");

            Assert.Equal(-1, result);
        }
    }
}