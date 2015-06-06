using System;

namespace MSSelection
{
	public class FindIndexofSwitch
	{
		public FindIndexofSwitch ()
		{
		}

		/// <summary>
		/// Finds the index.
		/// </summary>
		/// <returns>The index.</returns>
		/// <param name="input">Input.</param>
		public int FindIndex(int[] input)
		{
			if (input == null) {
				throw new ArgumentNullException ();
			}

			if (input.Length <= 1) {
				return -1;
			}

			int end = input.Length - 1;
			int start = 0;
			bool IsEven = false;
			bool IsOdd = false;
			while (end >= start) {
				int mid = start + (end - start) / 2;

				if (IsEven && IsOdd) {
					return mid;
				}

				if (input [mid] % 2 == 0) {
					IsEven = true;
					start = mid + 1;
				}

				if (input [mid] % 2 != 0) {
					IsOdd = true;
					end = mid;
				}
			}
			return -1;
		}
	}
}

