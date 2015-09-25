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
			LinkedListNode node7 = new LinkedListNode ();
			LinkedListNode node8 = new LinkedListNode ();


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
			node6.setNext (node7);
			node7.setData (7);
			node7.setNext (node8);
			node8.setData (8);
			node8.setNext (null);


			SwapEvenNodes s = new SwapEvenNodes ();

			s.Swap (node1);

//			LinkedListNode node10 = new LinkedListNode();
//			LinkedListNode node5 = new LinkedListNode();
//			LinkedListNode node12 = new LinkedListNode();
//			LinkedListNode node7 = new LinkedListNode();
//			LinkedListNode node11 = new LinkedListNode();
//			LinkedListNode node4 = new LinkedListNode();
//			LinkedListNode node20 = new LinkedListNode();
//			LinkedListNode node2 = new LinkedListNode();
//			LinkedListNode node13 = new LinkedListNode();
//			LinkedListNode node16 = new LinkedListNode();
//			LinkedListNode node3 = new LinkedListNode();
//			LinkedListNode node17 = new LinkedListNode();
//			LinkedListNode node9 = new LinkedListNode();
//			LinkedListNode node19 = new LinkedListNode();
//			LinkedListNode node6 = new LinkedListNode();
//			LinkedListNode node15 = new LinkedListNode();
//			LinkedListNode node8 = new LinkedListNode();
//
//			node10.setData (10);
//			node10.setNext (node5);
//			node10.child = node4;
//			node11.setData (11);
//			node12.setData (12);
//			node12.setNext (node7);
//			node13.setData (13);
//			node13.child = node16;
//			node15.setData (15);
//			node16.setData (16);
//			node16.child = node3;
//			node17.setData (17);
//			node17.setNext (node6);
//			node17.child = node9;
//			node19.setData (19);
//			node19.setNext (node15);
//			node2.setData (2);
//			node20.setData (20);
//			node20.setNext (node13);
//			node20.child = node2;
//			node3.setData (3);
//			node4.setData (4);
//			node4.setNext (node20);
//			node5.setData (5);
//			node5.setNext (node12);
//			node6.setData (6);
//			node7.setData (7);
//			node7.setNext (node11);
//			node7.child = node17;
//			node8.setData (8);
//			node9.setData (9);
//			node9.setNext (node8);
//			node9.child = node19;

			//Flatten fl = new Flatten ();
			//LinkedListNode temp = fl.FlattenIt (node10);

			//LinkedListNode temp = fl.FlatternOrder (node10);

//			RemoveSecondLastNode rem = new RemoveSecondLastNode ();
//			LinkedListNode n = rem.Remove (node1);
//			Console.WriteLine ("{0}", n.getData ());




//			SecondLastNode second = new SecondLastNode ();
//			LinkedListNode node = second.FindNode (node1);
//
//			ReverseGroup reverse = new ReverseGroup ();
//			LinkedListNode n = reverse.ReverseInGroup (node1, 2);


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

		public LinkedListNode child;


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
