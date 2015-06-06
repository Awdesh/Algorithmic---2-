using System;

namespace HomePractice
{
	public class FindSumOfDivisibles
	{
		public FindSumOfDivisibles ()
		{
		}
		public int FindSum(int num)
		{
			int sum = 0;
			int sum1 = 0;
			for( int i = 1; i < 1000; i++)
			{
				if(i % 3 == 0 || i%5 == 0)
				{
					sum = sum + i;
				}
			}
			return sum;
		}

	}
}

