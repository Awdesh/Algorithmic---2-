using System;

namespace LinkedList
{
	public class NthNodeFromLast
	{
		public NthNodeFromLast ()
		{
		}

		public LinkedListNode FindNode(LinkedListNode node, int n)
		{
			if (node == null)
				return null;
			LinkedListNode slow = node;
			LinkedListNode fast = node;

			int count = 0;
			// when we have 2 pointers where 1 is running ahead os second we use .geNext() inside loop condition.
			while (fast.getNext()!=null) {
				fast = fast.getNext ();
				count++;
				if (count >= n) {
					slow = slow.getNext ();
				}
			}
			return slow;
		}
	}
}

