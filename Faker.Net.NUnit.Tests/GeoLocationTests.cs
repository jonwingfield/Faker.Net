using System.Text.RegularExpressions;
using NUnit.Framework;

namespace Faker.Tests
{
	[TestFixture]
	public class GeoLocationTests
	{
		[Test]
		public void TestLat()
		{
			Assert.IsTrue(Regex.IsMatch(GeoLocation.GetLat().ToString(), "[0-9]+"));
		}

		[Test]
		public void TestLng()
		{
			Assert.IsTrue(Regex.IsMatch(GeoLocation.GetLng().ToString(), "[0-9]+"));
		}
	}
}