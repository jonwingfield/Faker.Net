using System;
using System.Collections.Generic;

namespace Faker.Extensions
{
    public static class NumberExtensions 
    {
        public static IEnumerable<int> To(this int from, int to)
        {
            if (to >= from)
            {
                for (int i = from; i <= to; i++)
                {
                    yield return i;
                }
            }
            else
            {
                for (int i = from; i >= to; i--)
                {
                    yield return i;
                }
            }
        }

        public static IEnumerable<T> Times<T>(this int num, T toReturn)
        {
            for (int i = 0; i < num; i++)
            {
                yield return toReturn;
            }
        }

        public static IEnumerable<T> Times<T>(this int num, Func<int, T> block)
        {
            for (int i = 0; i < num; i++)
            {
                yield return block(i);
            }
        }
    }
}