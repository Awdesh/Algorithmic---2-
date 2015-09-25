using System;
using System.Collections.Generic;

namespace Graph
{
	public class DepthFirstSearch
	{
		public DepthFirstSearch ()
		{
		}

		public void Traverse(Person root)
		{
			Stack<Person> S = new Stack<Person> ();
			S.Push (root);
			root.IsDiscovered = true;
			Console.WriteLine (root.name);

			while (S.Count > 0) 
			{
				Person p = S.Peek ();

				foreach (Person person in p.Friends) {
					if (!person.IsDiscovered) {
						person.IsDiscovered = true;
						Console.WriteLine (person.name);
						S.Push (person);
					} else {
						S.Pop ();
					}
				}
			}
		}
	}
}

