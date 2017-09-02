using CodeWars.TheStringCombat;
using NUnit.Framework;
// ReSharper disable InconsistentNaming

namespace CodeWars.Tests.TheStringCombat
{
	[TestFixture]
	public class DuelTests
	{
		[Test]
		public void AVersusCResultsS2A()
		{
			const string left = "a";
			const string right = "c";
			var duelDecider = new DuelDecider(left, right);

			var result = duelDecider.Decide();

			Assert.AreEqual("Winner: s2(a)", result);
		}

		[Test]
		public void ABCVersusABResultsS1C()
		{
			const string left = "a";
			const string right = "c";
			var duelDecider = new DuelDecider(left, right);

			var result = duelDecider.Decide();

			Assert.AreEqual("Winner: s2(a)", result);
		}

		[Test]
		public void BOYVersusGIRLResultsS2FL()
		{
			const string left = "a";
			const string right = "c";
			var duelDecider = new DuelDecider(left, right);

			var result = duelDecider.Decide();

			Assert.AreEqual("Winner: s2(a)", result);
		}

		[Test]
		public void AVersusAResultsDraw()
		{
			const string left = "a";
			const string right = "a";
			var duelDecider = new DuelDecider(left, right);

			var result = duelDecider.Decide();

			Assert.AreEqual("Draw", result);
		}

		[Test]
		public void ABVersusABResultsDraw()
		{
			const string left = "ab";
			const string right = "ab";
			var duelDecider = new DuelDecider(left, right);

			var result = duelDecider.Decide();

			Assert.AreEqual("Draw", result);
		}

		[Test]
		public void DOGVersusCATResultsDraw()
		{
			const string left = "dog";
			const string right = "cat";
			var duelDecider = new DuelDecider(left, right);

			var result = duelDecider.Decide();

			Assert.AreEqual("Draw", result);
		}
	}
}