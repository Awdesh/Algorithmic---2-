using System;

namespace Miscellaneous
{
	public class RemoveDuplicateFromArray_InPlace
	{
		public RemoveDuplicateFromArray_InPlace ()
		{
		}

		/// <summary>
		/// Finds the duplicate from array.
		/// </summary>
		/// <returns>The duplicate from array.</returns>
		/// <param name="array">Array.</param>
		public int FindDuplicateFromArray(int[] array)
		{
			if(array.Length <= 2)
			{
				return array.Length;
			}

			int j = 1;
			int i = 2;
			while( i < array.Length) {
				if (array [i] == array [j]) {
					i++;
				} else {
					j++;
					array [j] = array [i];
					i++;
				}
			}
			return j + 1;
		}

		/// <summary>
		/// Counts the duplicate element from array.
		/// </summary>
		/// <returns>The duplicate element from array.</returns>
		/// <param name="array">Array.</param>
		public int CountDuplicateElementFromArray(int[] array)
		{
			int count = 0;
			int i = 0;
			int j = 1;
			while (i<array.Length) {
				if (array [i] == array [j]) {
					count++;
					j++;
				} 
			}
			return count;
			// return (array.Length - count), this will give count of unique elements.
		}

		// Print only unique elements from array.
//		public int PrintDuplicatesOfArray(int[] array)
//		{
//			int lastUnique = 0;
//			Console.WriteLine ("{0}", array [lastUnique]);
//			for (int i = 0; i<array.Length; i++) {
//				if (array [i] != lastUnique) {
//					Console.WriteLine ("{0}", array [i]);
//					lastUnique = array [i];
//				}
//			}
//		}
	}
}

