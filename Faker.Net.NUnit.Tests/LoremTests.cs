using System.Text.RegularExpressions;
using Faker.Extensions;
using NUnit.Framework;

namespace Faker.Tests
{
	[TestFixture]
	public class LoremTests
	{
		[Test]
		public void TestParagraph()
		{
			Assert.IsTrue(Regex.IsMatch(Lorem.GetParagraph(), @"[ a-z]+"));
		}
		
		[Test]
		public void TestSentence()
		{
			Assert.IsTrue(Regex.IsMatch(Lorem.GetSentence(), @"[ a-z]+"));
		}
		
		[Test]
		public void TestWord()
		{
			Assert.IsTrue(Regex.IsMatch(Lorem.GetWord(), @"[ a-z]+"));
		}
		
		[Test]
		public void TestParagraphs()
		{
			Assert.IsTrue(Regex.IsMatch(Lorem.GetParagraphs().Join(" "), @"[ a-z]+"));
		}
		
		public void TestSentences()
		{
			Assert.IsTrue(Regex.IsMatch(Lorem.GetSentences().Join(" "), @"[ a-z]+"));
		}
		
		[Test]
		public void TestWords()
		{
			Assert.IsTrue(Regex.IsMatch(Lorem.GetWords().Join(" "), @"[ a-z]+"));
		}
	}
}