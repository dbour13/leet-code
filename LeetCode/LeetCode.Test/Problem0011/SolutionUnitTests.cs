using LeetCode.Lib;

namespace LeetCode.Test.Problem0011
{
    public class SolutionUnitTests
    {
        private int[] Test3Data; 

        public SolutionUnitTests()
        {
            System.IO.StreamReader sr = new StreamReader("Problem0011\\Test3Data.csv");
            Test3Data = sr.ReadToEnd().Split(",").Select(h => Int32.Parse(h)).ToArray();
        }

        [Fact]
        public void Test1()
        {
            int result = new Lib.Problem0011.Solution().MaxArea([1, 8, 6, 2, 5, 4, 8, 3, 7]);

            Assert.Equal(49, result);
        }

        [Fact]
        public void Test2()
        {
            int result = new Lib.Problem0011.Solution().MaxArea([1, 1]);

            Assert.Equal(1, result);
        }

        [Fact]
        public void Test3()
        {
            int result = new Lib.Problem0011.Solution().MaxArea(Test3Data);

            Assert.Equal(705634720, result);
        }
    }
}