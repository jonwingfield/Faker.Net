using System;
using System.Text.RegularExpressions;
using NUnit.Framework;
using Faker;

namespace Faker.Tests
{
	[TestFixture]
	public class GeoLocationTests
	{
		[Test]
		public void TestLat()
		{
			Assert.IsTrue(Regex.IsMatch(GeoLocation.Lat().ToString(), "[0-9]+"));
		}

		[Test]
		public void TestLng()
		{
			Assert.IsTrue(Regex.IsMatch(GeoLocation.Lng().ToString(), "[0-9]+"));
		}
	}
}