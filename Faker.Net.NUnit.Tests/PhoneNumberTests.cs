using System;
using System.Text.RegularExpressions;
using NUnit.Framework;
using Faker;

namespace Faker.Tests
{
	[TestFixture]
	public class PhoneNumberTests
	{
		[Test]
		public void TestPhoneNumber()
		{
			Assert.IsTrue(Regex.IsMatch(PhoneNumber.phone_number(), @"\d{3}[. -]\d{3}"));
		}
		
		[Test]
		public void TestShortPhoneNumber()
		{
			Assert.IsTrue(Regex.IsMatch(PhoneNumber.ShortPhoneNumber(), @"\d{3}-\d{3}-\d{4}"));
		}
	}
}

