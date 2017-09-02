using System;
using CodeWars.TheStringCombat;
using NUnit.Framework;

namespace CodeWars.Tests.TheStringCombat
{
	[TestFixture]
	public class InputConverterTests
	{
		[Test]
		public void ShouldConvertLowerCaseAToAppropriateValue()
		{
			const string input = "a";

			var output = InputConverter.Convert(input);

			Assert.AreEqual(new[] { 1 }, output);
		}

		[Test]
		public void ShouldConvertUpperCaseAToAppropriateValue()
		{
			const string input = "A";

			var output = InputConverter.Convert(input);

			Assert.AreEqual(new[] { 27 }, output);
		}

		[Test]
		public void ShouldConvertAlleLettersToAppropriateValues()
		{
			var input = Helpers.GenerateAllLetters();

			var output = InputConverter.Convert(input);

			Assert.AreEqual(Helpers.GenerateAllNumberValuesForLetters(), output);
		}

		[Test]
		public void ShouldThrowErrorForInvalidInput()
		{
			const string input = "-";

			Assert.Throws<ArgumentException>(() => InputConverter.Convert(input));
		}
	}
}