using System;

namespace LinkedList
{
	public class ReverseLinkedList
	{
		public ReverseLinkedList ()
		{
		}

		/// <summary>
		/// Recursives the reverse.
		/// </summary>
		/// <returns>The reverse.</returns>
		/// <param name="node">Node.</param>
		/// <param name="prev">Previous.</param>
		public LinkedListNode RecursiveReverse(LinkedListNode current, LinkedListNode prev)
		{
			if (current == null) {
				return prev;
			}
			LinkedListNode lastNode = RecursiveReverse (current.getNext (), current);
			current.setNext (prev);
			return lastNode;
		}

		/// <summary>
		/// Reverse the specified node.
		/// </summary>
		/// <param name="node">Node.</param>
		public LinkedListNode Reverse(LinkedListNode node)
		{
			if (node == null)
				return node;
			LinkedListNode prev = null;
			LinkedListNode temp = node;
			while (temp!=null)
			{
				temp.setNext (prev);
				prev = temp;

				// set temp to next variable.
				temp = temp.getNext();
			}
			return prev;
		}
	}
}

