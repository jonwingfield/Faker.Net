using System.Text.RegularExpressions;
using NUnit.Framework;

namespace Faker.Tests
{
	[TestFixture]
	public class CompanyTests
	{
		[Test]
		public void TestBS()
		{
			Assert.IsTrue(Regex.IsMatch(Company.GetBS(), @"[ a-z]+"));
			Assert.IsTrue(Regex.IsMatch(Company.GetBS(), @"\s"));
		}
		
		[Test]
		public void TestCatchPhrase()
		{
			Assert.IsTrue(Regex.IsMatch(Company.GetCatchPhrase(), @"[ a-z]+"));
			Assert.IsTrue(Regex.IsMatch(Company.GetCatchPhrase(), @"\s"));
		}
		
		[Test]
		public void TestName()
		{
			Assert.IsTrue(Regex.IsMatch(Company.GetName(), @"[ a-z]+"));
		}
		
		[Test]
		public void TestSuffix()
		{
			Assert.IsTrue(Regex.IsMatch(Company.GetSuffix(), @"[ a-z]+"));
		}
	}
}