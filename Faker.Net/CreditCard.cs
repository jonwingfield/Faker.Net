using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Faker
{
	public class CreditCard
	{
	
		private static string VISA = "VISA";
		private static string MASTER_CARD = "MASTERCARD";
		private static string DINNERS_CLUB = "DINERSCLUB";

		private static string[] DINERS_PREFIX_IIN_RANGES = new[] { "300", "301", "302", "303", "36", "38" };
		private static string[] MASTERCARD_PREFIX_IIN_RANGES = new[]{ "51", "52", "53", "54", "55" };
		private static string[] VISA_PREFIX_IIN_RANGES = new[]{ "4539", "4556", "4916", "4532", "4929", "40240071", "4485", "4716", "4" };

		private static Int16 VISA_LENGTH = 16;
		private static Int16 MASTER_LENGTH = 16;
		private static Int16 DINERS_CLUB_LENGTH = 16;

		public static string CreditCardNumber(string type){
			if (String.IsNullOrEmpty(type)) { throw new ArgumentException("Invalid credit card type"); }

			type = type.ToUpper();

			if (type.Equals(VISA)) 
			{
				return CreateCreditCardNumber(VISA_PREFIX_IIN_RANGES, VISA_LENGTH);
			} 
			else if (type.Equals(MASTER_CARD)) 
			{
				return CreateCreditCardNumber(MASTERCARD_PREFIX_IIN_RANGES, MASTER_LENGTH);
			} 
			else if (type.Equals(DINNERS_CLUB))
			{
				return CreateCreditCardNumber(DINERS_PREFIX_IIN_RANGES, DINERS_CLUB_LENGTH);
			} else {
				throw new ArgumentException("Invalid credit card type");
			}
		}

		private static string FakeCreditCardNumber(string prefix, int length)
		{
			string creditCardNumber = prefix;
			int sum = 0, pos = 0;

			while (creditCardNumber.Length < (length - 1))
			{
				double randomNumber = (new Random().NextDouble() * 1.0f - 0f);
				creditCardNumber += Math.Floor(randomNumber * 10);
			}

			var creditCardNumberReversed = creditCardNumber.ToCharArray().Reverse();
			var creditCardNumbers = creditCardNumberReversed.Select(c => Convert.ToInt32(c.ToString()));

			int[] number = creditCardNumbers.ToArray();

			while (pos < length - 1)
			{
				int odd = number[pos] * 2;
				if (odd > 9) { odd -= 9; }

				sum += odd;

				if (pos != (length - 2)) { sum += number[pos + 1]; }
					
				pos += 2;
			}

			int validDigit = Convert.ToInt32((Math.Floor((decimal) sum/10) + 1)*10 - sum)%10;

			creditCardNumber += validDigit;

			return creditCardNumber;
		}


		private static string CreateCreditCardNumber(string[] prefix, int length)
		{
			int random = new Random().Next(0, prefix.Length - 1);
			if(random > 1) { random --; }
			string creditCardNumber = prefix[random];
			creditCardNumber = FakeCreditCardNumber(creditCardNumber, length);
			return creditCardNumber;
		}
	
	}
}

