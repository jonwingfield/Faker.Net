using System;
using System.Text.RegularExpressions;
using NUnit.Framework;
using Faker;

namespace Faker.Tests
{
	[TestFixture]
	public class AddressTests
	{
		[Test]
		public void TestCity()
		{
			Assert.IsTrue(Regex.IsMatch(Address.City(), @"[ a-z]+"));
		}
		
		[Test]
		public void TestCityPrefix()
		{
			Assert.IsTrue(Regex.IsMatch(Address.CityPrefix(), @"[ a-z]"));
		}
		
		[Test]
		public void TestCitySuffix()
		{
			Assert.IsTrue(Regex.IsMatch(Address.CitySuffix(), @"[ a-z]"));
		}
		
		[Test]
		public void TestSecondaryAddress()
		{
			Assert.IsTrue(Regex.IsMatch(Address.SecondaryAddress(), @"[ a-z]"));
		}
		
		[Test]
		public void TestStreetAddress()
		{
			Assert.IsTrue(Regex.IsMatch(Address.StreetAddress(), @"[ a-z]"));
		}
		
		[Test]
		public void TestStreetName()
		{
			Assert.IsTrue(Regex.IsMatch(Address.StreetName(), @"[ a-z]"));
		}
		
		[Test]
		public void TestStreetSuffix()
		{
			Assert.IsTrue(Regex.IsMatch(Address.StreetSuffix(), @"[ a-z]"));
		}
		
		[Test]
		public void TestUKCountry()
		{
			Assert.IsTrue(Regex.IsMatch(Address.UKCounty(), @"[ a-z]"));
		}
		
		[Test]
		public void TestUKCounty()
		{
			Assert.IsTrue(Regex.IsMatch(Address.UKCounty(), @"[ a-z]"));
		}
		
		[Test]
		public void TestUKPostcode()
		{
			Assert.IsTrue(Regex.IsMatch(Address.UKPostcode(), @"[ a-z]"));
		}
		
		[Test]
		public void TestUSState()
		{
			Assert.IsTrue(Regex.IsMatch(Address.USState(), @"[ a-z]"));
		}
		
		[Test]
		public void TestUSStateAbbr()
		{
			Assert.IsTrue(Regex.IsMatch(Address.USStateAbbr(), @"[A-Z]"));
		}
		
		[Test]
		public void TestUSZipCode()
		{
			Assert.IsTrue(Regex.IsMatch(Address.ZipCode(), @"[0-9]"));
		}
		
		[Test]
		public void TestNeighborhood()
		{
			Assert.IsTrue(Regex.IsMatch(Address.Neighborhood(), @"[ a-z]+"));
		}
	}
}