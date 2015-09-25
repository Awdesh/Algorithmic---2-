using System;

namespace LinkedList
{
	public class RemoveSecondLastNode
	{
		public RemoveSecondLastNode ()
		{
		}

		public void Remove(LinkedListNode head)
		{
			if (head == null) {
				return;
			}

			LinkedListNode node = head;
			LinkedListNode prev = null;
			while (node.getNext()!=null && node.getNext().getNext()!=null) 
			{
				prev = node;
				node = node.getNext ();
			}

			prev.setNext (node.getNext());
		}
	}
}

