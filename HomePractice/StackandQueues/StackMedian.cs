using System;

namespace StackandQueues
{
	public class StackMedian
	{
		private int[] arr;
		private int size;
		private int maxSize;
		private int median = 0;
		public StackMedian(int length)
		{
			arr = new int[length];

			size = 0;
			maxSize = length;

		}

//		// O(nlogn)
//		public int[] Sort(int[] arr)
//		{
//			int[] arr1 = Array.Sort(arr);
//			return arr1;
//		}

		public int CalculateMedian(int length)
		{
			Array.Sort(arr);
			if(length % 2 == 0)
				median = (arr[length / 2 - 1] + arr[length /2] )/ 2;
			else
				median = arr[length / 2];
			return median;
		}

		public void Push(int num)
		{
			if(size <= maxSize )
			{ 
				arr[size] = num;
				size++;
				if(size == maxSize - 1)
				{
					median = CalculateMedian (size);
					arr[size] = median;
					//return;
				}

			}
			else
			{
				Console.WriteLine("Stack is Full");
			}
		}

		public int Pop()     
		{
			if (size > 0) {
				size--;
				return arr [size];
			} else {
				Console.WriteLine ("Stack is Empty");
				return -1;
			}
		}

		public int Median()
		{
			return median;
		}
	}
}

