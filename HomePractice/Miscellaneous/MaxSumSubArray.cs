using System;
using System.Collections.Generic;

namespace Miscellaneous
{
	public class MaxSumSubArray
	{
		public MaxSumSubArray ()
		{
		}

		public int[] FindArray(int[] A)
		{
			int sum = 0;
			int max = Int32.MinValue;
			List<int> list = new List<int> ();

			for (int i = 0; i < A.Length; i++) {
				sum = A [i];

				for(int j = i + 1; j < A.Length; j++)
				{
					sum += A [j];
					if (sum > max) {
						max = sum;
						list.Clear ();
					} else {
						list.Add (j - 1);
						break;
					}
				}
			}

			int size = list [0];
			int[] arr = new int[size + 1];

			for (int i = 0; i <= size; i++) {
				arr [i] = A [i];
			}

			return arr;
		}
	}
}

