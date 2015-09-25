using System;

namespace HomePractice
{
	public class factorial
	{
		public factorial ()
		{
		}

		/// <summary>
		/// Calculates the factorial.
		/// </summary>
		/// <returns>The factorial.</returns>
		/// <param name="num">Number.</param>
		public int CalculateFactorial(int num)
		{
			// factorial of 0 is 1.
			if (num == 0 || num == 1) {
				return 1;
			}
			return num * CalculateFactorial (num - 1);
		}
	}
}

