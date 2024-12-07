using LeetCode.Lib;
using LeetCode.Lib.Problem0002;
using System.Diagnostics.CodeAnalysis;

namespace LeetCode.Test.Problem0002
{
    public class ListNodeComparer : IEqualityComparer<Lib.Problem0002.ListNode>
    {
        private string GetString(ListNode? x)
        {
            return x.val.ToString() + (x.next != null ? GetString(x.next) : "");
        }

        public bool Equals(ListNode? x, ListNode? y)
        {
            return GetString(x) == GetString(y);
        }

        public int GetHashCode([DisallowNull] ListNode obj)
        {
            return GetString(obj).GetHashCode();
        }
    }

    public class SolutionUnitTests
    {
        [Fact]
        public void Test1()
        {
            Lib.Problem0002.ListNode result = new Lib.Problem0002.Solution().AddTwoNumbers(new Lib.Problem0002.ListNode()
            {
                val = 2,
                next = new Lib.Problem0002.ListNode()
                {
                    val = 4,
                    next = new Lib.Problem0002.ListNode()
                    {
                        val = 3
                    }
                }
            },
            new Lib.Problem0002.ListNode()
            {
                val = 5,
                next = new Lib.Problem0002.ListNode()
                {
                    val = 6,
                    next = new Lib.Problem0002.ListNode()
                    {
                        val = 4
                    }
                }
            }
            );

            Assert.Equal(new Lib.Problem0002.ListNode()
            {
                val = 7,
                next = new Lib.Problem0002.ListNode()
                {
                    val = 0,
                    next = new Lib.Problem0002.ListNode()
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
            Lib.Problem0002.ListNode result = new Lib.Problem0002.Solution().AddTwoNumbers(new Lib.Problem0002.ListNode()
            {
                val = 0
            },
            new Lib.Problem0002.ListNode()
            {
                val = 0
            }
            );

            Assert.Equal(new Lib.Problem0002.ListNode()
            {
                val = 0
            },
            result,
            new ListNodeComparer());
        }

        [Fact]
        public void Test3()
        {
            Lib.Problem0002.ListNode result = new Lib.Problem0002.Solution().AddTwoNumbers(new Lib.Problem0002.ListNode()
            {
                val = 9,
                next = new Lib.Problem0002.ListNode()
                {
                    val = 9,
                    next = new Lib.Problem0002.ListNode()
                    {
                        val = 9,
                        next = new Lib.Problem0002.ListNode()
                        {
                            val = 9,
                            next = new Lib.Problem0002.ListNode()
                            {
                                val = 9,
                                next = new Lib.Problem0002.ListNode()
                                {
                                    val = 9,
                                    next = new Lib.Problem0002.ListNode()
                                    {
                                        val = 9
                                    }
                                }
                            }
                        }
                    }
                }
            },
            new Lib.Problem0002.ListNode()
            {
                val = 9,
                next = new Lib.Problem0002.ListNode()
                {
                    val = 9,
                    next = new Lib.Problem0002.ListNode()
                    {
                        val = 9,
                        next = new Lib.Problem0002.ListNode()
                        {
                            val = 9
                        }
                    }
                }
            }
            );

            Assert.Equal(new Lib.Problem0002.ListNode()
            {
                val = 8,
                next = new Lib.Problem0002.ListNode()
                {
                    val = 9,
                    next = new Lib.Problem0002.ListNode()
                    {
                        val = 9,
                        next = new Lib.Problem0002.ListNode()
                        {
                            val = 9,
                            next = new Lib.Problem0002.ListNode()
                            {
                                val = 0,
                                next = new Lib.Problem0002.ListNode()
                                {
                                    val = 0,
                                    next = new Lib.Problem0002.ListNode()
                                    {
                                        val = 0,
                                        next = new Lib.Problem0002.ListNode()
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