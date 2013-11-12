using System;

namespace Faker
{
    public static class FakerRandom
    {
        public static Random Rand = new Random();

        public static void Seed(int seed)
        {
            Rand = new Random(seed);
        }

        public static DateTime GetRandomDateTime()
        {
            return GetRandomDateTime(new DateTime(), DateTime.Now);
        }

        public static DateTime GetRandomDateTime(DateTime from)
        {
            return GetRandomDateTime(from, DateTime.Now);
        }

        public static DateTime GetRandomDateTime(DateTime from, DateTime to)
        {
            var range = to - from;

            var randTimeSpan = new TimeSpan((long)(Rand.NextDouble() * range.Ticks));

            return from + randTimeSpan;
        }
    }
}
