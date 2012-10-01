using System;
using NUnit;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace Faker.Tests
{
	[TestFixture]
	public class NameSNTests
	{
		[Test]
		public void TestFirstNameMale ()
		{
			Assert.IsTrue (Regex.IsMatch (NameSN.FirstNameMale, @"\w{2,}"));
			Assert.IsTrue (NameSN.FIRST_NAMES_MALE.Contains (NameSN.FirstNameMale));
		}

		[Test]
		public void TestFirstNameFeMale ()
		{
			Assert.IsTrue (Regex.IsMatch (NameSN.FirstNameFemale, @"\w{2,}"));
			Assert.IsTrue (NameSN.FIRST_NAMES_FEMALE.Contains (NameSN.FirstNameFemale));
		}

		[Test]
		public void TestLastName ()
		{
			Assert.IsTrue (Regex.IsMatch (NameSN.LastName, @"\w{2,}"));
			Assert.IsTrue (NameSN.LAST_NAMES.Contains (NameSN.LastName));
		}		
		
	}
}

