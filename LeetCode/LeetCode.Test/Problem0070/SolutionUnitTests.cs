using LeetCode.Lib;
using LeetCode.Lib.Common;
using System.Text.RegularExpressions;

namespace LeetCode.Test.Problem0070
{
    public class SolutionUnitTests
    {
        [Fact]
        public void Test1()
        {
            int result = new Lib.Problem0070.Solution().ClimbStairs(2);

            Assert.Equal(2, result);
        }

        [Fact]
        public void Test2()
        {
            int result = new Lib.Problem0070.Solution().ClimbStairs(40);

            Assert.Equal(165580141, result);
        }
    }
}