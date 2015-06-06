using System;
using System.Collections.Generic;

namespace MSSelection
{
	public class DuplicateInString
	{
		public DuplicateInString ()
		{
		} 

		public void FindDuplicate(string input)
		{
			if(input.Length <= 1 || input == null)
			{
				return;
			}

			Dictionary<char, int> map = new Dictionary<char, int> ();
			foreach (char c in input) {
				if (!map.ContainsKey (c)) {
					map.Add (c, 1);
				} else {
					Console.WriteLine ("Dup is -: {0}", c);
				}
			}
		}

		public void FindDupBad(string input)
		{
			if(input.Length <= 1 || input == null)
			{
				return;
			}

			for(int i = 0; i <input.Length - 1;i++) {
				for (int j = i + 1; j < input.Length; j++) {
					if (input [i] == input [j]) {
						Console.WriteLine ("dup is -: {0}", input [i]);
						break;
					}
				}
			}

		}
	}
}

