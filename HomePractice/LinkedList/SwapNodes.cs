using System;

namespace LinkedList
{
	public class SwapNodes
	{
		public SwapNodes ()
		{
		}

		public static LinkedListNode Swap(LinkedListNode n)
		{
			LinkedListNode buffer = null;
			LinkedListNode newRoot = null;
			while (n!=null && n.getNext()!=null) {
				if (buffer != null) 
				{
					buffer.getNext ().setNext (n.getNext ());
				}

				buffer = n.getNext ();
				n.setNext (buffer.getNext ().getNext ());

				buffer.setNext (n);

				if (newRoot == null)
				{
					newRoot = buffer;
				}

				n = n.getNext ();
			}

			return newRoot;
		}
	}
}

