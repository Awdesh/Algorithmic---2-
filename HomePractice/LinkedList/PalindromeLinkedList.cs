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
			LinkedListNode m = SwapLinkedList(current);

			return false;
		}

		public LinkedListNode SwapLinkedList(LinkedListNode node)
		{
			LinkedListNode current = node;
			int temp;
			while (current.getNext()!=null) {
				temp = current.getNext ().getData();
				current.getNext ().setData(current.getNext ().getNext ().getData());
				current.getNext ().getNext ().setData(temp);
				current = current.getNext ();
			}
			return node;

//			LinkedListNode prev = current;
//			LinkedListNode next;
//			while (current.getNext()!=null) {
//				next = current.getNext ();
//				current.getNext () = prev;
//				prev = current;
//				current = next;
//			}
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

