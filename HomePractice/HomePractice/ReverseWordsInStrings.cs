using System;
using System.Text;
using System.Collections.Generic;


namespace HomePractice
{
	/// <summary>
	/// Reverse words in strings.
	/// </summary>
	public class ReverseWordsInStrings
	{
		public ReverseWordsInStrings ()
		{
		}

		List<string> OutputList = new List<string> ();

		/// <summary>
		/// Reverse the specified str.
		/// </summary>
		/// <param name="str">String.</param>
		private void Reverse(List<char> str)
		{
			string st = string.Join ("", str.ToArray ());
			int start = 0;
			int end = st.Length - 1;
			char[] chArr = st.ToCharArray ();

			while (start <= end) {
				char temp = chArr [start];
				chArr [start] = chArr [end];
				chArr [end] = temp;
				start++;
				end--;
			}

			OutputList.Add (new string(chArr));
		}

		/// <summary>
		/// Reverses the sentence.
		/// </summary>
		/// <param name="s">S.</param>
		public string ReverseSentence(string s)
		{
			if (s.Length <= 0) {
				return s;
			}

			if (s.Length == 1) {
				return s;
			}

			if (!s.Contains(" ")) {
				return s;
			}

			Stack<char> stack = new Stack<char>();
			char[] charArr = s.ToCharArray ();

			foreach(char c in charArr)
			{
				stack.Push (c);
			}

			List<char> l = new List<char> ();
			while (stack.Count != 0) 
			{
				char c = stack.Pop ();
				if (c != ' ') 
				{
					// stores the characters inside a list.
					l.Add (c);
				}
				// As soon as empty char found that means a word has ended, pass list containing word and reverse it.
				else 
				{
					Reverse (l);
					l.Clear ();
				}
			}

			if (l.Count != 0) {
				Reverse (l);
			}
			// creates a string from a list. Joins the item inside the list by inserting " " between them.
			string result = string.Join(" ", OutputList.ToArray());
			result.TrimEnd ();
			return result;
		}
	}
}

