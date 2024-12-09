namespace LeetCode.Test.Problem0006
{
    public class SolutionUnitTests
    {
        [Fact]
        public void Test1()
        {
            string result = new Lib.Problem0006.Solution().Convert("PAYPALISHIRING", 3);

            Assert.Equal("PAHNAPLSIIGYIR", result);
        }

        [Fact]
        public void Test2()
        {
            string result = new Lib.Problem0006.Solution().Convert("PAYPALISHIRING", 4);

            Assert.Equal("PINALSIGYAHRPI", result);
        }

        [Fact]
        public void Test3()
        {
            string result = new Lib.Problem0006.Solution().Convert("A", 1);

            Assert.Equal("A", result);
        }
    }
}