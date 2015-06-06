using System;

namespace LinkedList
{
	public class FindMid
	{
		public FindMid ()
		{
		}

		/// <summary>
		/// Finds the center.
		/// </summary>
		/// <returns>The center.</returns>
		/// <param name="head">Head.</param>
		public LinkedListNode FindCenter(LinkedListNode head)
		{
			if (head == null) {
				return null;
			}
			LinkedListNode slow = head;
			LinkedListNode fast = head;
			while (fast != null && fast.getNext()!=null && slow!=null) {
				fast = fast.getNext().getNext();
				slow = slow.getNext ();
			}
			return slow;
		}
	}
}

