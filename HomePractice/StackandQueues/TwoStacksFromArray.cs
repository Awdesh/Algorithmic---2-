using System;

namespace StackandQueues
{
	public class TwoStacksFromArray
	{
		private int[] array;
		int mid = 0;
		int size1 = 0;
		int size2 = 0; 
		public TwoStacksFromArray (int[] array)
		{
			this.array = array;
			mid = 4;// Math.Floor(double(array.Length / 2));
			this.size2 = mid + 1;
		}

		public void CreateStacks()
		{
			for (int i = 0; i <mid; i++) 
			{
				Push1 (array [i]);
			}
			for (int i = mid + 1; i <array.Length;  i++) 
			{
				Push2 (array[i]);
			}
		}

		public void Push1(int num)
		{
			if (size1 <= mid) {
				array [size1] = num;
				size1 += 1;
			}
		}

		public int Pop1()
		{
			if (size1 == 0) {
				return 0;
			}
			size1 -= 1;
			return array [size1];
		}

		public void Push2(int num)
		{
			if (size2 <= array.Length - 1) {
				array [size2] = num;
				size2 += 1;
			}
		}

		public int Pop2()
		{
			if (size2 == 0) {
				return 0;
			}
			size2 -= 1;
			return array [size2];
		}

	}

	public class TwoStacks
	{
		private int[] arr;
		private int size;
		private int maxSize;
		private int top1;
		private int top2;
		public TwoStacks(int length)
		{
			arr = new int[length];
			size = length; 
			top1 = -1;
			top2 = length;
		}

		public void Push1(int num)
		{
			if (top1 < top2 - 1) {
				top1++;
				arr [top1] = num;
			}

		}

		public void Push2(int num)
		{
			if (top1 < top2 - 1) {
				top2--;
				arr [top2] = num;
			}

		}

		public int Pop1()
		{
			if(top1 >= 0)
			{
				int x = arr [top1];
				top1--;
				return x;
			}
			else
			{
				// Stack Overflow.
				return -1;
			}
		}

		public int Pop2()
		{
			if(top2 < size)
			{
				int x = arr [top2];
				top2++;
				return x; 
			}
			else
			{
				// Stack Overflow.
				return -1;
			}
		}

	}
}

