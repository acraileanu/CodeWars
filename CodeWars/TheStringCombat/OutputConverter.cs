using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars.TheStringCombat
{
	public static class OutputConverter
	{
		public static string Convert(IEnumerable<int> input)
		{
			var result = new StringBuilder();

			var list = input.ToList();
			if (list.Any())
			{
				list.ForEach(value => result.Append(GetCharValue(value)));
			}

			return result.ToString();
		}

		private static char GetCharValue(int value)
		{
			if (OutOfRange(value))
			{
				throw new ArgumentException();
			}

			return (char)(value + (value < 27 ? 96 : 65 - 27));
		}

		private static bool OutOfRange(int value)
		{
			return (value < 1) || (value > 52);
		}
	}
}