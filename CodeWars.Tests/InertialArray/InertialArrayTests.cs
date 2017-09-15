using System;
using CodeWars.InertialArray;
using NUnit.Framework;
// ReSharper disable InconsistentNaming

namespace CodeWars.Tests.InertialArray
{
	[TestFixture]
	public class InertialArrayTests
	{
		[Test]
		[TestCase(new int[0], false)]
		[TestCase(new[] { 4, 20, 2, 8 }, false)]
		[TestCase(new[] { 11, 4, 21, 9, 2, 8 }, false)]
		[TestCase(new[] { 11, 4, 20, 7, 2, 8 }, false)]
		[TestCase(new[] { 11, 4, 20, 9, 2, 8 }, true)]
		public void InnertialTests(int[] input, bool result)
		{
			Console.WriteLine(input.Length);
			var inertialTester = new InertialTester(input);

			Assert.AreEqual(result, inertialTester.IsInertial());
		}
	}
}