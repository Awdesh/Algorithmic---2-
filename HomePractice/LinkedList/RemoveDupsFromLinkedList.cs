using System;

namespace LinkedList
{
	public class RemoveDupsFromLinkedList
	{
		public RemoveDupsFromLinkedList ()
		{
		}

		/// <summary>
		/// Removes the duplicates.
		/// </summary>
		/// <returns>The duplicates.</returns>
		/// <param name="node">Node.</param>
		public LinkedListNode RemoveDuplicates(LinkedListNode node)
		{
			if (node == null)
				return null;
			LinkedListNode next = null;
			LinkedListNode current = node;
			while (current !=null && current.getNext() != null) {

				next = current.getNext ();

				if (current.getData () == next.getData ()) 
				{
					LinkedListNode temp = next.getNext ();
					current.setNext (temp);
				}

				else
				{
					current = next;
				}
			}
			return node;
		}
	}
}

