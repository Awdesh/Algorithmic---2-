using System;

namespace HomePractice
{
	public class MergeTwoSorted
	{
		public MergeTwoSorted ()
		{
		}

		public void merge(int[] A, int[] B, int M)
		{
			int K = 2 * M -1;
			int i = M-1;
			int j = M-1;

			while(K>0 && M > 0)
			{
				if(A[i] > B[j])
				{
					B[K] = A[M];
				}
				else
				{
					B[K] = B[M];
				}
				K--;
				M--;
			}
		}
	}
}

