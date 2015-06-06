using System;

namespace HomePractice
{
	public class dups
	{
		public dups ()
		{
		}

		// Create an array with all unique elements
		public static int[] removeDuplicates(int[] A)
		{
			if (A.Length < 2)
				return A;

			int j = 0;
			int i = 1;

			while (i < A.Length) {
				if (A[i] == A[j]) {
					i++;
				} else {
					j++;
					A[j] = A[i];
					i++;
				}
			}

			int[] B = new int[A.Length]; 
			Array.Copy(A, B, j + 1);

			return B;
		}
	}
}

