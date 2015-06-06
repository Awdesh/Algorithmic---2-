using System;

namespace MSSelection
{
	public class CountingSort
	{
		public CountingSort ()
		{
		}

		/**
 * Counting sort
 * @param array array to be sorted
 * @return array sorted in ascending order
 */
		public int[] CountingSortExample(int[] array)
		{
			// array to be sorted in, this array is necessary
			// when we sort object datatypes, if we don't, 
			// we can sort directly into the input array     
			int[] aux = new int[array.Length];

			// find the smallest and the largest value
			int min = array[0];
			int max = array[0];
			for (int i = 1; i < array.Length; i++)
			{
				if (array[i] < min) min = array[i];
				else if (array[i] > max) max = array[i];
			}

			// init array of frequencies
			int[] counts = new int[max - min + 1];

			// init the frequencies
			for (int i = 0; i < array.Length; i++)
			{
				counts[array[i] - min]++;
			}

			// recalculate the array - create the array of occurences
			counts[0]--;
			for (int i = 1; i < counts.Length; i++)
			{
				counts[i] = counts[i] + counts[i - 1];
			}

			// Sort the array right to the left
			// 1) look up in the array of occurences the last occurence of the given value
			// 2) place it into the sorted array
			// 3) decrement the index of the last occurence of the given value
			// 4) continue with the previous value of the input array (goto: 1), terminate if all values were already sorted
			for (int i = array.Length - 1; i >= 0; i--)
			{
				aux[counts[array[i] - min]--] = array[i];
			}

			return aux;
		}

	}
}

