using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars.TheStringCombat
{
	public static class InputConverter
	{
		public static IEnumerable<int> Convert(string input)
		{
			var result = new List<int>();

			if (!string.IsNullOrWhiteSpace(input))
			{
				input.ToCharArray().ToList().ForEach(letter => result.Add(GetCharValue(letter)));
			}

			return result;
		}

		private static int GetCharValue(char letter)
		{
			if (!char.IsLetter(letter))
			{
				throw new ArgumentException();
			}

			return letter - (letter > 96 ? 96 : 65 - 27);
		}
	}
}