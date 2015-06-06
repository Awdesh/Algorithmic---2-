using System;

namespace StackandQueues
{
	public class StackUsingLinkedList
	{
		private int size = 0;
		ListNode head;

		public StackUsingLinkedList ()
		{
		}

		public int Count()
		{
			return size;
		}

		public void Push(Object item)
		{
			if (head == null) {
				head = new ListNode (item);
				head.setNext (null);
			} else {
				ListNode current = head;
				while (current.getNext()!=null) {
					current = current.getNext ();
				}
				ListNode newNode = new ListNode (item);
				current.setNext (newNode);
				head = current.getNext ();
			}
			size++;
		}

		public Object Pop()
		{
			if (head != null) {
				size--;
				return head.data;
			}
			return null;
		}
	}
	public class ListNode
	{
		public Object data;
		ListNode next;

		public ListNode(Object data)
		{
			this.data = data;
		}

		public ListNode getNext()
		{
			return next;
		}

		public void setNext(ListNode n)
		{
			this.next = n;
		}
	}

}

