using System.Text.RegularExpressions;
using NUnit.Framework;

namespace Faker.Tests
{
	[TestFixture]
	public class NameTests
	{
		[Test]
		public void TestName()
		{
			Assert.IsTrue(Regex.IsMatch(Name.GetName(), @"(\w+\.?) (\w+)( \w+)?"));
		}
		
		[Test]
		public void TestPrefix()
		{
			Assert.IsTrue(Regex.IsMatch(Name.GetPrefix(), @"[A-Z][a-z]+\.?"));
		}
		
		[Test]
		public void TestSuffix()
		{
			Assert.IsTrue(Regex.IsMatch(Name.GetSuffix(), @"[A-Z][a-z]*\.?"));
		}
	}
}