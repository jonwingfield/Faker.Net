using System;

namespace Faker
{
    public static class FakerRandom
    {
        internal static Random Rand = new Random();

        public static void Seed(int seed)
        {
            Rand = new Random(seed);
        }
    }
}
