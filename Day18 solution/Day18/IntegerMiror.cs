using System;
namespace Day18
{
	public static class IntegerMiror
	{
		public static int Miror(this int number)
		{
			int result = 0, rem;
			while(number != 0)
			{
				rem = number % 10;
				result = result * 10 + rem;
				number = number / 10;
			}
			return result;
		}
	}
}

