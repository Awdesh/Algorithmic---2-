using System;

namespace HomePractice
{
	public class SecondLargest
	{
		public SecondLargest ()
		{
		}

		/// <summary>
		/// Finds the second largest.
		/// </summary>
		/// <returns>The second largest.</returns>
		/// <param name="arr">Arr.</param>
		public int FindSecondLargest(int[] arr)
		{
			int largest = 0;
			int max = arr [0];
			for (int i = 1; i < arr.Length; i++) {
				if (max < arr [i]) {
					max = arr [i];
				}
			}
			int diff = max - arr [0];
			for (int i = 1; i < arr.Length; i++) {
				if (max != arr [i]) {
					if(diff > (max-arr[i])){
						diff = max - arr[i];
						largest = arr [i];
					}
				}
			}
			return largest;
		}

		/// <summary>
		/// Finds the second largest single pass.
		/// </summary>
		/// <returns>The second largest single pass.</returns>
		/// <param name="arr">Arr.</param>
		public int FindSecondLargestSinglePass(int[] arr)
		{
			int largest = 0;
			int secondLargest = 0;
			for (int i = 0; i<arr.Length; i++) {
				if (largest < arr [i]) {
					// put last value of largest into secondLargest.
					secondLargest = largest;
					largest = arr [i];
				}
				// This is going to be used when element encountered is less than element before, since its an unsorted array.
				else if(arr[i] > secondLargest){
					secondLargest  = arr[i];
				}
			}
			return secondLargest;
		}
	}
}

