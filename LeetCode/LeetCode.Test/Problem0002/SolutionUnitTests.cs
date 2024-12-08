using LeetCode.Lib;
using LeetCode.Lib.Common;
using System.Diagnostics.CodeAnalysis;

namespace LeetCode.Test.Problem0002
{
    public class SolutionUnitTests
    {
        [Fact]
        public void Test1()
        {
            ListNode result = new Lib.Problem0002.Solution().AddTwoNumbers(new Lib.Common.ListNode()
            {
                val = 2,
                next = new Lib.Common.ListNode()
                {
                    val = 4,
                    next = new Lib.Common.ListNode()
                    {
                        val = 3
                    }
                }
            },
            new Lib.Common.ListNode()
            {
                val = 5,
                next = new Lib.Common.ListNode()
                {
                    val = 6,
                    next = new Lib.Common.ListNode()
                    {
                        val = 4
                    }
                }
            }
            );

            Assert.Equal(new Lib.Common.ListNode()
            {
                val = 7,
                next = new Lib.Common.ListNode()
                {
                    val = 0,
                    next = new Lib.Common.ListNode()
                    {
                        val = 8
                    }
                }
            }, 
            result,
            new ListNodeComparer());
        }

        [Fact]
        public void Test2()
        {
            ListNode result = new Lib.Problem0002.Solution().AddTwoNumbers(new Lib.Common.ListNode()
            {
                val = 0
            },
            new Lib.Common.ListNode()
            {
                val = 0
            }
            );

            Assert.Equal(new Lib.Common.ListNode()
            {
                val = 0
            },
            result,
            new ListNodeComparer());
        }

        [Fact]
        public void Test3()
        {
            ListNode result = new Lib.Problem0002.Solution().AddTwoNumbers(new Lib.Common.ListNode()
            {
                val = 9,
                next = new Lib.Common.ListNode()
                {
                    val = 9,
                    next = new Lib.Common.ListNode()
                    {
                        val = 9,
                        next = new Lib.Common.ListNode()
                        {
                            val = 9,
                            next = new Lib.Common.ListNode()
                            {
                                val = 9,
                                next = new Lib.Common.ListNode()
                                {
                                    val = 9,
                                    next = new Lib.Common.ListNode()
                                    {
                                        val = 9
                                    }
                                }
                            }
                        }
                    }
                }
            },
            new Lib.Common.ListNode()
            {
                val = 9,
                next = new Lib.Common.ListNode()
                {
                    val = 9,
                    next = new Lib.Common.ListNode()
                    {
                        val = 9,
                        next = new Lib.Common.ListNode()
                        {
                            val = 9
                        }
                    }
                }
            }
            );

            Assert.Equal(new Lib.Common.ListNode()
            {
                val = 8,
                next = new Lib.Common.ListNode()
                {
                    val = 9,
                    next = new Lib.Common.ListNode()
                    {
                        val = 9,
                        next = new Lib.Common.ListNode()
                        {
                            val = 9,
                            next = new Lib.Common.ListNode()
                            {
                                val = 0,
                                next = new Lib.Common.ListNode()
                                {
                                    val = 0,
                                    next = new Lib.Common.ListNode()
                                    {
                                        val = 0,
                                        next = new Lib.Common.ListNode()
                                        {
                                            val = 1
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            },
            result,
            new ListNodeComparer());
        }
    }
}