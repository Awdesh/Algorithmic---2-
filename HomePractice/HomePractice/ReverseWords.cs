using System;
using System.Collections.Generic;

namespace HomePractice
{
	public class ReverseWords
	{
		public ReverseWords ()
		{
		}

		/// <summary>
		/// Reverses the words in place.
		/// </summary>
		/// <returns>The words in place.</returns>
		/// <param name="input">Input.</param>
		public string ReverseWordsInPlace(string input)
		{
			if( input == null || input.Length == 0 )
			{
				return String.Empty;
			}

			if(input.Length == 1)
			{
				return input;
			}

			char[] chArr = input.ToCharArray ();
			char[] reverse = Reverse(chArr, 0, input.Length - 1); 

			int start = 0;
			int end = 0;

			// traverse over length
			while(end < reverse.Length)
			{
				if(reverse[end] != ' ')
				{
					start = end;
					// reverse words
					while( end < reverse.Length && reverse[end] != ' ')
					{
						end++; // 1,2
					}
					end--;

					Reverse(reverse, start, end);
				}

				end += 1;
			}

			return chArr.ToString();
		}


		// Helper method.
		public char[] Reverse(char[] s, int start, int end)
		{
			char temp = ' ';

			while(start <= end)
			{
				temp = s[start];
				s[start] = s[end];
				s[end] = temp;
				start++;
				end--;
			}
			return s;
		}

		/// <summary>
		/// Reverses the words using stack.
		/// </summary>
		/// <returns>The words using stack.</returns>
		/// <param name="input">Input.</param>
		public string ReverseWordsUsingStack(string input)
		{
			int end = input.Length - 1;
			Stack<char> stack = new Stack<char> ();
			System.Text.StringBuilder sb = new System.Text.StringBuilder ();

			while (end >= 0) 
			{
				if (input [end] != ' ') 
				{
					stack.Push (input [end]);
				}
				else
				{
					while(stack.Count > 0)
					{
						sb.Append(stack.Pop());
					}
					sb.Append(' ');
				}
				end--;
			}

			while(stack.Count > 0)
			{
				sb.Append(stack.Pop());
			}

			return sb.ToString ();
		}


		public string Reverse1(string input)
		{
			string[] strArr = input.Split (' ');
		Stack<string> s = new Stack<string> ();

			foreach (string s1 in strArr) 
			{
				s.Push (s1);
			}

		System.Text.StringBuilder sb = new System.Text.StringBuilder ();
			while (s.Count > 0) {
				sb.Append (s.Pop ());
				sb.Append (" ");
			}

			return sb.ToString ();
		}


		/// <summary>
		/// Reverses the words using stack.
		/// </summary>
		/// <returns>The words using stack.</returns>
		/// <param name="s">S.</param>
		public string ReverseWordsUsingStack1(string s)
		{
			Stack<char> stack = new Stack<char> ();
			char[] chArr = s.ToCharArray ();

			List<char> small = new List<char> ();
			bool[] asciiArr = new bool[127];

			for (int i = 65; i <= 91; i++)
			{
				asciiArr [i] = true;
			}

			for (int i = 97; i <= 122; i++)
			{
				asciiArr [i] = true;
			}

			for (int i = 0; i< chArr.Length; i++) {
				stack.Push (chArr [i]);
			}

			System.Text.StringBuilder sb = new System.Text.StringBuilder ();
			System.Text.StringBuilder res = new System.Text.StringBuilder ();
			System.Text.StringBuilder specialChar = new System.Text.StringBuilder ();

			while (stack.Count > 0) 
			{
				char c = stack.Pop ();

				if (asciiArr [Convert.ToInt32 (c)] == false && c != ' ') {
					specialChar.Append (c);
					continue;
				}

				if (c != ' ' ) 
				{
					sb.Append (c);
				}

				else
				{
					char[] arr = sb.ToString ().ToCharArray ();
					Reverse (arr, 0, arr.Length - 1);

					res.Append (arr);
					res.Append (' ');
					// clear sb to start processing new word.
					sb.Clear ();
				}
			}

			// sb still contains the last word which encountered after the space.
			if (sb.Length > 0) {
				char[] arr = sb.ToString ().ToCharArray ();
				Reverse (arr, 0, arr.Length - 1);

				res.Append (arr);
			}

			res.Append (specialChar.ToString ().ToCharArray ());

			return res.ToString ();
		}
	}
}

