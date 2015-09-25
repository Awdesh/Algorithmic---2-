using System;

namespace HomePractice
{
	public class FindRange
	{
		public FindRange ()
		{
		}

		public int[] Find(int[] arr, int target)
		{
			int start = 0;
			int end = arr.Length - 1;
			int mid = 0;


			while (start <= end) {
				mid = (start + end) / 2;

				if (arr [mid] == target) {
					break;
				} else if (arr [mid] > target) {
					end = mid - 1;
				} else {
					start = mid + 1;
				}
			}

			int startRange = 0;
			int endRange = 0;
			int index = mid;

			while (true) {
				if (arr [mid] == arr [++mid]) {
					endRange = mid;
				} else {
					endRange = --mid;
					break;
				}
			}

			while (true) {
				if (arr [mid] == arr [--mid]) {
					startRange = mid;
				} else {
					startRange = ++mid;
					break;
				}
			}

			int[] newArr = new int[2];
			newArr [0] = startRange;
			newArr [1] = endRange;

			return newArr;
		}
	}
}

