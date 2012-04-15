using System;
using System.Text.RegularExpressions;
using NUnit.Framework;
using Faker;

namespace Faker.Tests
{
	[TestFixture]
	public class InternetTests
	{
		[Test]
		public void TestEmail()
		{
			Assert.IsTrue(Regex.IsMatch(Internet.Email(), @".+@.+\.\w+"));
		}
		
		[Test]
		public void TestFreeEmail()
		{
			Assert.IsTrue(Regex.IsMatch(Internet.FreeEmail(), @".+@(gmail|hotmail|yahoo)\.com"));
		}
		
		[Test]
		public void TestDisposableEmail()
		{
			Assert.IsTrue(Regex.IsMatch(Internet.DisposableEmail(), @".+@(mailinator\.com|suremail\.info|spamherelots\.com|binkmail\.com|safetymail\.info)"));
		}
		
		[Test]
		public void TestUserName()
		{
			Assert.IsTrue(Regex.IsMatch(Internet.UserName(), @"[a-z]+((_|\.)[a-z]+)?"));
		}
		
		[Test]
		public void TestUserNameWithArg()
		{
			Assert.IsTrue(Regex.IsMatch(Internet.UserName("bo peep"), @"(bo(_|\.)peep|peep(_|\.)bo)"));
		}
		
		[Test]
		public void TestDomainName()
		{
			Assert.IsTrue(Regex.IsMatch(Internet.DomainName(), @"\w+\.\w+"));
		}
		
		[Test]
		public void TestDomainWord()
		{
			Assert.IsTrue(Regex.IsMatch(Internet.DomainWord(), @"^\w+$"));
		}
		
		[Test]
		public void TestDomainSuffix()
		{
			Assert.IsTrue(Regex.IsMatch(Internet.DomainSuffix(), @"^\w+(\.\w+)?"));
		}
		
		[Test]
		public void TestUri()
		{
			Assert.IsTrue(Regex.IsMatch(Internet.Uri("ftp"), @"^ftp:\/\/.+"));
			Assert.IsTrue(Regex.IsMatch(Internet.Uri("http"), @"^http:\/\/.+"));
			Assert.IsTrue(Regex.IsMatch(Internet.Uri("https"), @"^https:\/\/.+"));
		}
		
		[Test]
		public void TestHttpUrl()
		{
			Assert.IsTrue(Regex.IsMatch(Internet.HttpUrl(), @"^http:\/\/.+"));
		}
		
		[Test]
		public void TestIP_V4_Address()
		{
			Assert.IsTrue(Regex.IsMatch(Internet.IP_V4_Address(), @"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}"));
		}
	}
}