using System;

namespace Sorting
{
	public class HeapSort
	{
		public HeapSort ()
		{
		}

		private static int N = 0;
		public static int[] Sort(int[] input)
		{
			buildHeap (input);
			for (int i = N; i >0; i --) {
				swap (input, 0, i);
				N = N - 1;
				MaxHeapify (input, 0);
			}
			return input;
		}

		/* Function to build a heap */   
		public static void buildHeap(int[] arr)
		{
			N = arr.Length-1;
			for (int i = N/2; i >= 0; i--)
				MaxHeapify(arr, i);        
		}

		/*Function to swap largest element in heap.*/
		private static void MaxHeapify(int[] input, int index)
		{
			int left = 2 * index + 1;
			int right = 2 * index + 2;
			int largest = index;
			if (input [left] > input [index] && left <= N) {
				largest = left;
			} 
			if (input [right] > input [largest] && right <= N) {
				largest = right;
			}
			if (largest != index) {
				swap (input, index, largest);
				MaxHeapify (input, largest);
			}
		}

		private static void swap(int[] arr, int i, int j)
		{
			int tmp = arr [i];
			arr [i] = arr [j];
			arr [j] = tmp;
		}
	}
}

