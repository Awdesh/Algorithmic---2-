using System;

namespace Miscellaneous
{
	public class CountOccuranceOfANumber
	{
		public CountOccuranceOfANumber ()
		{
		}

		/// <summary>
		/// Count the specified A and num. O(logn)
		/// </summary>
		/// <param name="A">A.</param>
		/// <param name="num">Number.</param>
		public int Count(int[] A, int num)
		{
			FindFirstAndLastOccurance f = new FindFirstAndLastOccurance ();
			int first = f.FindFirstOccurance (A, num);
			int last = f.FindLastOccurance (A, num);

			return (last - first + 1);
		}

		/// <summary>
		/// Counts the linear. O(n).
		/// </summary>
		/// <returns>The linear.</returns>
		/// <param name="A">A.</param>
		/// <param name="num">Number.</param>
		public int CountLinear(int[] A, int num)
		{
			int count = 0;
			for (int i = 0; i< A.Length; i++) {
				if (A [i] == num) {
					count++;
				} else {
					break;
				}
			}
			return count;
		}
	}
}

