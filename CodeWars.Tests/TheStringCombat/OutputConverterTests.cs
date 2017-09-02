using System;
using CodeWars.TheStringCombat;
using NUnit.Framework;

namespace CodeWars.Tests.TheStringCombat
{
	[TestFixture]
	public class OutputConverterTests
	{
		[Test]
		public void ShouldConvertNumberToProperValue()
		{
			var input = new [] { 1 };

			var output = OutputConverter.Convert(input);

			Assert.AreEqual("a", output);
		}

		[Test]
		public void ShouldConvertUpperCaseAToAppropriateValue()
		{
			var input = new[] { 27 };

			var output = OutputConverter.Convert(input);

			Assert.AreEqual("A", output);
		}

		[Test]
		public void ShouldConvertAlleLettersToAppropriateValues()
		{
			var input = Helpers.GenerateAllNumberValuesForLetters();

			var output = OutputConverter.Convert(input);

			Assert.AreEqual(Helpers.GenerateAllLetters(), output);
		}

		[Test]
		public void ShouldThrowErrorForInvalidInput()
		{
			var input = new[] { 0 };

			Assert.Throws<ArgumentException>(() => OutputConverter.Convert(input));
		}
	}
}