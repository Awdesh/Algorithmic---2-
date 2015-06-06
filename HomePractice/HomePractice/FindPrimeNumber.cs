using System;

namespace HomePractice
{
	public class FindPrimeNumber
	{
		public FindPrimeNumber ()
		{
		}

		/// <summary>
		/// Determines whether this instance is prime the specified num.
		/// </summary>
		/// <returns><c>true</c> if this instance is prime the specified num; otherwise, <c>false</c>.</returns>
		/// <param name="num">Number.</param>
		public bool IsPrime( int num)
		{
			if (num < 1) {
				return false;
			}
			if (num % 2 == 0) {
				return false;
			}
			for (int i = 3; i < num; i+= 2) {
				if (num % i == 0) {
					return false;
				}
			}
			return true;
		}
	}
}

