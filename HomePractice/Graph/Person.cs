using System;
using System.Collections.Generic;

namespace Graph
{
	public class Person
	{
		public Person()
		{

		}

		public Person(string name)
		{
			this.name = name;
		}

		public string name { get; set; }
		List<Person> FriendsList = new List<Person>();
		public bool IsDiscovered = false;

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

		public Person BuildFriendGraph1()
		{
			Person A = new Person("A");
			Person B = new Person("B");
			Person C = new Person("C");
			Person D = new Person("D");
			A.isFriendOf(B);
			A.isFriendOf(C);
			A.isFriendOf (D);

			Person E = new Person("E");
			Person F = new Person("F");
			D.isFriendOf (B);
			D.isFriendOf (E);
			D.isFriendOf (F);

			Person G = new Person("G");
			E.isFriendOf(C);
			E.isFriendOf(F);
			E.isFriendOf(G);

			return A;
		}
	}
}

