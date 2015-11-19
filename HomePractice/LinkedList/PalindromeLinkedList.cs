using System;

namespace LinkedList
{
	public class PalindromeLinkedList
	{
		public PalindromeLinkedList ()
		{
		}

		public bool IsLinkedListPalindrome(LinkedListNode node)
		{
			LinkedListNode n = FindMiddleNode (node);
			LinkedListNode current = n.getNext ();
			LinkedListNode m = ReverseLinkedList(current);
			// compare first half and second half.
			return CompareLists(node, m);
		}
		
		public boolean CompareLists(LinkedListNode L1, LinkedListNode L2)
		{
			while(L1.getNext() != null && L2.getNext() != null)
			{
				if(L1.getData() != L2.getData())
				{
					return false;
				}
			}
			
			return true;
		}

		public LinkedListNode ReverseLinkedList(LinkedListNode node)
		{
			LinkedListNode prev = null;
			LinkedListNode current = node;
			LinkedListNode next;
			while (current.getNext()!=null) {
				next = current.getNext ();
				current.getNext () = prev;
				prev = current;
				current = next;
			}
	           return node;
		}

		public LinkedListNode FindMiddleNode(LinkedListNode head)
		{
			if (head == null)
				return head;
			LinkedListNode slow;
			LinkedListNode fast;
			slow = head;
			fast = head;
			fast = fast.getNext ();
			while (fast!=null) {
				fast = fast.getNext ();
				slow = slow.getNext ();
			}
			return slow;
		}
	}
}

