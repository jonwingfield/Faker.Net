using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
