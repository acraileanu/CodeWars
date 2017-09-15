using System.Collections.Generic;
using System.Linq;
using CodeWars.InertialArray.Helpers;
using CodeWars.InertialArray.Validators.Abstract;

namespace CodeWars.InertialArray.Validators
{
	internal class EveryOddInIntegerEnumerationIsGreaterThanEveryEvenExceptMaximum : IIntegerEnumerationValidator
	{
		public bool IsValid(IEnumerable<int> input)
		{
			var enumeration = input as int[] ?? input.ToArray();
			var maximum = enumeration.Max();
			return enumeration.Where(value => value.IsOdd()).Min() > enumeration.Where(value => value.IsEven() && (value != maximum)).Max();
		}
	}
}