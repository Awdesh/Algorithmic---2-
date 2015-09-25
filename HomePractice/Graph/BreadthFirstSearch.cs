using System;
using System.Collections.Generic;

namespace Graph
{
	public class BreadthFirstSearch
	{

		/// <summary>
		/// Prints the each level of friends.
		/// </summary>
		/// <param name="root">Root.</param>
		public void PrintEachLevel(Person root)
		{
			Queue<Person> Q = new Queue<Person> ();
			List<Person> friends = new List<Person> ();
			Q.Enqueue (root);
			friends.Add (root);
			root.IsDiscovered = true;
			int cnt = 1;

			while (Q.Count > 0) 
			{
				Person p = Q.Dequeue ();
				Console.Write ("Level-: {0}", cnt++);
				foreach (Person friend in p.Friends) 
				{
					if (!friend.IsDiscovered) 
					{
						Console.Write (friend.name);
						Q.Enqueue (friend);
						friend.IsDiscovered = true;
					}
				}
			}
		}

		/// <summary>
		/// Traverse the specified root.
		/// </summary>
		/// <param name="root">Root.</param>
		public void Traverse(Person root)
		{
			Queue<Person> traverseOrder = new Queue<Person>();

			Queue<Person> Q = new Queue<Person>();
			Q.Enqueue(root);
			root.IsDiscovered = true;

			while (Q.Count > 0)
			{
				Person p = Q.Dequeue();
				traverseOrder.Enqueue(p);

				foreach (Person friend in p.Friends)
				{
					if (!friend.IsDiscovered)
					{
						Q.Enqueue(friend);
						friend.IsDiscovered = true;
					}
				}
			}

			while (traverseOrder.Count > 0)
			{
				Person p = traverseOrder.Dequeue();
				Console.WriteLine(p);
			}
		}

		//http://en.wikipedia.org/wiki/Breadth-first_search#Pseudocode
		public Person Search(Person root, string nameToSearchFor)
		{
			Queue<Person> Q = new Queue<Person>();
			List<Person> S = new List<Person>();
			Q.Enqueue(root);
			S.Add(root);

			while (Q.Count > 0)
			{
				Person p = Q.Dequeue();
				if (p.name == nameToSearchFor)
					return p;
				foreach (Person friend in p.Friends)
				{
					if (!S.Contains(friend))
					{
						Q.Enqueue(friend);
						S.Add(friend);
					}
				}
			}
			return null;
		}


	}
}

