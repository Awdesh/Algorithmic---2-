using System;
using System.Collections.Generic;

namespace HomePractice
{
	public class StringDups
	{
		public StringDups ()
		{
		}

		public void StringDuplicates(string str)
		{
			Dictionary<char,int> d = new Dictionary<char, int> ();
			for (int i = 0; i<str.Length; i++) {
				if (!d.ContainsKey (str [i]))
					d.Add (str [i], 1);
				else {
					d [str [i]] += 1;
				}
			}

			foreach (var pair in d) {
				if (pair.Key == 1)
					Console.WriteLine ("{0}", pair.Key);
				else
					Console.WriteLine("{0}--->{1}", pair.Key, pair.Value);
			}


		}
	}
}

