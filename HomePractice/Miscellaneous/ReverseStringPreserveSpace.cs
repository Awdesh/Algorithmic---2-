using System;
using System.Collections.Generic;

namespace Miscellaneous
{
	public class ReverseStringPreserveSpace
	{
		public ReverseStringPreserveSpace ()
		{
		}

		public string Reverse(string s)
		{
			int i = 0;
			int j = s.Length - 1;
			char[] chArr = s.ToCharArray ();

			while (i < j) {
				if (chArr [i] == ' ') 
				{
					i++;
					continue;
				}

				if (chArr [j] == ' ') 
				{
					j--;
					continue;
				}

				char temp = chArr [i];
				chArr [i] = chArr [j];
				chArr [j] = temp;
				i++;
				j--;
			}
			return chArr.ToString();
		}

		/// <summary>
		/// Reverses the string. Better version using stack.
		/// </summary>
		/// <returns>The string.</returns>
		/// <param name="s">S.</param>
		public string ReverseString(string s)
		{
			Stack<char> stack = new Stack<char>();
			Queue<int> spaceQueue = new Queue<int> ();
			char[] chArr = s.ToCharArray ();

			// fill in one stack with all the letters, other stack with the position of the spaces.
			for (int i = 0; i < chArr.Length; i++) {
				if (chArr[i] != ' ')
					stack.Push (chArr[i]);
				else
					spaceQueue.Enqueue (i);
			}

			int count = 0;
			System.Text.StringBuilder sb = new System.Text.StringBuilder ();
			while (stack.Count > 0) {
				// as soon as you hit the space position, append the space and dequee an element out of space.
				if ( spaceQueue.Count > 0 && spaceQueue.Peek () == count) {
					sb.Append (" ");
					spaceQueue.Dequeue ();
				} else {
					sb.Append (stack.Pop ());
				}
				count++;
			}

			return sb.ToString ();
		}
	}
}

