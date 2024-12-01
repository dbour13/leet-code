using LeetCode.Lib;

namespace LeetCode.Test.Problem0001
{
    public class SolutionUnitTests
    {
        [Fact]
        public void Test1()
        {
            int[] result = Lib.Problem0001.Solution.TwoSum([2, 7, 11, 15], 9);

            Assert.Equal([0, 1], result);
        }

        [Fact]
        public void Test2()
        {
            int[] result = Lib.Problem0001.Solution.TwoSum([3, 2, 4], 6);

            Assert.Equal([1, 2], result);
        }

        [Fact]
        public void Test3()
        {
            int[] result = Lib.Problem0001.Solution.TwoSum([3, 3], 6);

            Assert.Equal([0, 1], result);
        }

        [Fact]
        public void Test4()
        {
            Assert.Throws<NoSolutionException>(() =>
            {
                _ = Lib.Problem0001.Solution.TwoSum([3, 3], 7);
            });
        }
    }
}