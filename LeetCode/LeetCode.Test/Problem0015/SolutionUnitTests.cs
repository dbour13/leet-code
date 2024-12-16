using LeetCode.Lib;
using LeetCode.Lib.Common;

namespace LeetCode.Test.Problem0015
{
    public class SolutionUnitTests
    {
        [Fact]
        public void Test1()
        {
            IList<IList<int>> result = new Lib.Problem0015.Solution().ThreeSum([-1, 0, 1, 2, -1, -4]);

            Assert.Equal([[-1, -1, 2], [-1, 0, 1]], result, new UnorderedListOfListComparer<int>());
        }
    }
}