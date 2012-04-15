using System;
using System.Collections.Generic;
using System.Linq;

namespace Faker.Extensions
{
    public static class EnumerableExtensions
    {
		public static string Join<T>(this IEnumerable<T> items, string separator)
		{
			return items.Select(i => i.ToString())
						.Aggregate((acc, next) => string.Concat(acc, separator, next));
		}
		
        public static T Rand<T>(this IEnumerable<T> items)
        {
            IList<T> list;
            if (items is IList<T>)
                list = (IList<T>)items;
            else list = items.ToList();

            return list[FakerRandom.Rand.Next(list.Count)];
        }

        public static IEnumerable<T> RandPick<T>(this IEnumerable<T> items, int itemsToTake)
        {
            IList<T> list;
            if (items is IList<T>)
                list = (IList<T>)items;
            else list = items.ToList();

            var rand = FakerRandom.Rand;

            for (int i=0; i<itemsToTake; i++)
                yield return list[rand.Next(list.Count)];
        }

        /// <summary>
        /// From here:
        /// http://stackoverflow.com/questions/375351/most-efficient-way-to-randomly-sort-shuffle-a-list-of-integers-in-c
        /// </summary>
        public static IList<T> Shuffle<T>(this IList<T> array)
        {
            T[] retArray = new T[array.Count];
            array.CopyTo(retArray, 0);

            Random random = FakerRandom.Rand;
            for (int i = 0; i < array.Count; i += 1)
            {
                int swapIndex = random.Next(i, array.Count);
                if (swapIndex != i)
                {
                    T temp = retArray[i];
                    retArray[i] = retArray[swapIndex];
                    retArray[swapIndex] = temp;
                }
            }

            return retArray;
        }
    }
}