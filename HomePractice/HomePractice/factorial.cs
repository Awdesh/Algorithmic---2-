using System;

namespace HomePractice
{
	public class factorial
	{
		public factorial ()
		{
		}

		public int CalculateFactorial(int num)
		{
			if (num == 0 || num == 1) {
				return 1;
			}
			return num * CalculateFactorial (num - 1);
		}
	}
}

