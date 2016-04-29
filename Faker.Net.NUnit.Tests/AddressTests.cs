using System.Text.RegularExpressions;
using NUnit.Framework;

namespace Faker.Tests
{
	[TestFixture]
	public class AddressTests
	{
		[Test]
		public void TestCity()
		{
			Assert.IsTrue(Regex.IsMatch(Address.GetCity(), @"[ a-z]+"));
		}
		
		[Test]
		public void TestCityPrefix()
		{
			Assert.IsTrue(Regex.IsMatch(Address.GetCityPrefix(), @"[ a-z]"));
		}
		
		[Test]
		public void TestCitySuffix()
		{
			Assert.IsTrue(Regex.IsMatch(Address.GetCitySuffix(), @"[ a-z]"));
		}
		
		[Test]
		public void TestSecondaryAddress()
		{
			Assert.IsTrue(Regex.IsMatch(Address.GetSecondaryAddress(), @"[ a-z]"));
		}
		
		[Test]
		public void TestStreetAddress()
		{
			Assert.IsTrue(Regex.IsMatch(Address.GetStreetAddress(), @"[ a-z]"));
		}
		
		[Test]
		public void TestStreetName()
		{
			Assert.IsTrue(Regex.IsMatch(Address.GetStreetName(), @"[ a-z]"));
		}
		
		[Test]
		public void TestStreetSuffix()
		{
			Assert.IsTrue(Regex.IsMatch(Address.GetStreetSuffix(), @"[ a-z]"));
		}
		
		[Test]
		public void TestUKCountry()
		{
			Assert.IsTrue(Regex.IsMatch(Address.GetUKCountry(), @"[ a-z]"));
		}
		
		[Test]
		public void TestUKCounty()
		{
			Assert.IsTrue(Regex.IsMatch(Address.GetUKCounty(), @"[ a-z]"));
		}
		
		[Test]
		public void TestUKPostcode()
		{
			Assert.IsTrue(Regex.IsMatch(Address.GetUKPostcode(), @"[ a-z]"));
		}
		
		[Test]
		public void TestUSState()
		{
			Assert.IsTrue(Regex.IsMatch(Address.GetUSState(), @"[ a-z]"));
		}
		
		[Test]
		public void TestUSStateAbbr()
		{
			Assert.IsTrue(Regex.IsMatch(Address.GetUSStateAbbr(), @"[A-Z]"));
		}
		
		[Test]
		public void TestUSZipCode()
		{
			Assert.IsTrue(Regex.IsMatch(Address.GetZipCode(), @"[0-9]"));
		}
		
		[Test]
		public void TestNeighborhood()
		{
			Assert.IsTrue(Regex.IsMatch(Address.GetNeighborhood(), @"[ a-z]+"));
		}

        [Test]
        public void TestWorldCountry()
        {
            Assert.IsTrue(Regex.IsMatch(Address.GetCountry(), @"[ a-z]"));
        }
        [Test]
        public void TestAUState()
        {
            Assert.IsTrue(Regex.IsMatch(Address.GetAUState(), @"[ a-z]"));
        }

        [Test]
        public void TestAUStateAbbr()
        {
            Assert.IsTrue(Regex.IsMatch(Address.GetAUStateAbbr(), @"[A-Z]"));
        }

        [Test]
        public void TestAUPostCode()
        {
            Assert.IsTrue(Regex.IsMatch(Address.GetAUPostcode(), @"[0-9]"));
        }
    }
}