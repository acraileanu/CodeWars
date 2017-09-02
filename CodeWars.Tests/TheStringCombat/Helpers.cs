using System.Collections.Generic;
using System.Linq;

namespace CodeWars.Tests.TheStringCombat
{
	internal static class Helpers
	{
		internal static string GenerateAllLetters()
		{
			var letters = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (char)i).ToList();
			letters.AddRange(Enumerable.Range('A', 'Z' - 'A' + 1).Select(i => (char)i).ToList());
			return string.Join(string.Empty, letters);
		}

		internal static IEnumerable<int> GenerateAllNumberValuesForLetters()
		{
			return Enumerable.Range(1, 52);
		}
	}
}