using System;
using System.Text;
using System.Collections.Generic;

namespace HomePractice
{
	public class xome
	{
		public xome ()
		{
		}

		/// <summary>
		/// Simplify the specified path.
		/// </summary>
		/// <param name="path">Path.</param>
		public string Simplify(string path)
		{
			string[] chArr = path.Split ('/');
			List<string> l = new List<string> ();

			foreach (string s in chArr) 
			{
				if (s != ".." && s != ".")
					l.Add (s);
				else if (s == ".." && l.Count > 0)
					l.RemoveAt (l.Count - 1);
			}

			string result = string.Join ("/", l.ToArray ());
			return result;
		}
	}
}

