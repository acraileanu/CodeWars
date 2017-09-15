using System.Collections.Generic;
using System.Linq;
using CodeWars.InertialArray.Helpers;
using CodeWars.InertialArray.Validators.Abstract;

namespace CodeWars.InertialArray.Validators
{
	internal class IntegerEnumerationContainsAtLeastOneOddValueValidator : IIntegerEnumerationValidator
	{
		public bool IsValid(IEnumerable<int> input)
		{
			return input.Any(value => value.IsOdd());
		}
	}
}