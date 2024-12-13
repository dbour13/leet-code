namespace LeetCode.Test.Problem0007
{
    public class SolutionUnitTests
    {
        [Fact]
        public void Test1()
        {
            int result = new Lib.Problem0007.Solution().Reverse(123);

            Assert.Equal(321, result);
        }

        [Fact]
        public void Test2()
        {
            int result = new Lib.Problem0007.Solution().Reverse(-123);

            Assert.Equal(-321, result);
        }

        [Fact]
        public void Test3()
        {
            int result = new Lib.Problem0007.Solution().Reverse(120);

            Assert.Equal(21, result);
        }

    }
}