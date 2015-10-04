using System;

namespace HomePractice
{
	public class PrintDifference
	{
		public PrintDifference ()
		{
		}

		public static int Difference(int[,] A, int N)
		{int MainSum = 0;
			for(int a = 0; a < N; a++)
			{
				MainSum += A[a,a] ;
			}

			int OtherSum = 0;
			int c = 0;
			for(int b = N - 1; b >= 0; b--)
			{
				OtherSum += A[c,b] ;
				c++;
			}

			int diff = Math.Abs(MainSum - OtherSum);
			return diff;
		}
	}
}

