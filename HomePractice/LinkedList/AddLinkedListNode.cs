using System;

namespace LinkedList
{
	public class AddLinkedListNode
	{
		public AddLinkedListNode ()
		{
		}
				public LinkedListNode AddTwoNumbers(LinkedListNode l1, LinkedListNode l2) {
					LinkedListNode r1 = l1;
					LinkedListNode r2 = l2;

					LinkedListNode fakeHead = new LinkedListNode(0);
					LinkedListNode newList = fakeHead;
					int carryForward = 0;
					while(r1!=null && r2!=null){

						int sum = r1.getData () + r2.getData ();
						if(carryForward == 1)
							sum = sum + carryForward;

						if(sum > 9)
						{
							sum = sum % 10;
							carryForward = 1;
						}

						newList.setNext(new LinkedListNode(sum));
						newList = newList.getNext ();
						r1 = r1.getNext();   
						r2 = r2.getNext();
					}

					while(r1!=null)
					{
						newList.setNext( new LinkedListNode(r1.getData() + carryForward));
						carryForward = 0;
						newList = newList.getNext ();
					}

					while(r2!=null)
					{
						newList.setNext(new LinkedListNode(r2.getData() + carryForward));
						carryForward = 0;
						newList = newList.getNext ();
					}

					return fakeHead.getNext();
				}
	}
}

