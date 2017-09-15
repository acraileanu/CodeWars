using System.Linq;
using CodeWars.InertialArray.Validators;
using CodeWars.InertialArray.Validators.Abstract;

namespace CodeWars.InertialArray
{
	public class InertialTester
	{
		private static readonly IIntegerEnumerationValidator[] Validators =
		{
			new IntegerEnumerationContainsAtLeastOneOddValueValidator(),
			new MaximumValueOfIntegerEnumerationIsEven(),
			new EveryOddInIntegerEnumerationIsGreaterThanEveryEvenExceptMaximum()
		};

		private readonly int[] _input;

		public InertialTester(int[] input)
		{
			_input = input;
		}

		public bool IsInertial()
		{
			return Validators.All(validator => validator.IsValid(_input));
		}
	}
}