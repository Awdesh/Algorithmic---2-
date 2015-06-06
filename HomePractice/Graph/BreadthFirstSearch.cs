using System;
using System.Collections.Generic;

namespace Graph
{
	public class Person
	{
		public Person(string name)
		{
			this.name = name;
		}

		public string name { get; set; }
		List<Person> FriendsList = new List<Person>();

		public List<Person> Friends
		{
			get
			{
				return FriendsList;
			}
		}

		public void isFriendOf(Person p)
		{
			FriendsList.Add(p);
		}

		public override string ToString()
		{
			return name;
		}
	}

	public class BreadthFirstSearch
	{
		public Person BuildFriendGraph()
		{
			Person Aaron = new Person("Aaron");
			Person Betty = new Person("Betty");
			Person Brian = new Person("Brian");
			Aaron.isFriendOf(Betty);
			Aaron.isFriendOf(Brian);

			Person Catherine = new Person("Catherine");
			Person Carson = new Person("Carson");
			Person Darian = new Person("Darian");
			Person Derek = new Person("Derek");
			Betty.isFriendOf(Catherine);
			Betty.isFriendOf(Darian);
			Brian.isFriendOf(Carson);
			Brian.isFriendOf(Derek);

			return Aaron;
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

		public void Traverse(Person root)
		{
			Queue<Person> traverseOrder = new Queue<Person>();

			Queue<Person> Q = new Queue<Person>();
			List<Person> S = new List<Person>();
			Q.Enqueue(root);
			S.Add(root);

			while (Q.Count > 0)
			{
				Person p = Q.Dequeue();
				traverseOrder.Enqueue(p);

				foreach (Person friend in p.Friends)
				{
					if (!S.Contains(friend))
					{
						Q.Enqueue(friend);
						S.Add(friend);
					}
				}
			}

			while (traverseOrder.Count > 0)
			{
				Person p = traverseOrder.Dequeue();
				Console.WriteLine(p);
			}
		}
	}
}

