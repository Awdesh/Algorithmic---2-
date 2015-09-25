using System;

namespace LinkedList
{
	public class Flatten
	{
		public Flatten ()
		{
		}

		public LinkedListNode FlatternOrder(LinkedListNode head)
		{
			if(head == null)
			{
				return null;
			}

			// node1
			LinkedListNode curr = head;
			LinkedListNode runner = curr; 

			while(runner.getNext() != null)
			{
				// node5
				LinkedListNode n = runner.getNext ();;

				if(runner.child != null)
				{
					curr = runner.child;
					while(curr.getNext() != null || curr.child != null)
					{
						LinkedListNode temp;
						if (curr.getNext () != null) {
							temp = curr.getNext ();
						} else {
							temp = curr;
							while (temp.child!=null) {
								temp.setNext (temp.child);
								temp = temp.child;

							}
							curr = temp;
							break;
						}

						while (curr.child != null) {
							curr = curr.child;
						}

						curr.setNext (temp);
						curr = curr.getNext ();
					}
				}

				runner = curr;
				runner.setNext (n);
				runner = runner.getNext ();
			}
			return head;
		}


		public LinkedListNode FlattenIt(LinkedListNode head)
		{
			if(head == null)
			{
				return head;
			}

			LinkedListNode curr = head;
			LinkedListNode tail = null;
			curr = FindTailNode (curr);

			tail = curr;
			curr = head;

			while(curr.getNext() != null)
			{
				if(curr.child != null)
				{
					tail.setNext(curr.child);
					LinkedListNode child = FindTailNode (curr.child);
					tail = child;
				}

				curr = curr.getNext ();
			}

			return head;
		}

		public LinkedListNode FindTailNode(LinkedListNode node)
		{
			LinkedListNode curr = node;
			while(curr.getNext() != null)
			{
				curr = curr.getNext();
			}
			return curr;
		}
	}
}

