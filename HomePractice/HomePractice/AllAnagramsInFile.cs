using System;
using System.Collections.Generic;

namespace HomePractice
{
	public class AllAnagramsInFile
	{
		public AllAnagramsInFile ()
		{
		}

		/// <summary>
		/// Finds all anagrams present in a file.
		/// </summary>
		/// <param name="file">File.</param>
		public void FindAllAnagrams(string[] file)
		{
			Dictionary<string, string> map = new Dictionary<string, string> ();
			foreach (string word in file) 
			{
				char[] chArr = word.ToCharArray ();
				Array.Sort (chArr);

				// this conversion of string is necessary for map to handle duplicates.
				string word1 = new string (chArr);
				if (!map.ContainsKey (word1)) 
				{
					map.Add (word1, word);
				}
				else
				{
					string w = String.Empty;
					map.TryGetValue (word1, out w);
					Console.Write ("{0}", word);
					Console.WriteLine (" -- {0}", w);
				}
			}
		}
	}
}

