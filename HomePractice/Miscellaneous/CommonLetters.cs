using System;

namespace Miscellaneous
{
	public class CommonLetters
	{
		/// <summary>
		/// Finds the string.
		/// </summary>
		/// <returns>The string.</returns>
		/// <param name="s1">S1.</param>
		/// <param name="s2">S2.</param>
		public string FindCommonLetters(string s1, string s2)
		{
			bool[] flags = new bool[128];

			char[] chArr1 = s1.ToCharArray ();
			foreach (char c in chArr1) 
			{
				int ii = Convert.ToInt32 (c);
				flags[Convert.ToInt32(c)] = true;
			}

			System.Text.StringBuilder sb = new System.Text.StringBuilder ();
			for (int i = 0 ; i < flags.Length; i++) {
				if (flags [i]) {
					sb.Append ((char)i);
				}
			}
			return sb.ToString ();
		}
	}
}

