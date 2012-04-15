using System;
using System.Text.RegularExpressions;
using NUnit.Framework;
using Faker;

namespace Faker.Tests
{
	[TestFixture]
	public class CompanyTests
	{
		[Test]
		public void TestBS()
		{
			Assert.IsTrue(Regex.IsMatch(Company.BS(), @"[ a-z]+"));
			Assert.IsTrue(Regex.IsMatch(Company.BS(), @"\s"));
		}
		
		[Test]
		public void TestCatchPhrase()
		{
			Assert.IsTrue(Regex.IsMatch(Company.CatchPhrase(), @"[ a-z]+"));
			Assert.IsTrue(Regex.IsMatch(Company.CatchPhrase(), @"\s"));
		}
		
		[Test]
		public void TestName()
		{
			Assert.IsTrue(Regex.IsMatch(Company.name(), @"[ a-z]+"));
		}
		
		[Test]
		public void TestSuffix()
		{
			Assert.IsTrue(Regex.IsMatch(Company.Suffix(), @"[ a-z]+"));
		}
	}
}