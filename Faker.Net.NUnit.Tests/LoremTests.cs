using System;
using System.Text.RegularExpressions;
using NUnit.Framework;
using Faker;
using Faker.Extensions;

namespace Faker.Tests
{
	[TestFixture]
	public class LoremTests
	{
		[Test]
		public void TestParagraph()
		{
			Assert.IsTrue(Regex.IsMatch(Lorem.Paragraph(), @"[ a-z]+"));
		}
		
		[Test]
		public void TestSentence()
		{
			Assert.IsTrue(Regex.IsMatch(Lorem.Sentence(), @"[ a-z]+"));
		}
		
		[Test]
		public void TestWord()
		{
			Assert.IsTrue(Regex.IsMatch(Lorem.Word(), @"[ a-z]+"));
		}
		
		[Test]
		public void TestParagraphs()
		{
			Assert.IsTrue(Regex.IsMatch(Lorem.Paragraphs().Join(" "), @"[ a-z]+"));
		}
		
		public void TestSentences()
		{
			Assert.IsTrue(Regex.IsMatch(Lorem.Sentences().Join(" "), @"[ a-z]+"));
		}
		
		[Test]
		public void TestWords()
		{
			Assert.IsTrue(Regex.IsMatch(Lorem.Words().Join(" "), @"[ a-z]+"));
		}
	}
}