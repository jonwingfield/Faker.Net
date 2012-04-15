using System;
using System.Text.RegularExpressions;
using NUnit.Framework;
using Faker;

namespace Faker.Tests
{
	[TestFixture]
	public class NameTests
	{
		[Test]
		public void TestName()
		{
			Assert.IsTrue(Regex.IsMatch(Name.name(), @"(\w+\.?) (\w+)( \w+)?"));
		}
		
		[Test]
		public void TestPrefix()
		{
			Assert.IsTrue(Regex.IsMatch(Name.Prefix(), @"[A-Z][a-z]+\.?"));
		}
		
		[Test]
		public void TestSuffix()
		{
			Assert.IsTrue(Regex.IsMatch(Name.Suffix(), @"[A-Z][a-z]*\.?"));
		}
	}
}