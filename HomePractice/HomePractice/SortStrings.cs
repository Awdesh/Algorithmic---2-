using System;
using System.Collections.Generic;

namespace HomePractice
{
	public class SortStrings
	{
		public SortStrings ()
		{
		}

		public void SortCollectionOfStrings(string[] arr)
		{
			SortedDictionary<int, string> dict = new SortedDictionary<int,string> ();
			int count = 1;
			foreach (string s in arr) {
				dict.Add (count,s);
				count++;
			}
			foreach (string s in dict.Values) {
				Console.WriteLine (s);
			}
		}
	}
}

