using System.Linq;

namespace CodeWars.InertialArray
{
	public class InertialTester
	{
		private readonly int[] _input;

		public InertialTester(int[] input)
		{
			_input = input;
		}

		public bool IsInertial()
		{
			return ContainsAtLeastOneOddValue() &&
				MaximumValueIsEven() &&
				EveryOddIsGreaterThanEveryEvenExceptMaximum();
		}

		private bool ContainsAtLeastOneOddValue()
		{
			return _input.Any(IsOdd);
		}

		private bool MaximumValueIsEven()
		{
			return IsEven(_input.Max());
		}

		private bool EveryOddIsGreaterThanEveryEvenExceptMaximum()
		{
			var maximum = _input.Max();
			return _input.Where(IsOdd).Min() > _input.Where(value => IsEven(value) && (value != maximum)).Max();
		}

		private static bool IsEven(int input)
		{
			return input % 2 == 0;
		}

		private static bool IsOdd(int input)
		{
			return !IsEven(input);
		}
	}
}