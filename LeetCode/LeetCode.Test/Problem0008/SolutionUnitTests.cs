namespace LeetCode.Test.Problem0008
{
    public class SolutionUnitTests
    {
        [Fact]
        public void Test1()
        {
            int result = new Lib.Problem0008.Solution().MyAtoi("42");

            Assert.Equal(42, result);
        }

        [Fact]
        public void Test2()
        {
            int result = new Lib.Problem0008.Solution().MyAtoi(" -042");

            Assert.Equal(-42, result);
        }

        [Fact]
        public void Test3()
        {
            int result = new Lib.Problem0008.Solution().MyAtoi("1337c0d3");

            Assert.Equal(1337, result);
        }

        [Fact]
        public void Test4()
        {
            int result = new Lib.Problem0008.Solution().MyAtoi("0-1");

            Assert.Equal(0, result);
        }

        [Fact]
        public void Test5()
        {
            int result = new Lib.Problem0008.Solution().MyAtoi("words and 987");

            Assert.Equal(0, result);
        }
    }
}