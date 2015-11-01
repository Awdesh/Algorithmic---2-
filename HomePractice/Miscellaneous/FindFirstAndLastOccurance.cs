using System;

namespace Miscellaneous
{
	public class FindFirstAndLastOccurance
	{
		/// <summary>
		/// Find the specified arr and num.
		/// </summary>
		/// <param name="arr">Arr.</param>
		/// <param name="num">Number.</param>
		public int[] Find(int[] arr, int num)
		{
			int[] res = new int[2];
			res[0] = FindFirstOccurance (arr, num);
			res [1] = FindLastOccurance (arr, num);
			return res;
		}

		/// <summary>
		/// Find the specified arr and num.
		/// </summary>
		/// <param name="arr">Arr.</param>
		/// <param name="num">Number.</param>
		public int FindFirstOccurance(int[] arr, int num)
		{
			if (arr.Length <= 0)
				return -1;

			if (arr.Length == 1) {
				if (arr [0] == num)
					return 0;
				else
					return -1;
			}

			int start = 0;
			int end = arr.Length;
			int firstOccurance = 0;

			while (start <= end) {
				int mid = (start + end) / 2;

				if (arr [mid] == num) 
				{
					firstOccurance = mid;
					end = mid - 1;
				}

				else if (arr [mid] > num)
					end = mid - 1;
				else
					start = mid + 1; 
			}
			return firstOccurance;
		}

		/// <summary>
		/// Finds the last occurance.
		/// </summary>
		/// <returns>The last occurance.</returns>
		/// <param name="arr">Arr.</param>
		/// <param name="mid">Middle.</param>
		public int FindLastOccurance(int[] arr, int num)
		{
			if (arr.Length <= 0)
				return -1;

			if (arr.Length == 1) {
				if (arr [0] == num)
					return 0;
				else
					return -1;
			}

			int start = 0;
			int end = arr.Length;
			int lastOccurance = 0;

			while (start <= end) {
				int mid = (start + end) / 2;

				if (arr [mid] == num) 
				{
					lastOccurance = mid;
					start = mid + 1;
				}

				else if (arr [mid] > num)
					end = mid - 1;
				else
					start = mid + 1; 
			}
			return lastOccurance;
		}
	}
}

