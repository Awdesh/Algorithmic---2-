using System;

namespace Miscellaneous
{
	public class FrequencyOfArrayRotation
	{
		public FrequencyOfArrayRotation ()
		{
		}

		public int CountFrequency(int[] A)
		{
			int start = 0;
			int end = A.Length - 1;
			int N = A.Length;

			// onlly 1 element.
			if (end - start <= 0) {
				return -1;
			}

			// No rotation.
			if (A [start] <= A [end]) {
				return start;
			}

			while (start <= end) {
				int mid = (start + end) / 2;
				int next = (mid + 1) % N;
				int prev = (mid + N - 1) % N;

				//pivot found.
				if (A [mid] <= A [next] && A [mid] <= A [prev]) {
					return mid;
				}
				// 
				else if (A [mid] <= A [end]) {
					end = mid - 1;
				}
				else if (A [mid] >= A [start]) {
					start = mid + 1;
				}
			}

			return -1;
		}
	}
}

