using CodeWars.TheStringCombat;
using NUnit.Framework;
// ReSharper disable InconsistentNaming

namespace CodeWars.Tests.TheStringCombat
{
	[TestFixture]
	public class DuelTests
	{
		[Test]
		[TestCase("a", "c", "Winner: s2(a)")]
		[TestCase("abc", "ab", "Winner: s1(c)")]
		[TestCase("boy", "girl", "Winner: s2(fl)")]
		[TestCase("a", "a", "Draw")]
		[TestCase("ab", "ab", "Draw")]
		[TestCase("dog", "cat", "Draw")]
		public void Duel(string left, string right, string result)
		{
			var duelDecider = new DuelDecider(left, right);

			var actualResult = duelDecider.Decide();

			Assert.AreEqual(result, actualResult);
		}
	}
}