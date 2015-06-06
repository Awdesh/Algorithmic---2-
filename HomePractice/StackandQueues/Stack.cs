using System;

namespace StackandQueues
{
	public class Stack
	{
		private int size;
		private int min = 0;
		private int max = 0;
		private const int MAX_SIZE = 10;
		private int[] items;
		public Stack (int size)
		{
			items = new int[size];
		}

		public int Count()
		{
			return size;
		}

		public void Push(int num)
		{
			if (size == MAX_SIZE) {
				Console.WriteLine ("Stack is Full");
				return;
			}
//			items [size] = num;
//			// size = 0 suggest for the very first time.
//			if (items [size] < min || size == 0) {
//				min = items [size];
//			}

			int num1 = Peek();
			if (num1 > num) {
				items [size - 1] = num;
				items [size] = num1;
			} else {
				items [size] = num;
			}
			size += 1;
		}

		public int Pop()
		{
			if (size <= 0) {
				Console.WriteLine ("Stack is Empty");
				return 0;
			}
			int item = items [size - 1];
			Delete ();
			return item;
		}
		

		public int Min()
		{
			return min;
		}

		public int Max()
		{
			return Peek();
		}

		public int Peek()
		{
			if (size <= 0) {
				Console.WriteLine ("Stack is Empty");
				return 0;
			}
			return items [size - 1];
		}

		public void Delete()
		{
			items [size - 1] = 0;
			size -= 1;
		}

		public bool isEmpty()
		{
			return size > 0 ? false : true;
		}
	}

	class Node
	{
		public Object item = null;
		private Node next = null;
		public Node(Object item)
		{
			this.item = item;
		}

		public void setNext(Node n)
		{
			this.next = n;
		}

		public Node getNext()
		{
			return next;
		}
	}

	class GenericStack
	{
		Node top;

		public void Push(Object item)
		{
			Node n = new Node (item);
			n.item = item;
			n.setNext (top);
			top = n;
		}

		public Object Pop()
		{
			if (top != null) {
				Object data = top.item;
				top = top.getNext ();
				return data;
			}
			return null;
		}
	}

//	class CircularQueue
//	{
//		Node node;
//
//		public void Enqueue(Object item)
//		{
//			Node n = new Node (item);
//			n.item = item;
//			n.setNext
//		}
//
//		public Object Dequeue()
//		{
//
//		}
//	}
}

