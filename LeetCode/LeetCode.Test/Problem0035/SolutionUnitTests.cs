using LeetCode.Lib;
using LeetCode.Lib.Common;
using System.Text.RegularExpressions;

namespace LeetCode.Test.Problem0035
{
    public class SolutionUnitTests
    {
        [Fact]
        public void Test1()
        {
            int result = new Lib.Problem0035.Solution().SearchInsert([1, 3, 5, 6], 5);

            Assert.Equal(2, result);
        }

        [Fact]
        public void Test2()
        {
            int result = new Lib.Problem0035.Solution().SearchInsert([1, 3, 5, 6], 2);

            Assert.Equal(1, result);
        }

        [Fact]
        public void Test3()
        {
            int result = new Lib.Problem0035.Solution().SearchInsert([1, 3, 5, 6], 7);

            Assert.Equal(4, result);
        }

        [Fact]
        public void Test4()
        {
            int result = new Lib.Problem0035.Solution().SearchInsert([1], 1);

            Assert.Equal(0, result);
        }

        [Fact]
        public void Test5()
        {
            int result = new Lib.Problem0035.Solution().SearchInsert([1,3], 4);

            Assert.Equal(2, result);
        }
    }
}