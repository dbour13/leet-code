using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Lib
{
    public class NoSolutionException : Exception
    {
        public NoSolutionException() : base() { }

        public NoSolutionException(string? message) : base(message) { }
    }
}
