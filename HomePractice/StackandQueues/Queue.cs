using System;

namespace StackandQueues
{
	public class Queue
	{
		private int size = 0;
		private int index = 0;
		private const int MAX_SIZE = 100;
		private int[] items = new int[MAX_SIZE];

		public Queue ()
		{
		}

		public int Count()
		{
			return size;
		}

		public void Enqueue(int num)
		{
			if (size == MAX_SIZE) {
				Console.WriteLine ("Queue is Full");
				return;
			}
			items [size] = num;
			size += 1;
		}

		public int Dequeue()
		{
			int item = items [index];
			items [index] = 0;
			index += 1;
//			size = size - index;
			return item;
		}

		public bool IsEmpty()
		{
			return size > 0 ? false : true;
		}

	}
}

