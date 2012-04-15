using System.Text.RegularExpressions;
using NUnit.Framework;

namespace Faker.Tests
{
	[TestFixture]
	public class InternetTests
	{
		[Test]
		public void TestEmail()
		{
			Assert.IsTrue(Regex.IsMatch(Internet.GetEmail(), @".+@.+\.\w+"));
		}
		
		[Test]
		public void TestFreeEmail()
		{
			Assert.IsTrue(Regex.IsMatch(Internet.GetFreeEmail(), @".+@(gmail|hotmail|yahoo)\.com"));
		}
		
		[Test]
		public void TestDisposableEmail()
		{
			Assert.IsTrue(Regex.IsMatch(Internet.GetDisposableEmail(), @".+@(mailinator\.com|suremail\.info|spamherelots\.com|binkmail\.com|safetymail\.info)"));
		}
		
		[Test]
		public void TestUserName()
		{
			Assert.IsTrue(Regex.IsMatch(Internet.GetUserName(), @"[a-z]+((_|\.)[a-z]+)?"));
		}
		
		[Test]
		public void TestUserNameWithArg()
		{
			Assert.IsTrue(Regex.IsMatch(Internet.GetUserName("bo peep"), @"(bo(_|\.)peep|peep(_|\.)bo)"));
		}
		
		[Test]
		public void TestDomainName()
		{
			Assert.IsTrue(Regex.IsMatch(Internet.GetDomainName(), @"\w+\.\w+"));
		}
		
		[Test]
		public void TestDomainWord()
		{
			Assert.IsTrue(Regex.IsMatch(Internet.GetDomainWord(), @"^\w+$"));
		}
		
		[Test]
		public void TestDomainSuffix()
		{
			Assert.IsTrue(Regex.IsMatch(Internet.GetDomainSuffix(), @"^\w+(\.\w+)?"));
		}
		
		[Test]
		public void TestUri()
		{
			Assert.IsTrue(Regex.IsMatch(Internet.GetUri("ftp"), @"^ftp:\/\/.+"));
			Assert.IsTrue(Regex.IsMatch(Internet.GetUri("http"), @"^http:\/\/.+"));
			Assert.IsTrue(Regex.IsMatch(Internet.GetUri("https"), @"^https:\/\/.+"));
		}
		
		[Test]
		public void TestHttpUrl()
		{
			Assert.IsTrue(Regex.IsMatch(Internet.GetHttpUrl(), @"^http:\/\/.+"));
		}
		
		[Test]
		public void TestIP_V4_Address()
		{
			Assert.IsTrue(Regex.IsMatch(Internet.GetIP_V4_Address(), @"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}"));
		}
	}
}