using System;

namespace LinkedList
{
	public class SwapEvenNodes
	{
		public SwapEvenNodes ()
		{
		}

		/// <summary>
		/// Swap the specified head.
		/// </summary>
		/// <param name="head">Head.</param>
		public LinkedListNode Swap(LinkedListNode head)
		{
			bool isSet = false;
			int count = 1;
			LinkedListNode curr = head;
			LinkedListNode val1 = null;

			while (curr.getNext() != null) 
			{
				count++;
				if (count % 2 == 0 && isSet == false) {
					val1 = curr.getNext ();
					isSet = true;
				} else if (count % 2 == 0) {
					LinkedListNode val2 = curr.getNext ();
					int tmp = val1.getData();
					val1.setData(val2.getData());
					val2.setData(tmp);
					isSet = false;

				} 
				curr = curr.getNext ();
			}

			return head;
		}
	}
}

