using System;

namespace LinkedList
{
	public class SecondLastNode
	{
		public SecondLastNode ()
		{
		}

		public LinkedListNode FindNode(LinkedListNode head)
		{
			if (head == null) {
				return head;
			}

			LinkedListNode prev = null;
			LinkedListNode curr = head;
			while (curr != null && curr.getNext()!=null) {
				prev = curr;
				curr = curr.getNext();
			}
			LinkedListNode node = prev;
			return node;
		}
	}
}

