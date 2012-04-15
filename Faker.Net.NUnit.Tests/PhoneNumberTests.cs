using System.Text.RegularExpressions;
using NUnit.Framework;

namespace Faker.Tests
{
	[TestFixture]
	public class PhoneNumberTests
	{
		[Test]
		public void TestPhoneNumber()
		{
			Assert.IsTrue(Regex.IsMatch(PhoneNumber.GetPhoneNumber(), @"\d{3}[. -]\d{3}"));
		}
		
		[Test]
		public void TestShortPhoneNumber()
		{
			Assert.IsTrue(Regex.IsMatch(PhoneNumber.GetShortPhoneNumber(), @"\d{3}-\d{3}-\d{4}"));
		}
	}
}

