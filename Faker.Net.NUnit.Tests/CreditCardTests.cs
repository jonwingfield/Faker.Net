using NUnit.Framework;
using System;

namespace Faker.Tests
{
	[TestFixture()]
	public class CreditCardTests
	{
		
		[ExpectedException( typeof( ArgumentException ) )]
		public void TestInvalidCreditCardType()
		{
			CreditCard.CreditCardNumber ("others");
		}

		[Test()]
		public void TestVisaCreditCardNumber()
		{
			Assert.True (IsValidNumber(CreditCard.CreditCardNumber ("visa")));
		}

		[Test()]
		public void TestMasterCardCreditCardNumber()
		{
			Assert.True (IsValidNumber(CreditCard.CreditCardNumber ("mastercard")));
		}
		[Test()]
		public void TestDinnersClubCreditCardNumber()
		{
			Assert.True (IsValidNumber(CreditCard.CreditCardNumber ("dinersclub")));
		}

		/*validate credicard number */
		private static bool IsValidNumber(string number)
		{
			int[] DELTAS = new int[] { 0, 1, 2, 3, 4, -4, -3, -2, -1, 0 };
			int checksum = 0;
			char[] chars = number.ToCharArray();
			for (int i = chars.Length - 1; i > -1; i--)
			{
				int j = ((int)chars[i]) - 48;
				checksum += j;
				if (((i - chars.Length) % 2) == 0)
					checksum += DELTAS[j];
			}

			return ((checksum % 10) == 0);
		}

	}
}

