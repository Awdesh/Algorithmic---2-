using System;

namespace LinkedList
{
	public class RemoveNodeOfGivenValue
	{
		public RemoveNodeOfGivenValue ()
		{
		}

		public LinkedListNode RemoveNode(LinkedListNode head, int value)
		{
			if (head == null) {
				return head;
			}
			LinkedListNode prev = null;
			LinkedListNode current = head;
			// Take care of the case where leading nodes are value to be deleted.
			while (current != null && current.getData() == value) {
				prev = current;
				current = current.getNext ();
				head = current;
				prev = null;
			}
			while (current!= null) {
				if (current.getData () == value) {
					prev.setNext (current.getNext ());
					current = null;
					current = prev.getNext ();
				} else {
					prev = current;
					current = current.getNext ();
				}
			}
			return head;
		}

	}
}

