using System;

namespace LinkedList
{
	class LinkedList
	{
		private LinkedListNode head;

		public void AddFirst(int data)
		{
			LinkedListNode current = new LinkedListNode ();
			current.setData(data);
			current.setNext(head);
			head = current;
		}

		public void AddLast(int data)
		{
			if (head == null) {
				head = new LinkedListNode ();
				head.setData(data);
				head.setNext(null);
			}

			LinkedListNode toAdd = new LinkedListNode ();
			toAdd = head;
			while (toAdd.getNext()!=null) {
				toAdd = toAdd.getNext ();
			}
			toAdd.setData (data);
		}

		public LinkedListNode DeleteNode(LinkedListNode head, int data)
		{
			if (head == null) {
				return head;
			}

			if (head.getData () == data) {
				head = head.getNext ();
				return head;
			}

			LinkedListNode prev;
			LinkedListNode ll = new LinkedListNode ();
			ll = head;
			prev = new LinkedListNode ();

			while (ll !=null) {
				prev = ll;
				ll = ll.getNext ();
				if (ll.getData () == data) {
					prev.setNext (ll.getNext ());
					break;
				}
			}
			return head;
		}

		public static void Main (string[] args)
		{
			LinkedListNode node1 = new LinkedListNode ();
			LinkedListNode node2 = new LinkedListNode ();
			LinkedListNode node3 = new LinkedListNode ();
			LinkedListNode node4 = new LinkedListNode ();
			LinkedListNode node5 = new LinkedListNode ();
			LinkedListNode node6 = new LinkedListNode ();
			node1.setData (1);
			node1.setNext (node2);
			node2.setData (2);
			node2.setNext (node3);
			node3.setData (3);
			node3.setNext (node4);
			node4.setData (4);
			node4.setNext (node5);
			node5.setData (5);
			node5.setNext (node6);
			node6.setData (6);
			node6.setNext (null);

//			SecondLastNode second = new SecondLastNode ();
//			LinkedListNode node = second.FindNode (node1);
//
			ReverseGroup reverse = new ReverseGroup ();
			LinkedListNode n = reverse.ReverseInGroup (node1, 2);


//			RemoveDupsFromLinkedList remove = new RemoveDupsFromLinkedList ();
//			LinkedListNode node = remove.RemoveDuplicates (node1);
//
//			ReverseLinkedList reverse = new ReverseLinkedList ();
//			LinkedListNode node = reverse.Reverse (node1);
//
//			LinkedList l = new LinkedList ();
//			LinkedListNode node = l.DeleteNode (node1, 6);
//
//			RemoveNodeOfGivenValue remove = new RemoveNodeOfGivenValue ();
//			remove.RemoveNode (node1, 1);
//
			//LinkedList ll = new LinkedList ();

			//LinkedListNode n = ll.DeleteNode (node1,3);


//			LinkedListNode nodeA = new LinkedListNode ();
//			LinkedListNode nodeB = new LinkedListNode ();
//			LinkedListNode nodeC = new LinkedListNode ();
//			nodeA.setData (1);
//			nodeA.setNext (nodeB);
////			node3.setNext (nodeA);
//			nodeB.setData (2);
//			nodeB.setNext (nodeC);
//			nodeC.setData (2);
//			nodeC.setNext (null);
////
//			AddLinkedListNode obj = new AddLinkedListNode ();
//			LinkedListNode n  = obj.AddTwoNumbers (node1, nodeA);
//			Console.WriteLine ("{0}", n);

//			RemoveDupsFromLinkedList dups = new RemoveDupsFromLinkedList ();
//			LinkedListNode n = dups.RemoveDuplicates (nodeA);
//			Console.WriteLine ("{0}", n);
//
//			PalindromeLinkedList pl = new PalindromeLinkedList ();
//			bool val = pl.IsLinkedListPalindrome (node1);
//			Console.WriteLine ("Is palindrome-:{0}", val);
//
//			LinkedListIntersection li = new LinkedListIntersection ();
//			int val = li.FindIntersection (node1, nodeA);
//			Console.WriteLine ("{0}", val);
//

//			NthNodeFromLast node = new NthNodeFromLast ();
//			LinkedListNode n =  node.FindNode (node1, 2);
//			Console.WriteLine ("value is {0}", n.getData ());
//
//			MergeLinkedList merge = new MergeLinkedList ();
//			LinkedListNode merged = merge.MergeTwoLinkedList (node1, node5);
//			Console.WriteLine ("{0}", merged);
//
//			FindMid fm = new FindMid ();
//			LinkedListNode ll = fm.FindCenter (node1);
//			Console.WriteLine ("center is-: {0}", ll.getData ());

//			ReverseLinkedList rev = new ReverseLinkedList ();
//			LinkedListNode l =  rev.RecursiveReverse (node1, null);
//			Console.WriteLine ("Linked List after reversal is-: {0}", l);
		}
	}

	public class LinkedListNode
	{
		private LinkedListNode next;
		private int data;
		private bool Isvisited;

		public LinkedListNode()
		{

		}

		public LinkedListNode(int data)
		{
			this.data = data;
		}

		public int getData()
		{
			return this.data;
		}


		public void setData(int value)
		{
			data = value;
		}

		public void setNext(LinkedListNode value)
		{
			next = value;
		}

		public LinkedListNode getNext()
		{
			return this.next;
		}

		public void setVisited(bool value)
		{
			Isvisited = value;
		}

		public bool getVisited()
		{
			return this.Isvisited;
		}
	}



}
