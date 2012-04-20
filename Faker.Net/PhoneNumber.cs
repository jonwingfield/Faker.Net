using System;
using Faker.Extensions;

namespace Faker
{
    public static class PhoneNumber
    {
        public static string GetPhoneNumber()
        {
            return FormatPhoneNumber().Numerify();
        }
        
        private static string FormatPhoneNumber()
        {
            switch (FakerRandom.Rand.Next(20))
            {
                case 0: return "###-###-#### x#####";
                case 1: return "###-###-#### x####";
                case 2: return "###-###-#### x###";
                case 3:
                case 4: return "###-###-####";
                case 5: return "###.###.#### x#####";
                case 6: return "###.###.#### x####";
                case 7: return "###.###.#### x###";
                case 8:
                case 9: return "###.###.####";
                case 10: return "(###)###-#### x#####";
                case 11: return "(###)###-#### x####";
                case 12: return "(###)###-#### x###";
                case 13:
                case 14: return "(###)###-####";
                case 15: return "1-###-###-#### x#####";
                case 16: return "1-###-###-#### x####";
                case 17: return "1-###-###-#### x###";
                case 18:
                case 19: return "1-###-###-####";
                default: throw new ApplicationException();
            }
        }

        public static string GetShortPhoneNumber()
        {
            return "###-###-####".Numerify();
        }
		
		[Obsolete]
        public static string phone_number()
        {
			return GetPhoneNumber();
        }
        
		[Obsolete]
        public static string ShortPhoneNumber()
        {
			return GetShortPhoneNumber();
        }
    }
}
