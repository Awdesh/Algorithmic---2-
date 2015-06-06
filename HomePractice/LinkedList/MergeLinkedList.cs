using System;

namespace LinkedList
{
	public class MergeLinkedList
	{
		public MergeLinkedList ()
		{
		}

		/// <summary>
		/// Unsorted merge.
		/// </summary>
		/// <returns>The two linked list.</returns>
		/// <param name="L1">L1.</param>
		/// <param name="L2">L2.</param>
		public LinkedListNode MergeTwoLinkedList(LinkedListNode L1, LinkedListNode L2)
		{
			LinkedListNode fakeHead = new LinkedListNode (0);
			LinkedListNode current = fakeHead;
			int turn = 1;
			while (L1 != null && L2 != null) {
				if (turn == 1) {
					current.setNext (L1);
					L1 = L1.getNext ();
					turn = 2;
				} else {
					current.setNext (L2);
					L2 = L2.getNext ();
					turn = 1;
				}
				current = current.getNext ();
			}
			// this will cover case when L1 has more element than L2.
			while (L1 != null) {
				current.setNext (L1);
				current = current.getNext ();
				L1 = L1.getNext ();
			}
			// this will cover case when L2 has more element than L1.
			while (L2 != null) {
				current.setNext (L2);
				current = current.getNext ();
				L2 = L2.getNext ();
			}
			// get second element, from where it is the actual merge of 2 linked list.
			return fakeHead.getNext();
		}

		/// <summary>
		/// Merges two linked list sorted merge.
		/// </summary>
		/// <returns>The tow linked list sorted merge.</returns>
		/// <param name="L1">L1.</param>
		/// <param name="L2">L2.</param>
		public LinkedListNode MergeTwoLinkedListSortedMerge(LinkedListNode L1, LinkedListNode L2)
		{
			LinkedListNode fakeHead = new LinkedListNode ();
			LinkedListNode current = fakeHead;
			while (L1!=null && L2!=null) {
				if (L1.getData () > L2.getData ()) {
					current.setNext(L1);
					L1 = L1.getNext ();
				} else {
					current.setNext ( L2);
					L2 = L2.getNext ();
				}
				current = current.getNext ();
			}
			// this will cover case when L1 has more element than L2.
			while (L1 != null) {
				current.setNext (L1);
				current = current.getNext ();
				L1 = L1.getNext ();
			}
			// this will cover case when L2 has more element than L1.
			while (L2 != null) {
				current.setNext (L2);
				current = current.getNext ();
				L2 = L2.getNext ();
			}
			return fakeHead.getNext ();
		}
	}
}

