using System;

namespace Tree
{
	public class recursion
	{
		public recursion ()
		{
		}

		public int SumOfNumbers(int n)
		{
			if (n == 1) {
				return 1;
			}
			return (SumOfNumbers (n - 1) + n);;
		}
	}
}

