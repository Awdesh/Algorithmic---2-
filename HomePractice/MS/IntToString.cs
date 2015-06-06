using System;
using System.Collections.Generic;

namespace MSSelection
{
	public class IntToString
	{
		public IntToString ()
		{
		}

		public static string Converter(int num)
		{
			int digit = 0;
			char[] temp = new char[3];
			List<char> l = new List<char> ();

			while (num != 0) 
			{
				digit = num % 10;
				char c = (char)((digit) + '0');
				l.Add (c);
				num = num / 10;
			}

			System.Text.StringBuilder sb = new System.Text.StringBuilder ();
			int i = l.Count;

			while (i>0)
			{
				sb.Append (l[i-1]);
				i -= 1;
			}
			return sb.ToString ();
		}
	}
}

