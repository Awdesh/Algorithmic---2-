using System;

namespace StackandQueues
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Stack s = new Stack (10);
			Console.WriteLine("Stack is -: {0}", s.isEmpty () ? "Empty" : "NotEmpty");
			s.Push (14);
			s.Push (2);
			Console.WriteLine ("Pushing 2 items inside the stack, Current size of stack is {0}", s.Count());
			Console.WriteLine("Stack is -: {0}", s.isEmpty () ? "Empty" : "NotEmpty");
			Console.WriteLine ("Minimum Element inside Stack is-: {0}", s.Min ());
			//int item = s.Pop ();
		//	Console.WriteLine ("Items popped out is-: {0}, and Current size of stack is {1}", item, s.Count());
			Console.WriteLine("Stack is -: {0}", s.isEmpty () ? "Empty" : "NotEmpty");
			Console.WriteLine ("Pushing an item inside the stack");
			s.Push (3);
			s.Push (5);
			s.Push (1);
			s.Push (15);
			Console.WriteLine ("Current size of stack is {0}", s.Count());
			int data = s.Peek ();
			Console.WriteLine ("Items peeked out is-: {0}, and Current size of stack is {1}", data, s.Count());
			Console.WriteLine ();
			Console.WriteLine ("Minimum Element inside Stack is-: {0}", s.Min ());
			Console.WriteLine ();
			Console.WriteLine ("*********************************************************************************");
			int max = s.Max ();


//			Queue q = new Queue ();
//			Console.WriteLine("Queue is -: {0}", q.IsEmpty () ? "Empty" : "NotEmpty");
//			q.Enqueue (5);
//			q.Enqueue (10);
//			Console.WriteLine ("Adding 2 items inside the queue, Current size of queue is {0}", q.Count());
//			Console.WriteLine("Queue is -: {0}", q.IsEmpty () ? "Empty" : "NotEmpty");
//			int item1 = q.Dequeue ();
//			Console.WriteLine ("Items popped out is-: {0}, and Current size of queue is {1}", item1, q.Count());
//			Console.WriteLine("Queue is -: {0}", q.IsEmpty () ? "Empty" : "NotEmpty");
//			Console.WriteLine ("Adding an item inside the queue");
//			q.Enqueue (15);
//			int item2 = q.Dequeue ();
//			Console.WriteLine ("Items popped out is-: {0}, and Current size of queue is {1}", item2, q.Count());
//			Console.WriteLine ("Current size of queue is {0}", q.Count());
//			int item3 = q.Dequeue ();
//			Console.WriteLine ("Items popped out is-: {0}, and Current size of queue is {1}", item3, q.Count());
//
//			Console.WriteLine ();
//			Console.WriteLine ("*********************************************************************************");
//
//			int[] array = {2,4,5,3,4,5,7,8,9,6};
//			TwoStacksFromArray tsfa = new TwoStacksFromArray(array);
//
//			Console.WriteLine ();
//			Console.WriteLine ("*********************************************************************************");
//
//			Console.WriteLine("Pushing Values inside Stack");
//			StackUsingLinkedList sul = new StackUsingLinkedList();
//			sul.Push(5);
//			sul.Push(15);
//			sul.Push(10);
//			sul.Push(12);
//			sul.Push(13);
//			sul.Push(18);
//
//			Console.WriteLine("Size of the Stack is-: {0}", sul.Count());
//			Console.WriteLine("Popping Values out of Stack");
//			Console.WriteLine("top most value is-: {0}", sul.Pop());
//			Console.WriteLine("Size of the Stack is-: {0}", sul.Count());
//
//			Console.WriteLine ();
//			Console.WriteLine ("*********************************************************************************");
//
//			Stack s1 = new Stack(4);
//			s1.Push(2);
//			s1.Push(3);
//			s1.Push(1);
//			s1.Push(5);
//
//			Console.WriteLine("Size of the Stack is-: {0}", s1.Count());
//			Console.WriteLine("Popping Values out of Stack");
//			Console.WriteLine("top most value is-: {0}", s1.Pop());
//			Console.WriteLine("Size of the Stack is-: {0}", s1.Count());
//			Console.WriteLine("min value in stack is-: {0}", s1.Min());
//
//			TwoStacks ts = new TwoStacks(5);
//			ts.Push1(2);
//			ts.Push2(3);
//			ts.Push1(4);
//			ts.Push2(5);
//			Console.WriteLine("Value Popped from Stack 1  is -: {0}", ts.Pop1());
//			Console.WriteLine("Value Popped from Stack 2  is -: {0}", ts.Pop2());
//
//
//			StackMedian sm = new StackMedian(5);
//			sm.Push(2);
//			sm.Push(5);
//			sm.Push(3);
//			sm.Push(6);
//			sm.Push(4);
		}
	}
}
