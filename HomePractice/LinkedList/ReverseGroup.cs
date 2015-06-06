using System;

namespace LinkedList
{
	public class ReverseGroup
	{
		public ReverseGroup ()
		{
		}

		public LinkedListNode ReverseInGroup(LinkedListNode head, int k)
		{
			int count = 0;
			LinkedListNode prev = null;
			LinkedListNode curr = head;
			LinkedListNode next = head;

			while (k > count && curr != null) {
				next = curr.getNext ();
				curr.setNext (prev);
				prev = curr;
				curr = next;
				count++;
			}

			if (next != null) 
			{
				head.setNext (ReverseInGroup (next, k));
			}

			return prev;
		}
	}
}

