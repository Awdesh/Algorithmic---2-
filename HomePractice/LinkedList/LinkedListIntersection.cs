using System;

namespace LinkedList
{
	public class LinkedListIntersection
	{
		public LinkedListIntersection ()
		{

		}

		/// <summary>
		/// Finds the intersection.
		/// </summary>
		/// <returns>The intersection.</returns>
		/// <param name="L1">L1.</param>
		/// <param name="L2">L2.</param>
		/// O(m+n)
		public int FindIntersection(LinkedListNode L1, LinkedListNode L2)
		{
			LinkedListNode r1 = L1;
			LinkedListNode r2 = L2;
			r1.setVisited (true);
			r2.setVisited (true);
			// remember || operation below inside the while loop.
			while (r1.getNext()!=null || r2.getNext()!=null) {
				r1 = r1.getNext ();

				if (r1.getVisited ())
					return r1.getData ();

				r1.setVisited (true);

				r2 = r2.getNext ();

				if (r2.getVisited ())
					return r2.getData();

				r2.setVisited(true);
			}
			return -1;
		}

		// Another common approach would be to traverse over the linked list and store nodes indside dictionary.
		// For second linked list just traverse that dictionary before and make sure node doesn't resides already.
	}
}

