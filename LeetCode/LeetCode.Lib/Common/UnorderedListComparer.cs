using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Lib.Common
{
    public class UnorderedListOfListComparer<T> : IEqualityComparer<IList<IList<T>>>
    {
        private string GetString(IList<IList<T>>? x)
        {
            return String.Join(",", x.SelectMany(val => val));
        }

        public bool Equals(IList<IList<T>>? x, IList<IList<T>>? y)
        {
            UnorderedListComparer<T> unorderedListComparer = new UnorderedListComparer<T>();

            if (x.Count == y.Count)
            {
                for (int i = 0; i < x.Count; i++)
                {
                    bool isEqual = false;
                    for (int j = 0; j < y.Count; j++)
                    {                        
                        isEqual = unorderedListComparer.Equals(x[i], y[j]); ;
                        break;
                    }

                    if (!isEqual)
                    { 
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }

            return true;
        }

        public int GetHashCode([DisallowNull] IList<IList<T>> obj)
        {
            return GetString(obj).GetHashCode();
        }
    }

    public class UnorderedListComparer<T> : IEqualityComparer<IList<T>>
    {
        private bool TestIfGenericList(Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }

            var interfaceTest = new Predicate<Type>(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IList<>));

            return interfaceTest(type) || type.GetInterfaces().Any(i => interfaceTest(i));
        }

        private string GetString(IList<T>? x)
        {
            return String.Join(",", x);
        }

        public bool Equals(IList<T>? x, IList<T>? y)
        {
            if (x.Count == y.Count)
            {
                return Enumerable.SequenceEqual(x.OrderByDescending(val => val), y.OrderByDescending(val => val));
            }

            return false;
        }

        public int GetHashCode([DisallowNull] IList<T> obj)
        {
            return GetString(obj).GetHashCode();
        }
    }
}
