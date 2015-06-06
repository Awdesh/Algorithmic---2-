using System;

namespace HomePractice
{
	public class fibonacci
	{
		public fibonacci ()
		{
		}
		/// <summary>
		/// fibonacci(4) + fibonnacci(3)
		// (fibonacci(3) + fibonnacci(2)) + (fibonacci(2) + fibonnacci(1))
		//	(((fibonacci(2) + fibonnacci(1)) + ((fibonacci(1) + fibonnacci(0))) + (((fibonacci(1) + fibonnacci(0)) + 1))
		//	((((fibonacci(1) + fibonnacci(0)) + 1) + ((1 + 0)) + ((1 + 0) + 1))
		/// </summary>
		/// <returns>The fibonacci.</returns>
		/// <param name="num">Number.</param>
		public int CalculateFibonacci(int num)
		{
			if (num == 1 || num == 2) {
				return 1;
			}
			return CalculateFibonacci (num - 1) + CalculateFibonacci (num - 2);
		}
	}
}

