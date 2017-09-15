namespace CodeWars.InertialArray.Helpers
{
	public static class IntegerExtensions
	{
		public static bool IsEven(this int input)
		{
			return input % 2 == 0;
		}

		public static bool IsOdd(this int input)
		{
			return !IsEven(input);
		}
	}
}